package controllers;

import java.io.IOException;
import Classes.*;
import javafx.collections.FXCollections;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.FXMLLoader;
import javafx.scene.Node;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.scene.control.Button;
import javafx.scene.control.CheckBox;
import javafx.scene.control.Label;
import javafx.scene.control.TextField;
import javafx.scene.image.ImageView;
import javafx.scene.layout.AnchorPane;
import javafx.scene.layout.HBox;
import javafx.scene.layout.VBox;
import javafx.stage.Stage;

public class viewProductsController {

    @FXML
    private Label Title;

    @FXML
    private Button cart;

    @FXML
    private Button backButton;

    @FXML
    private CheckBox category;

    @FXML
    private AnchorPane headerpane;

    @FXML
    private ImageView logo;

    @FXML
    private Button searchbutton;

    @FXML
    private TextField searchpanel;

    @FXML
    private AnchorPane viewpane;
    private Customer customer=SessionManager.getCustomer();
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
    void searching(ActionEvent event) {
        if(!searchpanel.getText().trim().isEmpty())
        {
            if(category.isSelected())
            {
                VBox customerList = new VBox(10); // Vertical box for customer entries
                customerList.setPrefWidth(viewpane.getPrefWidth());
        
                // Loop through customers and display their details
                for (int i=0;i<Database.suppliers.size();i++ ) {
                    Supplier mySupplier=Database.suppliers.get(i);
                  
                    for(int j=0;j<mySupplier.getMyProducts().size();j++ ){
                        Products myProduct=mySupplier.getMyProducts().get(j);
                        if(myProduct.getCategoryType().equals(searchpanel.getText())){
                    HBox customerEntry = new HBox(10); // Horizontal box for customer info
                    customerEntry.setStyle("-fx-padding: 10; -fx-border-color: #ccc; -fx-background-color: #f9f9f9;");
        
                    Label info = new Label(
                        "Product: " + myProduct.getName() +
                        " | Price: $ " + myProduct.getPrice() +
                        " |In stock: " + (myProduct.getStock()!=0 ? "Yes" : "No") 
                      
                      
                    );
                    info.setStyle("-fx-font-size: 14px;");
                    
                
                    Button addToCart = new Button(myProduct.getStock()!=0 ? "👜" : "⚠️");
                    addToCart.setOnAction(e -> {
                        if(myProduct.getStock()!=0)
                            customer.getOrder().getOrderCart().add(myProduct);
                            myProduct.setStock(myProduct.getStock()-1);
                            customer.getOrder().setTotalPrice(customer.getOrder().getTotalprice()+myProduct.getPrice()); // Toggle ban status
                        addToCart.setText(myProduct.getStock()!=0 ? "👜" : "⚠️");
                         // Update button text
                        info.setText(
                         "Product: " + myProduct.getName() +
                        " | Price: $ " + myProduct.getPrice() +
                        " |In stock: " + (myProduct.getStock()!=0 ? "Yes" : "No") 
                        ); // Update info label
                    });
        
                    customerEntry.getChildren().addAll(info,addToCart); // Add info and button to the entry
                    customerList.getChildren().add(customerEntry); // Add entry to the list
                    }
                }
                    }
                    viewpane.getChildren().clear();
                viewpane.getChildren().add(customerList);
        
                
                }

            
            else{
                VBox customerList = new VBox(10); // Vertical box for customer entries
                customerList.setPrefWidth(viewpane.getPrefWidth());
                for (int i=0;i<Database.suppliers.size();i++ ) {
                    Supplier mySupplier=Database.suppliers.get(i);
                
                    for(int j=0;j<mySupplier.getMyProducts().size();j++ ){
                        Products myProduct=mySupplier.getMyProducts().get(j);
                        if(myProduct.getName().equals(searchpanel.getText())){
                    HBox customerEntry = new HBox(10); // Horizontal box for customer info
                    customerEntry.setStyle("-fx-padding: 10; -fx-border-color: #ccc; -fx-background-color: #f9f9f9;");
        
                    Label info = new Label(
                        "Product: " + myProduct.getName() +
                        " | Price: $ " + myProduct.getPrice() +
                        " |In stock: " + (myProduct.getStock()!=0 ? "Yes" : "No") 
                      
                      
                    );
                    info.setStyle("-fx-font-size: 14px;");
                    
                
                    Button addToCart = new Button(myProduct.getStock()!=0 ? "👜" : "⚠️");
                    addToCart.setOnAction(e -> {
                        customer.getOrder().getOrderCart().add(myProduct);
                        myProduct.setStock(myProduct.getStock()-1);
                        customer.getOrder().setTotalPrice(customer.getOrder().getTotalprice()+myProduct.getPrice()); // Toggle ban status
                        addToCart.setText(myProduct.getStock()!=0 ? "👜" : "⚠️"); // Update button text
                        info.setText(
                         "Product: " + myProduct.getName() +
                        " | Price: $ " + myProduct.getPrice() +
                        " |In stock: " + (myProduct.getStock()!=0 ? "Yes" : "No") 
                        ); // Update info label
                    });
        
                    customerEntry.getChildren().addAll(info,addToCart); // Add info and button to the entry
                    customerList.getChildren().add(customerEntry); // Add entry to the list
                    }
                }
                    }
                    viewpane.getChildren().clear();
                viewpane.getChildren().add(customerList);
            }
      
        }else{
            VBox customerList = new VBox(10); // Vertical box for customer entries
            customerList.setPrefWidth(viewpane.getPrefWidth());

            // Loop through customers and display their details
            for (int i=0;i<Database.suppliers.size();i++ ) {
                Supplier mySupplier=Database.suppliers.get(i);
                for(int j=0;j<mySupplier.getMyProducts().size();j++ ){
                    Products myProduct=mySupplier.getMyProducts().get(j);
                    
                    HBox customerEntry = new HBox(10); // Horizontal box for customer info
                    customerEntry.setStyle("-fx-padding: 10; -fx-border-color: #ccc; -fx-background-color: #f9f9f9;");

                    Label info = new Label(
                    "Product: " + myProduct.getName() +
                    " | Price: $ " + myProduct.getPrice() +
                    " |In stock: " + (myProduct.getStock()!=0 ? "Yes" : "No") );
                    info.setStyle("-fx-font-size: 14px;");
                
            
                    Button addToCart = new Button(myProduct.getStock()!=0 ? "👜" : "⚠️");
                    addToCart.setOnAction(e -> {
                    customer.getOrder().getOrderCart().add(myProduct);
                    myProduct.setStock(myProduct.getStock()-1);
                    customer.getOrder().setTotalPrice(customer.getOrder().getTotalprice()+myProduct.getPrice());// Toggle ban status
                    addToCart.setText(myProduct.getStock()!=0 ? "👜" : "⚠️"); // Update button text
                    info.setText(
                    "Product: " + myProduct.getName() +
                    " | Price: $ " + myProduct.getPrice() +
                    " |In stock: " + (myProduct.getStock()!=0 ? "Yes" : "No") 
                    ); // Update info label
                    }) ;

                    customerEntry.getChildren().addAll(info,addToCart); // Add info and button to the entry
                    customerList.getChildren().add(customerEntry); // Add entry to the list
                
                }
            }
            viewpane.getChildren().clear();
            viewpane.getChildren().add(customerList);
        }
    }
    @FXML
    void goToViewCart(ActionEvent event) throws Exception{
          
        FXMLLoader loader = new FXMLLoader(getClass().getResource("/viewCart.fxml"));
        Parent root = loader.load();
        Stage stage = (Stage) ((Node) event.getSource()).getScene().getWindow();
        Scene scene = new Scene(root);
        stage.setScene(scene);
        stage.show();
    }
    
