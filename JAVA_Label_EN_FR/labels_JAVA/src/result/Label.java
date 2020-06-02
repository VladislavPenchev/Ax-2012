package result;

public class Label {
    private String id;
    private String language;
    private String label;
    private String description;

    public Label (String id, String language,String label,String description){
        this.id = id;
        this.language = language;
        this.label = label;
        this.description = description;
    }

    public String getId(){
        return this.id;
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
