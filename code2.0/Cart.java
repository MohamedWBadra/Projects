import java.util.ArrayList;
public class Cart{
    ArrayList<Product> myCart;

    float TotalPrice;

    Cart(){
        myCart = new ArrayList<Product>();
        TotalPrice = 0;
    }

    public float getTotalPrice() {
        return TotalPrice;
    }

    public void CalcTotalPrice(){
        for(int i = 0; i < myCart.size(); i++){
            TotalPrice += myCart.get(i).getPrice();
        }
    }

    public void addproduct(Product p){
        myCart.add(p);
        this.TotalPrice += p.getPrice();
    }

    public void removeproducts(Product p){
        if(myCart.isEmpty()){
            System.err.println("Cart is empty...there is nothing to remove");
        }
        else if(myCart.contains(p)){
            myCart.remove(p);
            this.TotalPrice -= p.getPrice();
        }else{
            System.err.println("Product does not exist");
        }
    }
}