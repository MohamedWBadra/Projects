import java.util.ArrayList;
public class Supplier implements Viewable {
    String name;
    String password;
    ArrayList<Products> myProducts;
    Supplier(String n ,String password)
    {
        this.name=n;
        this.password=password;
        myProducts=new ArrayList<Products>();
    }
    public void addproduct(Products p)
    {
            if(!myProducts.contains(p))
            {
               myProducts.add(p); 

            }
        
    }
    public String getName(){
        return this.name;
    }
    public void viewByCategory(String cat){
       for(int i=0;i<myProducts.size();i++)
       {
        if(myProducts.get(i).getMyCategory().getType()==cat)
        {
            System.out.println("Product number:"+(i+1)+"- Name: "+myProducts.get(i).getName()+" price: "+myProducts.get(i).getPrice()+"  Items left : "+myProducts.get(i).getStock());

        }
       }
    }
    public void viewAllProducts(){
        for(int i=0;i<myProducts.size();i++)
        {
            System.out.println("Product number:"+(i+1)+"- Name: "+myProducts.get(i).getName()+" price: "+myProducts.get(i).getPrice()+"  Items left : "+myProducts.get(i).getStock());
        }
}
}