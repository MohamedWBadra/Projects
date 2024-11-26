public class Products extends Category {
    String name;
    float price;
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
        super();
    }
    Products(String n,float p,String category){
        this.name=n;
        this.price=p;
        super(category);
    }




    
}
