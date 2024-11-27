public class Products{
    private String name;
    private float price;
    private Category myCategory;
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
    Products(String n,float p){
        this.name=n;
        this.price=p;
        this.myCategory=new Category();
    }
    public Category getMyCategory() {
        return myCategory;
    }
    Products(String n,float p,String category){
        this.name=n;
        this.price=p;
        this.myCategory=new Category(category);
    }




    
}
