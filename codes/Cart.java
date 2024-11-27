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
   public void removeproducts(int i){
    if (myCart.size()>i) {
        totalprice-=myCart.get(i).getPrice();
        myCart.remove(i);
    }
    else{
        System.err.println("PRODUCT IS NOT FOUND");

    }

   }
}