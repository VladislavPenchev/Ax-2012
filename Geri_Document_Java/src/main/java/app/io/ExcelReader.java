package app.io;

import org.apache.poi.openxml4j.exceptions.InvalidFormatException;
import org.apache.poi.ss.usermodel.*;

import java.io.File;
import java.io.FileInputStream;
import java.io.IOException;

public class ExcelReader {

    public static final String EXCEL_FILE_NAME = "29.03.2019 banque.xlsx";
    public static final String PATH_TO_READ = String.format("C://Users//vladislav.penchev//Desktop//Geri_Document_Java//src//main//java//app//excel_documents//%s",EXCEL_FILE_NAME);

    //private Workbook workbook;
    private FileInputStream excelFile;

    public ExcelReader() throws IOException, InvalidFormatException {
        //this.workbook = WorkbookFactory.create(new File(PATH_TO_READ));
        excelFile = new FileInputStream(new File(PATH_TO_READ));

    }

    public FileInputStream getExcelFile() {
        return this.excelFile;
    }
}
