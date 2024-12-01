import java.util.Scanner;

public abstract class app {
    int usertype;
    Scanner scanner = new Scanner(System.in);

    public void app_run() {
        String exitapp = "C";
        while (!exitapp.equals("E")) {
            //uninitiallized errors will be fixed kaman shwaya
            String swapuser = "C";
            if (usertype == 0)//Customer
            {
                Customer myCustomer;

                while (!swapuser.equals("E")) {
                    String key = "";
                    while (true) {
                        System.out.println("please enter which operation do you want to do from these keys:");
                        System.out.println("'A' = view all products. 'S'=search product by name.'SC'=search product by category.'esc'=back.'E'=Log out");
                        key = scanner.nextLine();
                        if (key.equals("A")) {
                            myCustomer.viewAllProducts();

                        } else if (key.equals("S")) {
                            System.out.print("search:");
                            String n = scanner.nextLine();
                            myCustomer.viewByName(n);
                        } else if (key.equals("SC")) {
                            System.out.print("search:");
                            String c = scanner.nextLine();
                            myCustomer.viewByCategory(c);

                        } else if (key.equals("E")) {
                            swapuser = "E";
                            break;
                        } else if (key.equals("esc")) {
                            break;
                        } else {
                            System.err.println("key is not valid please enter a valid key");
                        }
                    }
                    if (swapuser.equals("E")) {
                        break;
                    }
                    while (true) {
                        System.out.println("If you want to add somthing to your cart from these products press:'C'.Else if you want to remove somthing from your cart press: 'R'.Else to exit add to cart press:'N'.to Log out press:'E' ");
                        key = scanner.nextLine();
                        if (key.equals("C")) {
                            System.out.println("enter supplier's number: ");
                            int is = scanner.nextInt();
                            System.out.println("enter product's number: ");
                            int ip = scanner.nextInt();
                            try {
                                myCustomer.addToCart(is, ip);
                            } catch (ArrayIndexOutOfBoundsException ex) {
                                System.err.println("the supplier's or the product's number is wrong");

                            }

                        } else if (key.equals("R")) {
                            myCustomer.viewmycart();
                            System.out.println("enter product's number: ");
                            int ip = scanner.nextInt();
                            try {
                                myCustomer.removeFromCart(ip);
                            } catch (ArrayIndexOutOfBoundsException ex) {
                                System.err.println("the supplier's or the product's number is wrong");

                            }

                        } else if (key.equals("N")) {
                            break;
                        } else if (key.equals("E")) {
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
                        if (key.equals("A")) {
                            if (myAdmin.getRole().equals("hr")) {
                                System.err.println("as an 'hr' you can't have access to the suplliers");
                            } else {
                                String n = scanner.nextLine();
                                String password = scanner.nextLine();
                                Supplier nSupplier = new Supplier(n, password);
                                myAdmin.addSupplier(nSupplier);
                            }
                        } else if (key.equals("V")) {
                            break;

                        } else if (key.equals("E")) {
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
                        System.out.println("'A' = view all products. 'SC'=search product by category. 'O' = view orders. 'C' = view customers. 'AD' = view admins. 'S' = view suppliers. esc'=back.'E'=Log out");
                        key = scanner.nextLine();
                        if (key.equals("A")) {
                            myAdmin.viewAllProducts();

                        } else if (key.equals("S")) {
                            if (myAdmin.getRole().equals("hr")) {
                                System.err.println("as an 'hr' you can't have access to the suplliers");
                            } else {
                                myAdmin.viewSuppliers();
                            }

                        } else if (key.equals("O")) {
                            myAdmin.viewOrders();
                        } else if (key.equals("AD")) {
                            if (myAdmin.getRole().equals("ceo")) {
                                myAdmin.viewAdmins();
                            } else {
                                System.out.println("Only the CEO can access this data!");
                            }
                        } else if (key.equals("SC")) {
                            System.out.print("search:");
                            String c = scanner.nextLine();
                            myAdmin.viewByCategory(c);

                        } else if (key.equals("E")) {
                            swapuser = "E";
                            break;
                        } else if (key.equals("esc")) {
                            break;
                        } else {
                            System.err.println("key is not valid please enter a valid key");
                        }
                    }
                    if (swapuser.equals("E")) {
                        break;
                    }
                }
            } else//Supplier
            {
                while (!swapuser.equals("E")) {
                    Supplier mySupplier;
                    String key = "";

                }

            }


        }
    }
}
