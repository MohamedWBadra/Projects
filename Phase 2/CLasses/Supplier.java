package Classes;
import java.util.ArrayList;
public class Supplier  {
    private String name;
    private String password;
    ArrayList<Products> myProducts;
    public Supplier(String n ,String password)
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

    public ArrayList<Products> getMyProducts() {
        return myProducts;
    }
    
//     public void viewByCategory(String cat){
//         boolean found=false;
//        for(int i=0;i<myProducts.size();i++)
//        {
//         if(myProducts.get(i).getMyCategory().getType().equals(cat))
//         {
//             System.out.println("Product number:"+(i+1)+"- Name: "+myProducts.get(i).getName()+" price: "+myProducts.get(i).getPrice()+"  Items left : "+myProducts.get(i).getStock());
//             found=true;
//         }
//        }
//        if(!found)
//         System.out.println("No products from this category is available");
//     }

    public String getPassword() {
        return password;
    }

//     public void viewAllProducts(){
//         for(int i=0;i<myProducts.size();i++)
//         {
//             System.out.println("Product number:"+(i+1)+"- Name: "+myProducts.get(i).getName()+" price: "+myProducts.get(i).getPrice()+"  Items left : "+myProducts.get(i).getStock());
//         }
// }
}