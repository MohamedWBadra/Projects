package Classes;
public class Products{
    private String name;
    private float price;
    private Category myCategory;
    private int stock;
    public void setName(String name) {
        this.name = name;
    }
    public void setPrice(float price) {
        this.price = price;
    }
    public String getName() {
        return name;
    }
    public float getPrice() {
        return price;
    }
    Products(String n,float p,int stock){
        this.name=n;
        this.price=p;
        this.stock=stock;
        this.myCategory=new Category();

    }
    public Category getMyCategory() {
        return myCategory;
    }
    public String getCategoryType() {
        return myCategory.getType();
    }
    public Products(String n,float p,String category,int stock){
        this.name=n;
        this.price=p;
        this.stock=stock;
        this.myCategory=new Category(category);
    }
    public void setStock(int stock) {
        this.stock = stock;
    }
    public int getStock() {
        return stock;
    }




    
}