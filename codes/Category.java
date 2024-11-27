abstract public class Category {
    private String[] Categories = {"electronics","bakery", "clothes", "laptops","others"};
    private String type;
    Category(){
        type="others";

    }
    public String getType() {
        return type;
    }

    Category(String t){
        t = t.toLowerCase();
        for(int i = 0; i < Categories.length; i++){
            if(type.equals(Categories[i])){
                this.type = t;
            }
        }
    }

}
