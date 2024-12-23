package Classes;

public class SessionManager {
    private static Customer currentCustomer;
    private static Admin currentAdmin;
    private static Supplier currentSupplier;

    public static Customer getCustomer() {
        return currentCustomer;
    }
public static Admin getCurrentAdmin() {
    return currentAdmin;
}
public static Supplier getCurrentSupplier() {
    return currentSupplier;
}
public static void setCurrentAdmin(Admin currentAdmin) {
    SessionManager.currentAdmin = currentAdmin;
}
public static void setCurrentSupplier(Supplier currentSupplier) {
    SessionManager.currentSupplier = currentSupplier;
}
    public static void setCustomer(Customer customer) {
        currentCustomer = customer;
}
}