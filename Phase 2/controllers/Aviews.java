package controllers;
import java.io.IOException;
import java.util.ArrayList;
import java.util.List;
import Classes.*;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.FXMLLoader;
import javafx.scene.Node;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.scene.control.Button;
import javafx.scene.control.Label;
import javafx.scene.control.ListView;
import javafx.scene.image.ImageView;
import javafx.scene.layout.AnchorPane;
import javafx.scene.layout.HBox;
import javafx.scene.layout.VBox;
import javafx.stage.Stage;

public class Aviews {

    @FXML
    private Button Abutton;

    @FXML
    private Button Cbutton;

    @FXML
    private Button Obutton;

    @FXML
    private Button Sbutton;

    @FXML
    private Label Title;

    @FXML
    private Button backButton;

    @FXML
    private AnchorPane headerpane;

    @FXML
    private ImageView logo;
private Admin myAdmin=SessionManager.getCurrentAdmin();
    @FXML
    private AnchorPane viewpane;
@FXML
    void handleBackButton(ActionEvent event) {
    try{
            Parent root = FXMLLoader.load(getClass().getResource("/LogIn.fxml"));
            Stage stage = (Stage)((Node)event.getSource()).getScene().getWindow();
            Scene scene = new Scene(root);
            stage.setScene(scene);
            stage.show();
         }catch (IOException e){
            e.getStackTrace();
        }
    }
    @FXML
    private void showCustomer() {
      
        VBox customerList = new VBox(10); // Vertical box for customer entries
        customerList.setPrefWidth(viewpane.getPrefWidth());

        // Loop through customers and display their details
        for (int i=0;i<Database.Customers.size();i++ ) {
            Customer customer=Database.Customers.get(i);
           
            HBox customerEntry = new HBox(10); // Horizontal box for customer info
            customerEntry.setStyle("-fx-padding: 10; -fx-border-color: #ccc; -fx-background-color: #f9f9f9;");

            Label info = new Label(
                "Username: " + customer.getUsername() +
                " | Address: " + customer.getAddress() +
                " | Banned: " + (customer.getBanned() ? "Yes" : "No") +
                " | Balance: $" + customer.getBalance()
              
            );
            info.setStyle("-fx-font-size: 14px;");

            Button banButton = new Button(customer.getBanned() ? "Unban" : "Ban");
            banButton.setOnAction(e -> {
                customer.setBanned(!customer.getBanned()); // Toggle ban status
                banButton.setText(customer.getBanned() ? "Unban" : "Ban"); // Update button text
                info.setText(
                    "Username: " + customer.getUsername() +
                " | Address: " + customer.getAddress() +
                " | Banned: " + (customer.getBanned() ? "Yes" : "No") +
                " | Balance: $" + customer.getBalance()
                ); // Update info label
            });

            customerEntry.getChildren().addAll(info,banButton); // Add info and button to the entry
            customerList.getChildren().add(customerEntry); // Add entry to the list
        }
        viewpane.getChildren().clear();
        viewpane.getChildren().add(customerList); // Add the list to the viewpane
    }
    

