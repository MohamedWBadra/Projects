public class Customer extends Person implements Viewable{
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

    public void addToCart(){};

    public void removeFromCart(){};

    public void viewAllProducts(){

    };

    public void viewByCategory(String c){};


}
