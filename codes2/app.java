import java.util.Scanner;

public abstract class app {
    int usertype;
    Scanner scanner = new Scanner(System.in);

    public void app_run() {
        String exitapp = "C";
        while (!exitapp.equals("E")) {
            //uninitiallized errors will be fixed kaman shwaya
            //login aw signup

            String swapuser = "C";
            if (usertype == 0)//Customer
            {
                Customer myCustomer;

                while (!swapuser.equals("E")) {
                    String key = "";
                    while (true) {
                        System.out.println("please enter which operation do you want to do from these keys:");
                        System.out.println("'A' = view all products. 'S'=search product by name.'SC'=search product by category.'ESC'=back.'E'=Log out");
                        key = scanner.nextLine();
                        if (key.toUpperCase().equals("A")) {
                            myCustomer.viewAllProducts();

                        } else if (key.toUpperCase().equals("S")) {
                            System.out.print("search:");
                            String n = scanner.nextLine();
                            myCustomer.viewByName(n);
                        } else if (key.toUpperCase().equals("SC")) {
                            System.out.print("search:");
                            String c = scanner.nextLine();
                            myCustomer.viewByCategory(c);

                        } else if (key.toUpperCase().equals("E")) {
                            swapuser = "E";
                            break;
                        } else if (key.toUpperCase().equals("ESC")) {
                            break;
                        } else {
                            System.err.println("key is not valid please enter a valid key");
                        }
                    }
                    if (swapuser.equals("E")) {
                        break;
                    }
                    while (true) {
                        System.out.println("If you want to add something to your cart from these products press:'C'.Else if you want to remove something from your cart press: 'R'.Else to exit add to cart press:'N'.to Log out press:'E' ");
                        key = scanner.nextLine();
                        if (key.toUpperCase().equals("C")) {
                            System.out.println("enter supplier's number: ");
                            int is = scanner.nextInt();
                            System.out.println("enter product's number: ");
                            int ip = scanner.nextInt();
                            try {
                                myCustomer.addToCart(is, ip);
                            } catch (ArrayIndexOutOfBoundsException ex) {
                                System.err.println("the supplier's or the product's number is wrong");

                            }

                        } else if (key.toUpperCase().equals("R")) {
                            myCustomer.viewmycart();
                            System.out.println("enter product's number: ");
                            int ip = scanner.nextInt();
                            try {
                                myCustomer.removeFromCart(ip);
                            } catch (ArrayIndexOutOfBoundsException ex) {
                                System.err.println("the supplier's or the product's number is wrong");

                            }

                        } else if (key.toUpperCase().equals("N")) {
                            break;
                        } else if (key.toUpperCase().equals("E")) {
                            swapuser = "E";
                            break;
                        } else {
                            System.err.println("key is not valid please enter a valid key");
                        }
                    }
                    while (true) {
                        System.out.println("To place your order enter 'P' .to Logout enter 'E'");
                        key = scanner.nextLine();
                        if(key.toUpperCase().equals("P"))
                        {
                            if(myCustomer.getOrder().getPaymentMethod()==null)
                            {
                                System.out.println("please choose a payment method for your order :");
                                System.out.println(" 'CR'=by card. 'CA' = by cash.'B' = by balance");
                                key = scanner.nextLine();
                                while (true)
                                {
                                    if(key.toUpperCase().equals("CR"))
                                    {
                                        while (true) {
                                            int ID = scanner.nextInt();
                                            int cvv = scanner.nextInt();
                                            if (String.valueOf(ID).length() == 16 && String.valueOf(cvv).length() == 3) {

                                                myCustomer.setCredit_card(ID,cvv);
                                                myCustomer.PlaceOrder();
                                                break;
                                            }
                                            else {
                                                System.out.println("Card number or cvv are wrong make sure that card number is 16 numbers and cvv is 3 numbers");
                                                }
                                        }
                                        break;
                                    }
                                    else if(key.toUpperCase().equals("CA"))
                                    {
                                        myCustomer.getOrder().setPaymentMethod("cash");
                                        myCustomer.PlaceOrder();
                                        break;
                                    }
                                    else if(key.toUpperCase().equals("B"))
                                    {
                                        myCustomer.getOrder().setPaymentMethod("balance");
                                        myCustomer.PlaceOrder();
                                        break;
                                    }
                                    else {
                                        System.err.println("key is not valid please enter a valid key");
                                    }
                                }

                            }
                            else {
                                System.out.println("Your default payment method is: "+myCustomer.getOrder().getPaymentMethod());
                                System.out.println("To pay with the default method press 'Y' else press 'N'");
                                key = scanner.nextLine();
                                if(key.toUpperCase().equals("Y")){
                                   myCustomer.PlaceOrder();
                                }
                                else if(key.toUpperCase().equals("N"))
                                {
                                    System.out.println("please choose a payment method for your order :");
                                    System.out.println(" 'CR'=by card. 'CA' = by cash.'B' = by balance");
                                    key = scanner.nextLine();
                                    while (true)
                                    {
                                        if(key.toUpperCase().equals("CR"))
                                        {
                                            while (true) {
                                                int ID = scanner.nextInt();
                                                int cvv = scanner.nextInt();
                                                if (String.valueOf(ID).length() == 16 && String.valueOf(cvv).length() == 3) {

                                                    myCustomer.setCredit_card(ID,cvv);
                                                    myCustomer.PlaceOrder();
                                                    break;
                                                }
                                                else {
                                                    System.out.println("Card number or cvv are wrong make sure that card number is 16 numbers and cvv is 3 numbers");
                                                }
                                            }
                                            break;
                                        }
                                        else if(key.toUpperCase().equals("CA"))
                                        {
                                            myCustomer.getOrder().setPaymentMethod("cash");
                                            myCustomer.PlaceOrder();
                                            break;
                                        }
                                        else if(key.toUpperCase().equals("B"))
                                        {
                                            myCustomer.getOrder().setPaymentMethod("balance");
                                            myCustomer.PlaceOrder();
                                            break;
                                        }
                                        else {
                                            System.err.println("key is not valid please enter a valid key");
                                        }
                                    }

                                }
                                else{
                                    System.err.println("key is not valid please enter a valid key");
                                }
                            }
                        }
                         else if (key.toUpperCase().equals("E")) {
                            swapuser = "E";
                            break;
                        } else {
                            System.err.println("key is not valid please enter a valid key");
                        }
                    }
                    if (swapuser.equals("E")) {
                        break;
                    }
                    //lesa el place order bs lma el payments tetzabat(de sa3ba)
                }
            } else if (usertype == 1)//Admin
            {
                while (!swapuser.equals("E")) {
                    Admin myAdmin;
                    String key = "";
                    while (true) {
                        System.out.println("please enter which operation do you want to do from these keys:");
                        System.out.println("'A' to add a new supplier.'B' to ban a user.'V' to start viewing.'E' to Log out");
                        key = scanner.nextLine();
                        if (key.toUpperCase().equals("A")) {
                            if (myAdmin.getRole().equals("hr")) {
                                System.err.println("as an 'hr' you can't have access to the suplliers");
                            } else {
                                String n = scanner.nextLine();
                                String password = scanner.nextLine();
                                Supplier nSupplier = new Supplier(n, password);
                                myAdmin.addSupplier(nSupplier);
                            }
                        } else if (key.toUpperCase().equals("V")) {
                            break;

                        } else if (key.toUpperCase().equals("E")) {
                            swapuser = "E";
                            break;
                        } else {
                            System.err.println("key is not valid please enter a valid key");
                        }
                    }
                    if (swapuser.equals("E")) {
                        break;
                    }
                    while (true) {
                        System.out.println("'A' = view all products. 'SC'=search product by category. 'O' = view orders. 'C' = view customers. 'AD' = view admins. 'S' = view suppliers. 'ESC'=back.'E'=Log out");
                        key = scanner.nextLine();
                        if (key.toUpperCase().equals("A")) {
                            myAdmin.viewAllProducts();

                        } else if (key.toUpperCase().equals("S")) {
                            if (myAdmin.getRole().equals("hr")) {
                                System.err.println("as an 'hr' you can't have access to the suplliers");
                            } else {
                                myAdmin.viewSuppliers();
                            }

                        } else if (key.toUpperCase().equals("O")) {
                            myAdmin.viewOrders();
                        } else if (key.toUpperCase().equals("AD")) {
                            if (myAdmin.getRole().equals("ceo")) {
                                myAdmin.viewAdmins();
                            } else {
                                System.out.println("Only the CEO can access this data!");
                            }
                        } else if (key.toUpperCase().equals("SC")) {
                            System.out.print("search:");
                            String c = scanner.nextLine();
                            myAdmin.viewByCategory(c);

                        } else if (key.toUpperCase().equals("E")) {
                            swapuser = "E";
                            break;
                        } else if (key.toUpperCase().equals("ESC")) {
                            break;
                        } else {
                            System.err.println("key is not valid please enter a valid key");
                        }
                    }
                    if (swapuser.equals("E")) {
                        break;
                    }
                }
            } else if(usertype == 2)//Supplier
            {
                while (!swapuser.equals("E")) {
                    Supplier mySupplier;
                    String key = "";
                    while(true)
                    {
                        System.out.println("please enter which operation do you want to do from these keys:");
                        System.out.println("'A' = add new product.'SC'=search product by category.'VA'=view al products.'E'=Log out");
                        if (key.toUpperCase().equals("A"))
                        {
                            System.out.print("product name: ");
                            String n=scanner.nextLine();
                            System.out.print("product price: ");
                            Float p=scanner.nextFloat();
                            System.out.print("product stock: ");
                            int stock=scanner.nextInt();
                            System.out.print("product category: ");
                            String category=scanner.nextLine();
                            mySupplier.addproduct(new Products(n,p,category,stock));
                        }
                        else if(key.toUpperCase().equals("SC"))
                        {
                            System.out.print("search:");
                            String n = scanner.nextLine();
                            mySupplier.viewByCategory(n);

                        }
                        else if(key.toUpperCase().equals("VA"))
                        {
                            mySupplier.viewAllProducts();

                        }
                        else if (key.toUpperCase().equals("E")) {
                            swapuser = "E";
                            break;
                        } else {
                            System.err.println("key is not valid please enter a valid key");
                        }
                    }
                    if (swapuser.equals("E")) {
                        break;
                    }

                }


            }


        }
    }
}