package TestJava;

import java.io.IOException;

public class Main {
    public static void main(String[] args) throws IOException {


        String s = "@GEE3260 TVA\r\n@GEE9459 Qté\r\n@GEE16736 Taux de TVA\r\n";

        System.out.println(s);
        System.out.println(s.length());
        System.out.println(s.indexOf("\r\n",27));
        //27 + 9 = 36

    }
}
