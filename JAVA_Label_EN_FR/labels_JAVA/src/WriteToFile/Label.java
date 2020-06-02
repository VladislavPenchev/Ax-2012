package WriteToFile;

public class Label {
    private String language;
    private String label;
    private String description;

    public Label (String language,String label,String description){
        this.language = language;
        this.label = label;
        this.description = description;
    }

    public String getLanguage(){
        return this.language;
    }

    public String getLabel(){
        return this.label;
    }

    public String getDescription(){
        return this.description;
    }

}
