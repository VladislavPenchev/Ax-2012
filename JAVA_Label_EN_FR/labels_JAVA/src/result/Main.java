package result;

import ReadFromFile.Label;

import java.io.*;
import java.util.*;
import java.util.stream.Collectors;

public class Main {

    public static final String LANGUAGE_EN_US = "en-us";
    public static final String LANGUAGE_FR = "fr";
    public static final String LabelAttribute = "HVP";
    public static final String path =  String.format("C:\\Users\\vladislav.penchev\\Desktop\\labels_JAVA\\src\\TestJava\\ReadFiles\\ax%sfr.ald",LabelAttribute);


    public static void main(String[] args) throws IOException {
        //-----
        //init
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        Map<String,List<LabelALD>> contentInformation = new LinkedHashMap<>();
        List<LabelALD> labelsALD = new ArrayList<>();

        Map<String,List<Label>> result = new LinkedHashMap<>();
        List<Label> labels = new ArrayList<>();

        List<String> resRes = new ArrayList();

        StringBuilder sb = new StringBuilder();

        File file = new File("out.txt");
        FileWriter fw = new FileWriter(file);
        PrintWriter pw = new PrintWriter(fw);

        //-----

        //return map with sorted data from marketing
        readInput(reader, result, labels);

        //get modules
        List<String> listLabelModule = LabelModules(reader);


        //get content
        String content = ReadFile(path);

        //return map with sorted data from content
        mapContentInformation(content,contentInformation,labelsALD);


        result.entrySet()
                .stream()
                .forEach(x -> {


                    String id = x.getKey();
                    //System.out.println(id);

                    List<String> temp = new ArrayList<>();

                    x.getValue()
                            .stream()
                            .filter(y -> y.getLanguage().equals("fr"))
                            .filter(y -> y.getId().equals(id))
                            .forEach(y -> {
                                temp.add(y.getValue());
                                temp.add(y.getDescription());
                            });


                    RefactoringInput(resRes, content, id, temp,sb);

                });


        //System.out.println(sb);
        //System.out.println("-----------");
        //System.out.println(resRes.get(resRes.size() - 2));


        //Save to file
        //pw.println(sb);
        pw.println(resRes.get(resRes.size() - 2));


        pw.close();

        String debug = "";



    }

    private static void RefactoringInput(List<String> resRes, String content, String id, List<String> temp, StringBuilder sb) {

        //if exist and length are sames
        if(content.contains(id)){

            id = checkGetproperId(content, id);

            if(resRes.size() > 0){
                content = resRes.get(resRes.size() - 2);
            }

            int indexId = content.indexOf(id);

            String sub = content.substring(indexId, indexId + id.length());
            String res = content.replace(sub,id);


            int rn = res.indexOf("\r\n",indexId);
            String label = res.substring(indexId + id.length() + 1,rn);
            res = res.replace(label,temp.get(0));

            //description
//            if(!temp.get(1).equals("\t\t")){
//                System.out.println("in2");
//            }

//            if(!temp.get(1).equals("")){
//                System.out.println(1);
//            }
//            if(temp.get(1).equals(res.substring(rn,rn + 1))){
//                System.out.println(2);
//            }

            if(!temp.get(1).equals("") || temp.get(1).equals(res.substring(rn,rn + 1))){

                rn = res.indexOf("\r\n",indexId);

                int nextRn = res.indexOf("\r\n",rn + 1);

                String description = res.substring(rn,nextRn);
                //String description = res.substring(indexId + id.length() + 1 + temp.get(0).length() + 2,nextRn);
                res = res.replace(description,temp.get(1));
            }

            resRes.add(res);

            indexId = res.indexOf(id);

            int sign = res.indexOf("@") + indexId;
            int nextSign = res.indexOf("@",sign + 1);

            if(nextSign == -1){
                res = res.substring(indexId);
            }else{
                res = res.substring(indexId,nextSign);
            }


            resRes.add(res);

            //sb.append(res);

        }else if (id.contains(LabelAttribute)){
            //create
            if(!temp.get(1).equals("")){
                temp.add(temp.get(temp.size() - 1) + "\r\n");
            }
            String create = String.format("%s %s\r\n%s",id,temp.get(0),temp.get(1));

            if (resRes.size() > 0){
                resRes.add(resRes.get(resRes.size() - 2) + create);
            }else{
                content += create;
                resRes.add(content);
            }

            resRes.add(create);

        }
    }

    private static String checkGetproperId(String content, String id) {
        //get index id(input) from content
        int index = content.indexOf(id);

        //+1(next symbol is digit or backspace);
        String testRes = content.substring(index,index + id.length() + 1);

        String tempId = id + " ";

        if(!testRes.equals(tempId)){
           return testRes;
            return id;
        }

    }

    private static String ReadFile(String str) throws IOException {

        FileReader fr=new FileReader(str);

        StringBuilder sb = new StringBuilder();
        int index;

        while((index=fr.read())!=-1){

            sb.append((char)index);
        }

        String res = sb.toString();

        fr.close();

        return res;
    }


    private static List<String> LabelModules(BufferedReader reader) throws IOException {
        List<String> line = Arrays.stream(reader.readLine().split(","))
                .map(x -> x.substring(1,4))
                .distinct()
                .collect(Collectors.toList());
        return line;
    }

    private static void readInput(BufferedReader reader, Map<String, List<Label>> result, List<Label> labels) throws IOException {
        String line;

        while (!"END".equals(line = reader.readLine())) {
            List<String> temp = Arrays.stream(line.split("\\s\\$+\\s"))
                    .collect(Collectors.toList());

            if (temp.size() == 2) {
                temp.add("");
                temp.add("");
            } else if (temp.size() == 3) {
                temp.add("");
            }

            String id = temp.get(0);
            String usLanguage = temp.get(1);
            String frLanguage = temp.get(2);
            String description = temp.get(3);

            Label labelUs = new Label(id, LANGUAGE_EN_US, usLanguage, description);
            Label labelFr = new Label(id, LANGUAGE_FR, frLanguage, description);


            labels.add(labelUs);
            labels.add(labelFr);

            result.put(id, labels);

            labels = new ArrayList<>();
        }
    }

    private static void mapContentInformation(String content, Map<String, List<LabelALD>> result, List<LabelALD> labels) throws IOException {
        String[] line = content.split("\\n");

            for(int i = 0; i < line.length; i+=2){{

                String[] idAndLabel = line[i].split("\\s+",2);

                String id = "";
                String frLanguageLabel = "";
                String description = "";


                if(idAndLabel[0].equals("")){
                    continue;
                }else{
                    id = idAndLabel[0];
                }

                if(idAndLabel[1].equals("")){
                    frLanguageLabel = ".";
                }else{
                    frLanguageLabel = idAndLabel[1].substring(0,idAndLabel[1].length() - 1);
                }

                if( i+1 > (line.length - 1)){
                    description = "";
                }else{
                    if(line[i + 1].equals("") || line[i + 1].contains("@")){
                        description = "";
                        i--;
                    }else{
                        description = line[i + 1].substring(0,line[i + 1].length() - 1);
                    }
                }



                LabelALD labelALD = new LabelALD(id,frLanguageLabel,description);

                labels.add(labelALD);

                result.put(id,labels);

                labels = new ArrayList<>();
            }
        }
    }
}
