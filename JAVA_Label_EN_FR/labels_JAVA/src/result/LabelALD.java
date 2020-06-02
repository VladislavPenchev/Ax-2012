package result;

public class LabelALD {
    private String id;
    private String label;
    private String description;

    public LabelALD (String id,String label,String description){
        this.id = id;
        this.label = label;
        this.description = description;
    }

    public String getLanguage(){
        return this.id;
    }

    public String getLabel(){
        return this.label;
    }

    public String getDescription(){
        return this.description;
    }
}
