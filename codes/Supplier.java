import java.util.ArrayList;
public class Supplier implements Viewable {
    String name;
    ArrayList<Products> myProducts;
    Supplier(String n)
    {
        this.name=n;
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
        if(myProducts.get(i).getType()==cat)
        {
            System.out.println(myProducts.get(i)+" ");
        }
       }
    }
    public void viewAllProducts(){
        for(int i=0;i<myProducts.size();i++)
        {
            System.out.println("Name: "+myProducts.get(i).getName()+" price: "+myProducts.get(i).getPrice());
        }
}
}