import java.util.Scanner;

import javax.print.DocFlavor.STRING;

public class SignUp {
   static int type;
   static String userName;
   static String password;
   static int year;
    static int months;
   static int days;
   static String address;
 static  String gender;
   //String role;

   static int balance;
   static Scanner input=new Scanner(System.in);
//input el type : customer , supplier , admin
//input username w password w confirm pass w date of birth balance address w gender :customer
//input name password :supplier
//input name password dateofbirth workinghours role : admin 

public static void signup(){
do{
    System.out.println("Choose the type of user : \n" + "1 : Customer \n" + "2 : Supplier");
    type=input.nextInt();
    if (type==1){
    String cPass;
    String gender;
    System.out.print("Enter your username : ");
    userName = input.nextLine();
    System.out.println();
    System.out.print("Enter your password : ");
    password =input.nextLine();
    System.out.println();
    System.out.print("Confirm your password : ");
    cPass = input.nextLine();
    while(!(password.equals(cPass))) {
    System.out.print("The two passwords are different \n" +"Please re-enter your password :");
    password=input.nextLine();
    System.out.print("Confirm password : ");              
    cPass=input.nextLine(); 
    }
System.out.println("Enter your date of birth");
System.out.print("Year : ");
year=input.nextInt(); //validate
System.out.println();
System.out.print("Months : ");
months=input.nextInt();
System.out.println();
System.out.print("Days : ");
days=input.nextInt();
System.out.println();
System.out.print("enter your address : ");
 address=input.nextLine();
 System.out.println();
System.out.print("enter your gender : ");
gender=input.nextLine();
System.out.println();
    System.out.print("Enter your balance ");
    balance=input.nextInt();              //validate el input
    System.out.println();
   

Customer c = new Customer(userName,password,balance,address,gender,year,months,days);
Database.Customers.add(c);
    }
// }else if (type==1) {
//     String cpass;
//     System.out.print("Enter your username : ");
//     userName = input.nextLine();
//     System.out.println();
//     System.out.print("Enter your password : ");
//     password =input.nextLine();
//     System.out.println();
//     System.out.print("Confirm your password : ");
//     cpass = input.nextLine();
//     while(!(password.equals(cpass))) {
//     System.out.print("The two passwords are different \n" +"Please re-enter your password :");
//     password=input.nextLine();
//     System.out.print("Confirm password : ");              
//     cpass=input.nextLine(); 
//     }
// System.out.println("Enter your date of birth");
// System.out.print("Year : ");
// year=input.nextInt(); //validate
// System.out.println();
// System.out.print("Months : ");
// months=input.nextInt();
// System.out.println();
// System.out.print("Days : ");
// days=input.nextInt();
// System.out.println();
// System.out.println("Enter your role :");
// role=input.nextLine();
// System.out.println();
// Admin a=new Admin(userName, password, role, 0, year, months, days);
// Database.Admins.add(a); 
// }
else if (type==2) {
    String cpass;
    System.out.print("Enter your username : ");
    userName = input.nextLine();
    System.out.println();
    System.out.print("Enter your password : ");
    password =input.nextLine();
    System.out.println();
    System.out.print("Confirm your password : ");
    cpass = input.nextLine();
    while(!(password.equals(cpass))) {
    System.out.print("The two passwords are different \n" +"Please re-enter your password :");
    password=input.nextLine();
    System.out.print("Confirm password : ");              
    cpass=input.nextLine(); 
    }
    Supplier s =new Supplier(userName,password);
    Database.suppliers.add(s);
    
} else {
    System.out.println("*******INVALID INPUT*****TRY AGAIN********");
    type=input.nextInt();
}
}while(type==1||type==2);
   

}






}
