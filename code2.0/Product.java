public class Product extends Category {
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

    Product(String n,float p){
        super();
        this.name=n;
        this.price=p;
    }

    Product(String n,float p,String category){
        super(category);
        this.name=n;
        this.price=p;
    }

}