    @FXML
    void showAll(ActionEvent event) {
        VBox customerList = new VBox(10); // Vertical box for customer entries
        customerList.setPrefWidth(viewpane.getPrefWidth());

        // Loop through customers and display their details
        for (int i=0;i<Database.suppliers.size();i++ ) {
            Supplier mySupplier=Database.suppliers.get(i);
           
            for(int j=0;j<mySupplier.getMyProducts().size();j++ ){
                Products myProduct=mySupplier.getMyProducts().get(j);
                
            HBox customerEntry = new HBox(10); // Horizontal box for customer info
            customerEntry.setStyle("-fx-padding: 10; -fx-border-color: #ccc; -fx-background-color: #f9f9f9;");

            Label info = new Label(
                "Product: " + myProduct.getName() +
                " | Price: $ " + myProduct.getPrice() +
                " |In stock: " + (myProduct.getStock()!=0 ? "Yes" : "No") 
              
              
            );
            info.setStyle("-fx-font-size: 14px;");
            
        
            Button addToCart = new Button(myProduct.getStock()!=0 ? "👜" : "⚠️");
            addToCart.setOnAction(e -> {
                if(myProduct.getStock() != 0){
                    customer.getOrder().getOrderCart().add(myProduct);
                    myProduct.setStock(myProduct.getStock()-1);
                    customer.getOrder().setTotalPrice(customer.getOrder().getTotalprice()+myProduct.getPrice());// Toggle ban status
                    addToCart.setText(myProduct.getStock()!=0 ? "👜" : "⚠️"); // Update button text
                    info.setText(
                    "Product: " + myProduct.getName() +
                    " | Price: $ " + myProduct.getPrice() +
                    " |In stock: " + (myProduct.getStock()!=0 ? "Yes" : "No") 
                    ); // Update info label
                }
            });

            customerEntry.getChildren().addAll(info,addToCart); // Add info and button to the entry
            customerList.getChildren().add(customerEntry); // Add entry to the list
            
        }
    }
        viewpane.getChildren().clear();
        viewpane.getChildren().add(customerList);


    }

