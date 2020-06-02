package app.entities;

import org.apache.commons.codec.binary.StringUtils;

public class DataRepositoryImpl {

    public static final int  CHARACTER_SIZE_0 = 0;
    public static final int  CHARACTER_SIZE_1 = 1;
    public static final int  CHARACTER_SIZE_2 = 2;
    public static final int  CHARACTER_SIZE_4 = 4;
    public static final int  CHARACTER_SIZE_6 = 6;
    public static final int  CHARACTER_SIZE_10 = 10;
    public static final int  CHARACTER_SIZE_12 = 12;
    public static final int  CHARACTER_SIZE_21 = 21;
    public static final int  CHARACTER_SIZE_24 = 24;
    public static final int  CHARACTER_SIZE_26 = 26;

    private String field1;
    private String field2;
    private String field3;
    private String field4;
    private String field5;
    private String field6;
    private String field7;
    private String field8;
    private String field9;
    private String field10;
    private String field11;
    private String field12;
    private String field13;
    private String field14;
    private String field15;
    private String field16;

    public DataRepositoryImpl(String field1, String field2, String field3, String field4, String field5,
                              String field6, String field7, String field8, String field9, String field10,
                              String field11, String field12, String field13, String field14, String field15, String field16) {
        this.setField1(field1);
        this.setField2(field2);
        this.setField3(field3);
        this.setField4(field4);
        this.setField5(field5);
        this.setField6(field6);
        this.setField7(field7);
        this.setField8(field8);
        this.setField9(field9);
        this.setField10(field10);
        this.setField11(field11);
        this.setField12(field12);
        this.setField13(field13);
        this.setField14(field14);
        this.setField15(field15);
        this.setField16(field16);

    }

    public String getField1() {
        return this.field1;
    }

    public void setField1(String field1) {

        String result = validationField(field1,this.CHARACTER_SIZE_2);

        this.field1 = result;

    }

    public String getField2() {
        return this.field2;
    }

    public void setField2(String field2) {

        String result = validationField(field2,this.CHARACTER_SIZE_10);

        this.field2 = result;

    }

    public String getField3() {
        return this.field3;
    }

    public void setField3(String field3) {

        String result = validationField(field3,this.CHARACTER_SIZE_6);

        this.field3 = result;

    }

    public String getField4() {
        return this.field4;
    }

    public void setField4(String field4) {

        String result = validationField(field4,this.CHARACTER_SIZE_2);

        this.field4 = result;

    }

    public String getField5() {
        return this.field5;
    }

    public void setField5(String field5) {

        String result = validationField(field5,this.CHARACTER_SIZE_10);

        this.field5 = result;

    }

    public String getField6() {
        return this.field6;
    }

    public void setField6(String field6) {

        String result = validationField(field6,this.CHARACTER_SIZE_24);

        this.field6 = result;

    }

    public String getField7() {
        return this.field7;
    }

    public void setField7(String field7) {

        String result = validationField(field7,this.CHARACTER_SIZE_24);

        this.field7 = result;

    }

    public String getField8() {
        return this.field8;
    }

    public void setField8(String field8) {

        String result = validationField(field8,this.CHARACTER_SIZE_1);

        this.field8 = result;
    }

    public String getField9() {
        return this.field9;
    }

    public void setField9(String field9) {

        String result = validationField(field9,this.CHARACTER_SIZE_2);

        this.field9 = result;

    }

    public String getField10() {
        return this.field10;
    }

    public void setField10(String field10) {

        String result = validationField(field10,this.CHARACTER_SIZE_21);

        this.field10 = result;

    }

    public String getField11() {
        return this.field11;
    }

    public void setField11(String field11) {

        String result = validationField(field11,this.CHARACTER_SIZE_12);

        this.field11 = result;
    }

    public String getField12() {
        return this.field12;
    }

    public void setField12(String field12) {

        String result = validationField(field12,this.CHARACTER_SIZE_4);

        this.field12 = result;
    }

    public String getField13() {
        return this.field13;
    }

    public void setField13(String field13) {

        String result = validationField(field13,this.CHARACTER_SIZE_6);

        this.field13 = result;
    }

    public String getField14() {
        return this.field14;
    }

    public void setField14(String field14) {

        String result = validationField(field14,this.CHARACTER_SIZE_6);

        this.field14 = result;

    }

    public String getField15() {
        return this.field15;
    }

    public void setField15(String field15) {

        String result = validationField(field15,this.CHARACTER_SIZE_4);

        this.field15 = result;

    }

    public String getField16() {
        return this.field16;
    }

    public void setField16(String field16) {

        String result = validationField(field16,this.CHARACTER_SIZE_26);

        this.field16 = result;
    }

    //Depricated
//    public int checkAllCharactersLength(String curSb){
//
//        int allCharacters = 160;
//
//        int currentCharactersLength = this.getField1().length()
//                + this.getField2().length()
//                + this.getField3().length()
//                + this.getField4().length()
//                + this.getField5().length()
//                + this.getField6().length()
//                + this.getField7().length()
//                + this.getField8().length()
//                + this.getField9().length()
//                + this.getField10().length()
//                + this.getField11().length()
//                + this.getField12().length()
//                + this.getField13().length()
//                + this.getField14().length()
//                + this.getField15().length()
//                + this.getField16().length();
//
//
////        int neededCharacters = 160 - currentCharactersLength;
////
////        StringBuilder sb = new StringBuilder(curSb);
////
////        for(int i = 0; i<neededCharacters; i++){
////            sb.append(" ");
////        }
////        String result =  sb.toString();
////
////        return result;
//        return currentCharactersLength;
//    }


    public String validationField (String field, int const_CHARACTER_SIZE){

        if(field.length() < this.CHARACTER_SIZE_0){

            throw new IllegalArgumentException(String.format("Field1 has more than %s",const_CHARACTER_SIZE));


        } else if(field.length() > const_CHARACTER_SIZE){

            String result = field.substring(0,const_CHARACTER_SIZE);

            return result;

        } else if(field.length() < const_CHARACTER_SIZE){

            int neededCharacters = const_CHARACTER_SIZE - field.length();

            StringBuilder sb = new StringBuilder(field);

            for(int i = 0; i < neededCharacters; i++){

                sb.append(" ");

            }

            String result =  sb.toString();

            return result;

        }else{
            return field;
        }
    }
}
