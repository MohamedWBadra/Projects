package Classes;
import java.util.Scanner;
import java.util.ArrayList;
public class Customer extends Person {
    Scanner in = new Scanner(System.in);
    private double balance;
    private String address;
    private boolean Banned = false;
    private CreditCard credit_card;
    private ArrayList<Category> interests;
    public enum Gender{
        MALE, FEMALE;
    }
    private final Gender gender;
    private Order order = new Order();

    public Customer(String username, String password, String address,String temp,int year,int months,int days)
    {
        super(username,password,year,months,days);
        this.address = address;
        this.balance=0.0;
        if (temp.equals("Male")) {
                gender=Gender.MALE;
                
            }
        else {
                gender=Gender.FEMALE;
                
            }
        
        this.interests=new ArrayList<Category>();

    }
    public CreditCard getCredit_card() {
        return credit_card;
    }
    public boolean getBanned(){
        return Banned;
    }

    public void setCredit_card(long card_number, int cvv) {
        this.credit_card = new CreditCard(card_number,cvv);
        order.setPaymentMethod("card");
    }
    public ArrayList<Category> getInterests() {
        return interests;
    }

    public Order getOrder() {
        return order;
    }

    public String getAddress() {
        return address;
    }

    public void setAddress(String address) {
        this.address = address;
    }

    public double getBalance() {
        return balance;
    }

    public void setBalance(String myCode) {
        this.balance+=Double.valueOf(myCode.substring(3, 8));
    }

    public Gender getGender() {
        return gender;
    }
    public void setBalanceValue(Double x)
    {
        this.balance =x;
    }

    public void PlaceOrder(){
        float price= order.orderCart.getTotalprice();
       if(this.order.getPaymentMethod().equals("balance"))
       {
        if(balance<order.orderCart.totalprice)
        {
             System.out.println("your balance is not enough");
             return;
        }
                System.out.println("Payment done successfully from your balance");
                this.balance-=price;


        }
       else if(this.order.getPaymentMethod().equals("cash")) {

           System.out.println("Your order has been placed and the total order price is: " + price);
       }
       else {
           System.out.println("Payment done successfully by your card and the total price is: "+price+"for more details please contact your bank");
        }
        Database.Orders.add(order);
        order=new Order();
    }
    public void resetorder(){
        order=new Order();
    }

    public void addToCart(int i,int j){
        // if(i>=Database.suppliers.size()||i<0)
        // {
        //     System.err.println("the supplier number is wrong");
        // }
        // else if(i>=Database.suppliers.get(i-1).myProducts.size()||i<0)
        // {
        //     System.err.println("the product number is wrong");
        // }
        // if(Database.suppliers.size()<=i || i<0)
        //  {
        //     System.err.println("supplier number does not exist");
        //     return;
        //  }                                                 //myproucts
        order.orderCart.addproduct(Database.suppliers.get(i-1).getMyProducts().get(j-1));
        // if(Database.suppliers.get(i-1).myProducts.size()<=j || j<0)
        //  {
        //     System.err.println("product number does not exist");
        //     return;
        //  }
                                                 //myproucts
        interests.add(Database.suppliers.get(i-1).getMyProducts().get(j-1).getMyCategory());
    };
    public void viewmycart(){
        if( order.orderCart.myCart.isEmpty())
        {
            System.out.println("cart is empty");
        }
       else order.orderCart.viewcart();
    }
    public void removeFromCart(int i){

        order.orderCart.removeproducts(i-1);
    }

    // public void viewAllProducts(){
    //     for(int i = 0; i < Database.suppliers.size(); i++){
    //         System.out.println("supplier: "+(i+1) + ":");
    //         Database.suppliers.get(i).viewAllProducts();
    //     }
    // };

    // public void viewByCategory(String c){
    //     if(Database.Categories.contains(c))
    //     {
    //         for(int i = 0; i < Database.suppliers.size(); i++){
    //             System.out.println("supplier: "+(i+1) + ":");
    //             Database.suppliers.get(i).viewByCategory(c);
    //         }
    //     }
    //     else{
    //         System.err.println("This category is not valid");
    //     }

    // };

    // public void viewByName(String n)
    // {
    //     boolean found=false;
    //     for(int i = 0; i < Database.suppliers.size(); i++){
    //         for(int j=0;j<Database.suppliers.get(i).myProducts.size();j++)
    //         {
    //             if(Database.suppliers.get(i).myProducts.get(j).getName().toLowerCase().equals(n.toLowerCase()))
    //             {
    //                 System.out.println("supplier: "+(i+1)+"Product number:"+(j+1)+"- "+"Name: "+Database.suppliers.get(i).myProducts.get(i).getName()+" price: "+Database.suppliers.get(i).myProducts.get(i).getPrice()+"  Items left : "+Database.suppliers.get(i).myProducts.get(i).getStock());

    //                 found=true;
    //             }
    //         }
    //     }
    //     if(!found)
    //     {
    //         System.err.println("This name is not valid");

    //     }
    // }
    public void setBanned(boolean banned) {
        Banned = banned;
    }
}