package app;

import app.contracts.ExcelManager;
import app.core.ExcelManagerImpl;

import app.io.ExcelReader;
import org.apache.poi.EncryptedDocumentException;
import org.apache.poi.openxml4j.exceptions.InvalidFormatException;

import java.io.IOException;


public class Main {

    public static void main(String[] args) throws EncryptedDocumentException, IOException, InvalidFormatException {

        //ExcelReader excelReader = new ExcelReader();

        ExcelManager excelManager = new ExcelManagerImpl();

        excelManager.iterExcel();


    }
}
