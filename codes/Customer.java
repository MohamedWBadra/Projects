import java.util.Scanner;
import java.util.ArrayList;
public class Customer extends Person implements Viewable{
    Scanner in = new Scanner(System.in);
    private double balance;
    private String address;
    //boolean Banned
    //setter/getter
    private ArrayList<Category> interests;
    public enum Gender{
        MALE, FEMALE;
    }
    private final Gender gender;
    private Order order = new Order();
    Customer(String username, String password, double balance, String address, Gender gender,int year,int months,int days){//Banned=false
        super(username,password,year,months,days);
        this.balance = balance;
        this.address = address;
        this.gender = gender;
        this.interests=new ArrayList<Category>();
        
    }
    public ArrayList<Category> getInterests() {
        return interests;
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
        if(this.order.getPaymentMethod() == null){//mmkn nekhaleh boolean lw true yekamel e order w lw false yeb3ato 3ala getpaymentmethod tany
            System.err.println("Please set your payment method!");  //Momken hena y5lyh b2a input el payment method ely 3ayzha wa nb3tha le order.setPaymentMethod b3d keda y3ml call le place order tany msln
        }else if(this.order.getPaymentMethod().equals("balance")){
            if(balance >= order.Payment()){
                System.out.println("Payment done successfully from your balance");
                this.balance-=order.Payment();
            }else{
                System.out.println("Not enough balance");
                //Momken  n5lyh ye5tar lw ye3ml setBalance aw la2
            }
        }else if(this.order.getPaymentMethod().equals("cash")){
            double cash = in.nextDouble();
            if(cash >= order.Payment()){
                System.out.println("Payment done successfully");
            }else{
                System.out.println("Insufficient amount please try again!");
            }

        }
        in.nextLine();//el mafrod dyh btfdy el input in 3a4an lw geh tany y3ml input mtb2a4 in gowaha 7aga
        if(this.order.getPaymentMethod() != null) {
            Database.Orders.add(this.order);
        }
    }

    public void addToCart(int i,int j){
        order.orderCart.addproduct(Database.suppliers.get(i-1).myProducts.get(j-1));
        interests.add(Database.suppliers.get(i-1).myProducts.get(j-1).getMyCategory());
    };

    public void removeFromCart(int i){
        order.orderCart.removeproducts(i);
    };

    public void viewAllProducts(){
        for(int i = 0; i < Database.suppliers.size(); i++){
            System.out.println(Database.suppliers.get(i).getName() + ":");
            Database.suppliers.get(i).viewAllProducts();
        }
    };

    public void viewByCategory(String c){
        for(int i = 0; i < Database.suppliers.size(); i++){
            System.out.println(Database.suppliers.get(i).getName() + ":");
            Database.suppliers.get(i).viewByCategory(c);
        }
    };


}