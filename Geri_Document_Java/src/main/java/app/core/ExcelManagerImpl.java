package app.core;

import app.contracts.ExcelManager;
import app.entities.DataRepositoryImpl;
import org.apache.poi.openxml4j.exceptions.InvalidFormatException;
import org.apache.poi.ss.usermodel.*;
import org.apache.poi.xssf.usermodel.XSSFWorkbook;

import java.io.*;
import java.util.*;

public class ExcelManagerImpl implements ExcelManager {

    public static final String TEXT_FILE_NAME = "Geri_Doc.txt";
    public static final String EXCEL_FILE_NAME = "LCR 27.05.xlsx";
    public static final String PATH_TO_READ = String.format("C://Users//vladislav.penchev//Desktop//Ax-2012//Geri_Document_Java//src//main//java//app//excel_documents//%s",EXCEL_FILE_NAME);
    public static final String PATH_TO_WRITE = String.format("C://Users//vladislav.penchev//Desktop//Ax-2012//Geri_Document_Java//src//main//java//app//textDocuments//%s", TEXT_FILE_NAME);


    public static final int NUMBER_OF_SECOND_NUMERIC_FIELD = 10;

    private Map<Integer, DataRepositoryImpl> data;
    private List<String> cells;


    public ExcelManagerImpl() throws IOException, InvalidFormatException {

        this.data = new LinkedHashMap<>();
        cells = new ArrayList<>();
    }

    @Override
    public void iterExcel(){

                try {

                    FileInputStream excelFile = new FileInputStream(new File(PATH_TO_READ));
                    Workbook workbook = new XSSFWorkbook(excelFile);
                    Sheet datatypeSheet = workbook.getSheetAt(0);
                    Iterator<Row> iterator = datatypeSheet.iterator();

                    int rowIndex = 1;

                    while (iterator.hasNext()) {

                        Row currentRow = iterator.next();
                        Iterator<Cell> cellIterator = currentRow.iterator();

                        while (cellIterator.hasNext()) {

                            Cell currentCell = cellIterator.next();


                            if (currentCell.getCellTypeEnum() == CellType.STRING) {
                                cells.add(currentCell.getStringCellValue());

                            } else if (currentCell.getCellTypeEnum() == CellType.NUMERIC) {

                                double cur = currentCell.getNumericCellValue();

                                String curStr = String.valueOf(cur);

                                String[] splitDot = curStr.split("\\.");

                                StringBuilder sb = new StringBuilder();

                                //6.000000002E9 desired -> 6000000002

                                String result = null;

                                if(splitDot[1].contains("E")){
                                    int indexOfE = splitDot[1].indexOf("E");
                                    String temp = splitDot[1].substring(0,indexOfE);

                                    result = sb.append(splitDot[0])
                                            .append(temp).toString();

                                    StringBuilder sbNulls = new StringBuilder(result);

                                    if(result.length() != this.NUMBER_OF_SECOND_NUMERIC_FIELD);{

                                        int neededNulls = this.NUMBER_OF_SECOND_NUMERIC_FIELD - result.length();

                                        for(int i = 0; i < neededNulls; i++){
                                            sbNulls.append("0");

                                        }

                                        result = sbNulls.toString();
                                    }

                                }else {
                                    result = sb.append(splitDot[0])
                                            .append(splitDot[1]).toString();
                                }

                                cells.add(result);

                            }else{
                                cells.add(" ");
                            }

                        }

                        DataRepositoryImpl dataRepository= null;

                        if(cells.size() >= 16){
                            dataRepository = new DataRepositoryImpl(cells.get(0), cells.get(1), cells.get(2), cells.get(3), cells.get(4),
                                    cells.get(5), cells.get(6), cells.get(7), cells.get(8), cells.get(9), cells.get(10),
                                    cells.get(11), cells.get(12), cells.get(13), cells.get(14), cells.get(15));
                        }else{
                            continue;
                        }

                        data.putIfAbsent(rowIndex,dataRepository);

                        cells = new ArrayList<>();
                        rowIndex++;

                    }


                    givenWritingStringToFile_whenUsingFileOutputStream_thenCorrect(data);


                } catch (FileNotFoundException e) {
                    e.printStackTrace();
                } catch (IOException e) {
                    e.printStackTrace();
                }


    }

    public void givenWritingStringToFile_whenUsingFileOutputStream_thenCorrect(Map<Integer,DataRepositoryImpl> data)
            throws IOException {

        String result = toString();

        FileOutputStream outputStream = new FileOutputStream(PATH_TO_WRITE);
        byte[] strToBytes = result.toString().getBytes();
        outputStream.write(strToBytes);

        outputStream.close();
    }

    @Override
    public String toString() {

        StringBuilder sb = new StringBuilder();

        data.values()
                .stream()
                .forEach(x -> {
                     sb.append(x.getField1())
                            .append(x.getField2())
                            .append(x.getField3())
                            .append(x.getField4())
                            .append(x.getField5())
                            .append(x.getField6())
                            .append(x.getField7())
                            .append(x.getField8())
                            .append(x.getField9())
                            .append(x.getField10())
                            .append(x.getField11())
                            .append(x.getField12())
                            .append(x.getField13())
                            .append(x.getField14())
                            .append(x.getField15())
                            .append(x.getField16())
                            .append(System.lineSeparator());

                     //String curSb = sb.toString();

                            //sb.append(x.checkAllCharactersLength(curSb))
                            //.append(System.lineSeparator());

                });

        return sb.toString();
    }
}
