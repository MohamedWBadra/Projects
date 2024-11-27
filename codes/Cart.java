import java.util.ArrayList;
public class Cart{
   ArrayList<Products> myCart ;
   float totalprice;
   Cart(){
    myCart = new ArrayList<Products>();
    totalprice=0;
   }
   public float getTotalprice() {
       return totalprice;
   }
   public void addproduct(Products p)
   {
    totalprice+=p.getPrice();
    myCart.add(p);
    
   }
   public void removeproducts(Products p){
    if (myCart.contains(p)) {
        myCart.remove(p);
    }
    else{
        System.err.println("PRODUCT IS NOT FOUND");

    }

   }
}