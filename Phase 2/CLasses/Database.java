package Classes;
import java.util.ArrayList;
public abstract class Database {
    public static ArrayList<Supplier> suppliers = new ArrayList<Supplier>() {
        {
            Supplier d=new Supplier("dell", "dell");
            
            add(d);
           
        }
        
    };
    
    public static ArrayList<Customer> Customers=new ArrayList<Customer>() {
        
        {
           
            add(new Customer("Mahmoud", "momo", "Nasr City", "Male", 2005, 12, 2));
            
           
        }
    };
    public static ArrayList<Admin> Admins = new ArrayList<Admin>()
    {
        {
          
            add(new Admin("W.Badra", "tamacoco", "ceo", 6,1971,9,20));
            add(new Admin("M.Fathy", "tamacoco", "hr", 10,1971,9,20));
           
        }
    };
    public static ArrayList<Order> Orders = new ArrayList<Order>();

    public static ArrayList<String> balanceCodes=new ArrayList<String>() {
        {
        add("aux00150");
        add("qnb01240");
        add("kfc00520");
        add("fox02500");
        add("cib02430");
        add("ksa00725");
    }
};

    public static ArrayList<String> Categories = new ArrayList<String>() {
        {
            add("accessories");
            add("laptops");
            add("mobiles");
            add("watches");
            add("batteries");
            add("others");
        }
    };
}