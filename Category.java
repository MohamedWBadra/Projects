abstract public class Category {
    private String[] Categories = {"electronics","bakery", "clothes", "laptops"};
    private String type;

    Category(String type){
        type = type.toLowerCase();
        for(int i = 0; i < Categories.length; i++){
            if(type.equals(Categories[i])){
                this.type = type;
            }
        }
    }

}
