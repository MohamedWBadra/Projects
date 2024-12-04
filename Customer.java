import java.util.Scanner;
import java.util.ArrayList;
public class Customer extends Person implements Viewable{
    Scanner in = new Scanner(System.in);
    private double balance;
    private String address;
    boolean Banned = false;
    CreditCard credit_card;
    private ArrayList<Category> interests;
    public enum Gender{
        MALE, FEMALE;
    }
    private final Gender gender;
    private Order order = new Order();

    Customer(String username, String password, double balance, String address,String temp,int year,int months,int days){
        super(username,password,year,months,days);
        this.balance = balance;
        this.address = address;
        for(;;){
            temp=in.nextLine();
            temp.toUpperCase();
            if (temp.equals("M")) {
                gender=Gender.MALE;
                break;
            }else if (temp.equals("F")) {
                gender=Gender.FEMALE;
                break;
            }else{
                System.err.println("Invalid input..... Please try again");
                System.out.println("enter your gender : M or F");

            }
        }
        this.interests=new ArrayList<Category>();

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

    public void setBalance(double balance) {
        this.balance = balance;
    }

    public Gender getGender() {
        return gender;
    }

    public void PlaceOrder(){
        float price= order.orderCart.getTotalprice();
       if(this.order.getPaymentMethod().equals("balance"))
       {
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
        order.orderCart.addproduct(Database.suppliers.get(i-1).myProducts.get(j-1));
        interests.add(Database.suppliers.get(i-1).myProducts.get(j-1).getMyCategory());
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

    public void viewAllProducts(){
        for(int i = 0; i < Database.suppliers.size(); i++){
            System.out.println("supplier: "+(i+1) + ":");
            Database.suppliers.get(i).viewAllProducts();
        }
    };

    public void viewByCategory(String c){
        if(Database.Categories.contains(c))
        {
            for(int i = 0; i < Database.suppliers.size(); i++){
                System.out.println("supplier: "+(i+1) + ":");
                Database.suppliers.get(i).viewByCategory(c);
            }
        }
        else{
            System.err.println("This category is not valid");
        }

    };

    public void viewByName(String n)
    {
        boolean found=false;
        for(int i = 0; i < Database.suppliers.size(); i++){
            for(int j=0;j<Database.suppliers.get(i).myProducts.size();j++)
            {
                if(Database.suppliers.get(i).myProducts.get(j).getName().toLowerCase().equals(n.toLowerCase()))
                {
                    System.out.println("supplier: "+(i+1)+"Product number:"+(j+1)+"- "+"Name: "+Database.suppliers.get(i).myProducts.get(i).getName()+" price: "+Database.suppliers.get(i).myProducts.get(i).getPrice()+"  Items left : "+Database.suppliers.get(i).myProducts.get(i).getStock());

                    found=true;
                }
            }
        }
        if(!found)
        {
            System.err.println("This name is not valid");

        }
    }
    public void setBanned(boolean banned) {
        Banned = banned;
    }
}