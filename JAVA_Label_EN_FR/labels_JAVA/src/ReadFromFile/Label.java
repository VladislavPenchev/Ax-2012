package ReadFromFile;

public class Label {
    private String id;
    private String language;
    private String value;
    private String description;

    public Label(String id, String language, String value, String description) {
        this.id = id;
        this.language = language;
        this.value = value;
        this.description = description;
    }

    public String getId() {
        return id;
    }

    public String getLanguage() {
        return language;
    }

    public String getValue() {
        return value;
    }

    public String getDescription(){
        return description;
    }

}
