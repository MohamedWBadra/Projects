package Classes;
public class Category {
    private String type;
    Category(){
        type="others";
    }
    public String getType() {
        return type;
    }
    Category(String t){
        t = t.toLowerCase();
        if(!Database.Categories.contains(t))
        {
            Database.Categories.add(t);

        }
        this.type = t;
    }
}