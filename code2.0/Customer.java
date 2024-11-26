import java.util.Scanner;

public class Customer extends Person implements Viewable{
    Scanner in = new Scanner(System.in);
    private double balance;
    private String address;
    private Category[] interests;
    public enum Gender{
        MALE, FEMALE;
    }
    private final Gender gender;
    private Order order;

    Customer(String username, String password, double balance, String address, Gender gender){
        super(username,password);
        this.balance = balance;
        this.address = address;
        this.gender = gender;
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

    public void PlaceOrder(String PM){
        order = new Order(PM);
        if(PM.equals("balance")){
            if(balance >= order.Payment()){
                System.out.println("Payment done successfully from your balance");
                this.balance-=order.Payment();
            }else{
                System.out.println("Not enough balance");
                //Momken  n5lyh ye5tar lw ye3ml setBalance aw la2
            }
        }else if(PM.equals("cash")){
            double cash = in.nextDouble();
            if(cash >= order.Payment()){
                System.out.println("Payment done successfully");
            }else{
                System.out.println("Insufficient amount please try again!");
            }
        }
        in.nextLine(); //el mafrod dyh btfdy el input in 3a4an lw geh tany y3ml input mtb2a4 in gowaha 7aga
    }

    public void addToCart(){

    };

    public void removeFromCart(){};

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
