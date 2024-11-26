import java.util.ArrayList;
public class Supplier implements Viewable {
    private String name;

    ArrayList<Product> myProducts;

    Supplier(String n){
        this.name = n;
        myProducts = new ArrayList<Product>();
    }

    public String getName(){
        return this.name;
    }

    public void addProduct(String n,float p,String category){
        myProducts.add(new Product(n,p,category));
    }

    public void viewByCategory(String c){
        for(int i = 0; i < myProducts.size();i++){
            if(myProducts.get(i).getType().equals(c)){
                System.out.println(myProducts.get(i).getName());
            }
        }
    }

    public void viewAllProducts(){
        for(int i = 0; i < myProducts.size();i++){
            System.out.println(myProducts.get(i).getName());
        }
    }


}