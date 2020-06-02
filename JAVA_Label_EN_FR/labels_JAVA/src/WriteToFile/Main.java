package WriteToFile;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.*;

public class Main {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        StringBuilder builder = new StringBuilder();

        Map<String, List<Label>> result = new LinkedHashMap<>();
        List<Label> labels = new ArrayList<>();

        List<String> inputSplite = new ArrayList<>();


        splitRecords(reader, builder, inputSplite);

        List<String[]> arrLineSplite = new ArrayList<>();

        for (String recInputSplit : inputSplite) {
            String[] tempArr = recInputSplit.split("\\n");
            arrLineSplite.add(tempArr);
        }

        for (String[] line : arrLineSplite) {

            String language = "";
            String label = "";
            String id = "";
            String description = "";

            for (String rec : line) {

                //get Languaue
                if(rec.contains("Language")){
                    int startIndex = rec.indexOf("\">");
                    int endIndex = rec.indexOf("</Table:Field>");
                    language = rec.substring(startIndex + 2,endIndex);
                    //System.out.println(language);
                }

                //get Label
                if(rec.contains("name=\"Label\"")){
                    int startIndex = rec.indexOf("\">");
                    int endIndex = rec.indexOf("</Table:Field>");
                    label = rec.substring(startIndex + 2,endIndex);
                    //System.out.println(label);
                }

                //get ID
                if(rec.contains("LabelId")){
                    int startIndex = rec.indexOf("\">");
                    int endIndex = rec.indexOf("</Table:Field>");
                    id = rec.substring(startIndex + 2,endIndex);
                    //System.out.println(id);
                }

                if(rec.contains("Description")){
                    int startIndex = rec.indexOf("\">");
                    int endIndex = rec.indexOf("</Table:Field>");
                    description = rec.substring(startIndex + 2,endIndex);
                    //System.out.println(id);
                }

            }



            Label objLabel = new Label(language,label,description);
            labels.add(objLabel);

            if(!result.containsKey(id)){
                result.put(id,new ArrayList<>());
            }else{
                labels = result.get(id);
                labels.add(objLabel);
            }

            result.put(id,labels);

            labels = new ArrayList<>();

            //System.out.println("--------------------");
        }

        String debug = "";
        result.entrySet()
                .stream()
                .filter(x -> x.getValue().size() == 1)
                .forEach(x -> {
                    Label label = new Label("fr","","");
                    x.getValue().add(label);
                });


        //to excel
        result.entrySet()
                .stream()
                .forEach(x -> System.out.println(x.getKey()));

        System.out.println("---------------------------");
        System.out.println("en-us");
        System.out.println("---------------------------");

        //print en-us
        result.entrySet()
                .stream()
                .forEach(x -> {
                    //String id = x.getKey();
                    x.getValue()
                            .stream()
                            .filter(y -> y.getLanguage().equals("en-us"))
                            .forEach(z -> System.out.println(z.getLabel()));
                });

        System.out.println("---------------------------");
        System.out.println("fr");
        System.out.println("---------------------------");

        result.entrySet()
                .stream()
                .forEach(x -> {
                    //String id = x.getKey();
                    x.getValue()
                            .stream()
                            .filter(y -> y.getLanguage().equals("fr"))
                            .forEach(z -> System.out.println(z.getLabel()));
                });

        System.out.println("---------------------------");
        System.out.println("Description");
        System.out.println("---------------------------");

        result.entrySet()
                .stream()
                .forEach(x -> {
                    //String id = x.getKey();
                    x.getValue()
                            .stream()
                            .filter(y -> y.getLanguage().equals("fr"))
                            .forEach(z -> System.out.println(z.getDescription()));
                });

        System.out.println("---------------------------");
        System.out.println("END");
        System.out.println("---------------------------");


    }

    private static void splitRecords(BufferedReader reader, StringBuilder builder, List<String> linesSplitted) throws IOException {
        String line;
        while (!"END".equals(line = reader.readLine())) {
            String[] lineSplit = line.split("<Table:Record name=\"TmpSysLabel\"");


            for(int i = 0; i < lineSplit.length;i++){
                if(lineSplit[i].equals("       xmlns:Table='urn:www.microsoft.com/Formats/Table'>")){
                    builder.append("<Table:Record name=\"TmpSysLabel\"");
                    builder.append("\n");
                }

                if(lineSplit[i].equals("</Table:Record>")){
                    builder.append(lineSplit[i]);
                    builder.append("\n");

                    linesSplitted.add(builder.toString());

                    builder = new StringBuilder();
                    break;
                }else{
                    builder.append(lineSplit[i]);
                    builder.append("\n");
                }

            }
        }
    }
}