    @FXML
    void showInterests(ActionEvent event) {
        VBox customerList = new VBox(10); // Vertical box for customer entries
        customerList.setPrefWidth(viewpane.getPrefWidth());

        // Loop through customers and display their details
        for (int i=0;i<Database.suppliers.size();i++ ) {
            Supplier mySupplier=Database.suppliers.get(i);
           
            for(int j=0;j<mySupplier.getMyProducts().size();j++ ){
                Products myProduct=mySupplier.getMyProducts().get(j);
                if(customer.getInterests().contains(myProduct.getMyCategory()))
{
                
            HBox customerEntry = new HBox(10); // Horizontal box for customer info
            customerEntry.setStyle("-fx-padding: 10; -fx-border-color: #ccc; -fx-background-color: #f9f9f9;");

            Label info = new Label(
                "Product: " + myProduct.getName() +
                " | Price: $ " + myProduct.getPrice() +
                " |In stock: " + (myProduct.getStock()!=0 ? "Yes" : "No") 
              
              
            );
            info.setStyle("-fx-font-size: 14px;");
            
        
            Button addToCart = new Button(myProduct.getStock()!=0 ? "👜" : "⚠️");
            addToCart.setOnAction(e -> {
                if(myProduct.getStock() != 0){
                    customer.getOrder().getOrderCart().add(myProduct);
                    myProduct.setStock(myProduct.getStock()-1);
                    customer.getOrder().setTotalPrice(customer.getOrder().getTotalprice()+myProduct.getPrice());// Toggle ban status
                    addToCart.setText(myProduct.getStock()!=0 ? "👜" : "⚠️"); // Update button text
                    info.setText(
                    "Product: " + myProduct.getName() +
                    " | Price: $ " + myProduct.getPrice() +
                    " |In stock: " + (myProduct.getStock()!=0 ? "Yes" : "No") 
                    ); // Update info label
                }
            });

            customerEntry.getChildren().addAll(info,addToCart); // Add info and button to the entry
            customerList.getChildren().add(customerEntry); // Add entry to the list
            
        }
    }
    }
        viewpane.getChildren().clear();
        viewpane.getChildren().add(customerList);


    }


}
