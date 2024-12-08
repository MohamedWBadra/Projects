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
    if (p.getStock()!=0){
    totalprice+=p.getPrice();
    myCart.add(p);
    p.setStock(p.getStock()-1);
    }else{
        System.err.println("Item out of stock");
    }
    
   }
   public void viewcart(){
    for(int i=0;i<myCart.size();i++)
    {
        System.out.println("product number: "+(i+1)+"- name: "+myCart.get(i).getName()+"price: "+myCart.get(i).getPrice());
    }
    if(myCart.size()==0)
    {
        System.err.println("Cart is empty");
    }
   }
   public void removeproducts(int i){
    if (myCart.size()>i) {
        totalprice-=myCart.get(i).getPrice();
        myCart.get(i).setStock(myCart.get(i).getStock()+1);
        myCart.remove(i);
    }
    else{
        System.err.println("PRODUCT IS NOT FOUND");

    }

   }
}