    @FXML
    private void showAdmin() {
      
        VBox customerList = new VBox(10); // Vertical box for customer entries
        customerList.setPrefWidth(viewpane.getPrefWidth());

        // Loop through customers and display their details
        for (int i=0;i<Database.Admins.size();i++ ) {
            Admin customer=Database.Admins.get(i);
    
            HBox customerEntry = new HBox(10); // Horizontal box for customer info
            customerEntry.setStyle("-fx-padding: 10; -fx-border-color: #ccc; -fx-background-color: #f9f9f9;");

            Label info = new Label(
                "Username: " + customer.getUsername() +
                " | Role: " + customer.getRole() +
                " | Hours: " + customer.getWorking_hours() 
              
            );
            info.setStyle("-fx-font-size: 14px;");

            // Button banButton = new Button(customer.getBanned() ? "Unban" : "Ban");
            // banButton.setOnAction(e -> {
            //     customer.setBanned(!customer.getBanned()); // Toggle ban status
            //     banButton.setText(customer.getBanned() ? "Unban" : "Ban"); // Update button text
            //     info.setText(
            //         "Username: " + customer.getUsername() +
            //     " | Address: " + customer.getAddress() +
            //     " | Banned: " + (customer.getBanned() ? "Yes" : "No") +
            //     " | Balance: $" + customer.getBalance()
            //     ); // Update info label
            // });

            customerEntry.getChildren().add(info); // Add info and button to the entry
            customerList.getChildren().add(customerEntry); // Add entry to the list
        }
        viewpane.getChildren().clear();

        viewpane.getChildren().add(customerList); // Add the list to the viewpane
    }
    @FXML
    private void showOrder() {
        
        VBox customerList = new VBox(10); // Vertical box for customer entries
        customerList.setPrefWidth(viewpane.getPrefWidth());

        // Loop through customers and display their details
        for (int i=0;i<Database.Orders.size();i++ ) {
        Order customer=Database.Orders.get(i);
        HBox customerEntry = new HBox(10); // Horizontal box for customer info
        customerEntry.setStyle("-fx-padding: 10; -fx-border-color: #ccc; -fx-background-color: #f9f9f9;");

        Label info = new Label(
            "Total Price $: " + customer.getTotalprice() +
            " | Payment method: " + customer.getPaymentMethod() 
          
        );
        info.setStyle("-fx-font-size: 14px;");

        // Button banButton = new Button(customer.getBanned() ? "Unban" : "Ban");
        // banButton.setOnAction(e -> {
        //     customer.setBanned(!customer.getBanned()); // Toggle ban status
        //     banButton.setText(customer.getBanned() ? "Unban" : "Ban"); // Update button text
        //     info.setText(
        //         "Username: " + customer.getUsername() +
        //     " | Address: " + customer.getAddress() +
        //     " | Banned: " + (customer.getBanned() ? "Yes" : "No") +
        //     " | Balance: $" + customer.getBalance()
        //     ); // Update info label
        // });

        customerEntry.getChildren().add(info); // Add info and button to the entry
        customerList.getChildren().add(customerEntry); // Add entry to the list
    }
    viewpane.getChildren().clear();

    viewpane.getChildren().add(customerList);
    }
    
    @FXML
    private void showSupplier() 
    {
     
        
            // Create a VBox to hold the list of suppliers
            VBox supplierList = new VBox(10); // Vertical box for supplier entries
            supplierList.setPrefWidth(viewpane.getPrefWidth());
        
            // Loop through suppliers and display their details
            for (int i = 0; i < Database.suppliers.size(); i++) {
                Supplier supplier = Database.suppliers.get(i);
                
                // Create an HBox for each supplier's info and actions
                HBox supplierEntry = new HBox(10); // Horizontal box for supplier info
                supplierEntry.setStyle("-fx-padding: 10; -fx-border-color: #ccc; -fx-background-color: #f9f9f9;");
        
                // Create a Label to display the supplier's name
                Label info = new Label("Supplier Name: " + supplier.getName());
                info.setStyle("-fx-font-size: 14px;");
        
                // Create a Remove button
                if(!myAdmin.getRole().equals("hr"))
                {
                  
                
                Button removeButton = new Button("Remove");
                removeButton.setOnAction(e -> {
                    // Remove the supplier from the database
                    Database.suppliers.remove(supplier);
        
                    // Remove the supplier entry from the view
                    supplierList.getChildren().remove(supplierEntry);
        
                });
        
                // Add the info label and Remove button to the HBox
                supplierEntry.getChildren().addAll(info, removeButton);
            }
            else
            {
                supplierEntry.getChildren().addAll(info);
            }
        
                // Add the HBox to the VBox
                supplierList.getChildren().add(supplierEntry);
            }
        
            // Clear the previous view and add the new supplier list to the viewpane
            viewpane.getChildren().clear();
            viewpane.getChildren().add(supplierList);
        }
        
        @FXML
        void goToAddSupplier(ActionEvent event) {
            try{
                Parent root = FXMLLoader.load(getClass().getResource("/addSupplier.fxml"));
                Stage stage = (Stage)((Node)event.getSource()).getScene().getWindow();
                Scene scene = new Scene(root);
                stage.setScene(scene);
                stage.show();
             }catch (IOException e){
                e.getStackTrace();
            }
    
        }
    
}
        



 
