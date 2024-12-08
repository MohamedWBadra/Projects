import java.util.Scanner;

public class SignUp {

    static Scanner input=new Scanner(System.in);
//input el type : customer , supplier , admin
//input username w password w confirm pass w date of birth balance address w gender :customer
//input name password :supplier
//input name password dateofbirth workinghours role : admin

    public static int signup(){
        String userName;
        String password;
        int year;
        int months;
        int days;
        String address;
        double balance;
        String cPass;
        String temp="";



                System.out.println("Enter your username : ");
                userName = input.nextLine();

                System.out.println("Enter your password : ");
                password =input.nextLine();

                System.out.println("Confirm your password : ");
                cPass = input.nextLine();
                while(!(password.equals(cPass))) {
                    System.out.println("The two passwords are different \n" +"Please re-enter your password :");
                    password=input.nextLine();
                    System.out.println("Confirm password : ");
                    cPass=input.nextLine();
                }
                System.out.println("Enter your date of birth");
                System.out.println("Year : ");
                year=input.nextInt(); //validate
                System.out.println("Months : ");
                months=input.nextInt();
                System.out.println("Days : ");
                days=input.nextInt();
                input.nextLine();
                System.out.println("enter your address : ");
                address=input.nextLine();

                System.out.println("Enter your balance ");
                balance=input.nextDouble();   
                input.nextLine();
                System.out.println("enter your gender : M or F");
                Customer c = new Customer(userName,password,balance,temp,address,year,months,days);
                if(!Database.Customers.contains(c))
                {
                    Database.Customers.add(c);
                    return Database.Customers.size()-1;

                }
                else {
                    System.err.println("this customer already exists");
                    return -1;
                }






        }

    }





