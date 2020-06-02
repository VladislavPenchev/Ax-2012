import org.apache.poi.hssf.usermodel.HSSFRow;
import org.apache.poi.hssf.usermodel.HSSFSheet;
import org.apache.poi.hssf.usermodel.HSSFWorkbook;
import org.apache.poi.ss.usermodel.*;
import org.apache.poi.xssf.usermodel.XSSFWorkbook;

import java.io.*;
import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;

public class Main {

    public static final String EXCEL_FILE_NAME = "LCR 22.04.2019 Valerie_.xlsx";
    public static final String TEXT_FILE_NAME = "Geri_Doc.txt";
    public static final String PATH_TO_READ = String.format("C://Users//vladislav.penchev//Desktop//Ax-2012//Geri_Document_Java//src//main//java//app//excel_documents//%s",EXCEL_FILE_NAME);
    public static final String PATH_TO_WRITE = String.format("C://Users//vladislav.penchev//Desktop//Ax-2012//Geri_Document_Java//src//main//java//app//textDocuments//%s", TEXT_FILE_NAME);


    public static void main(String[] args) throws IOException {

        givenWritingStringToFile_whenUsingFileOutputStream_thenCorrect();


    }

    public static void givenWritingStringToFile_whenUsingFileOutputStream_thenCorrect()
            throws IOException {
        String str = "Hello";
        FileOutputStream outputStream = new FileOutputStream(PATH_TO_WRITE);
        byte[] strToBytes = str.getBytes();
        outputStream.write(strToBytes);

        outputStream.close();
    }
}
