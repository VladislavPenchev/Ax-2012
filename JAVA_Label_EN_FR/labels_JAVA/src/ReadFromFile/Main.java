package ReadFromFile;

import java.io.*;
import java.util.*;
import java.util.stream.Collectors;

public class Main {

    public static final String LANGUAGE_EN_US = "en-us";
    public static final String LANGUAGE_FR = "fr";

    public static void main(String[] args) throws IOException {

        File file = new File("out.txt");
        FileWriter fw = new FileWriter(file);
        PrintWriter pw = new PrintWriter(fw);

        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        Map<String,List<Label>> result = new LinkedHashMap<>();

        List<Label> labels = new ArrayList<>();

        readInput(reader, result, labels);


        StringBuilder sb = new StringBuilder();

        result.entrySet()
                .stream()
                .forEach(x -> {


                    x.getValue()
                            .stream()
                            .forEach(y -> {
                                String id = y.getId();
                                String labelValue = y.getValue();
                                String language = y.getLanguage();
                                String description = y.getDescription();



                                sb.append("<Table:Record name=\"TmpSysLabel\"\n");
                                sb.append("       xmlns:Table='urn:www.microsoft.com/Formats/Table'>\n");
                                sb.append(String.format("    <Table:Field name=\"Language\">%s</Table:Field>\n",language));
                                sb.append(String.format("    <Table:Field name=\"Label\">%s</Table:Field>\n",labelValue));
                                sb.append(String.format("     <Table:Field name=\"Description\">%s</Table:Field>\n",description));
                                sb.append(String.format("    <Table:Field name=\"LabelId\">%s</Table:Field>\n",id));
                                sb.append("    <Table:Field name=\"SysLabelApplModule\">0</Table:Field>\n");
                                sb.append("    <Table:Field name=\"recVersion\">0</Table:Field>\n");
                                sb.append("    <Table:Field name=\"Partition\">5637144576</Table:Field>\n");
                                sb.append("</Table:Record>\n\n");

                            });

                            sb.append("*********************");

                });

        //System.out.println(sb);

        pw.println(sb);

        pw.close();

    }

    private static void readInput(BufferedReader reader, Map<String, List<Label>> result, List<Label> labels) throws IOException {
        String line;
        while (!"END".equals(line = reader.readLine())) {
            List<String> temp = Arrays.stream(line.split("\\s\\$+\\s"))
                    .collect(Collectors.toList());

            if(temp.size() == 2){
                temp.add("");
                temp.add("");
            }else if(temp.size() == 3){
                temp.add("");
            }

            String id = temp.get(0);
            String usLanguage = temp.get(1);
            String frLanguage = temp.get(2);
            String description = temp.get(3);

            Label labelUs = new Label(id,LANGUAGE_EN_US,usLanguage,description);
            Label labelFr = new Label(id,LANGUAGE_FR,frLanguage,description);


            labels.add(labelUs);
            labels.add(labelFr);

            result.put(id,labels);
        }
    }


}
