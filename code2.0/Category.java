abstract public class Category {
    private String[] Categories = {"electronics","bakery", "clothes", "laptops"};
    private String type;

    Category(){
        this.type = "Others";
    }

    Category(String type){
        type = type.toLowerCase();
        for(int i = 0; i < Categories.length; i++){
            if(type.equals(Categories[i])){
                this.type = type;
                break;
            }
        }
    }

    public String getType() {
        return type;
    }

    public void setType(String type) {
        this.type = type;
    }
}
