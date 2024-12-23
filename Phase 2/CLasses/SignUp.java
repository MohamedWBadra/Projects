package Classes;
import java.util.Scanner;

public class SignUp {

    static Scanner input=new Scanner(System.in);
//input el type : customer , supplier , admin
//input username w password w confirm pass w date of birth balance address w gender :customer
//input name password :supplier
//input name password dateofbirth workinghours role : admin

    public static void signup( String userName, String password,int year,int months,int days, String address,String cPass,String temp){
      



               
                Customer c = new Customer(userName,password,address,temp,year,months,days);
                
                    Database.Customers.add(c);






        }

    }





