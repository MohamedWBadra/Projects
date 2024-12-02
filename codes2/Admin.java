import java.util.Scanner;

public class Admin extends Person implements Viewable{
    private final String[] roles = {"ceo", "hr", "coo"};
    private double working_hours;
    private String role;
    Scanner input=new Scanner(System.in);
    Admin(String username, String password, String role, double working_hours,int year,int months,int days){
        super(username,password,year,months,days);
        role = role.toLowerCase();
        for(int i = 0 ; i < roles.length; i++){
            if(role.equals(roles[i])){
                this.role = role;
                break;
            }
        }
    }

    public double getWorking_hours() {
        return working_hours;
    }

    public void setWorking_hours(double working_hours) {
        this.working_hours = working_hours;
    }

    public String getRole() {
        return role;
    }

    public void setRole(String role) {
        role = role.toLowerCase();
        for(int i = 0 ; i < roles.length; i++) {
            if (role.equals(roles[i])) {
                this.role = role;
            }
        }
    }

    public void viewAllProducts(){
        for(int i = 0; i < Database.suppliers.size(); i++){
            System.out.println(Database.suppliers.get(i).getName() + ":");
            Database.suppliers.get(i).viewAllProducts();
        }
    };

    @Override
    public void viewByCategory(String c) {
        for(int i = 0; i < Database.suppliers.size(); i++){
            System.out.println(Database.suppliers.get(i).getName() + ":");
            Database.suppliers.get(i).viewByCategory(c);
        }
    }

    public void addSupplier(Supplier e){
        if(Database.suppliers.contains(e))
        {
            System.err.println("this supplier already exists");
        }
        else{
         Database.suppliers.add(e);}
    };

    public void viewSuppliers(){
        for(int i = 0 ;i < Database.suppliers.size(); i++){
            System.out.println(Database.suppliers.get(i).getName());
        }
    };

    public void viewOrders(){
        for(int i = 0 ; i < Database.Orders.size(); i++){
            System.out.println(Database.Orders.get(i).getPaymentMethod());
        }
    };

    public void viewCustomers(){
        for(int i = 0; i < Database.Customers.size(); i++){
            System.out.println(Database.Customers.get(i).getUsername());
        }

//banCustomer(){set Banned = true}

    };

    public void viewAdmins(){
        for(int i = 0 ; i < Database.Admins.size(); i++){
            System.out.println(Database.Admins.get(i).getUsername());
        }
    };


}