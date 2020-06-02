package CreateReplaceALD;

import java.io.FileReader;
import java.io.IOException;

public class ReadAndModify {
    public static void main(String[] args) throws IOException {

        FileReader fr=new FileReader("C:\\Users\\vladislav.penchev\\Desktop\\labels\\src\\TestJava\\ReadFiles\\axGEEfr.ald");

        StringBuilder sb = new StringBuilder();
        int i;

        while((i=fr.read())!=-1){

            sb.append((char)i);
        }




        //System.out.println(sb);



        fr.close();
    }
}
