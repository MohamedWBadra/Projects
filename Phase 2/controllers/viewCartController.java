package controllers;


import Classes.*;
import javafx.collections.FXCollections;
import javafx.collections.ObservableList;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.FXMLLoader;
import javafx.fxml.Initializable;
import javafx.scene.Node;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.scene.control.Button;
import javafx.scene.control.Label;
import javafx.scene.control.TableColumn;
import javafx.scene.control.TableView;
import javafx.scene.control.cell.PropertyValueFactory;
import javafx.scene.layout.AnchorPane;
import javafx.scene.layout.FlowPane;
import javafx.scene.layout.HBox;
import javafx.scene.layout.Pane;
import javafx.scene.layout.VBox;
import javafx.stage.Stage;

import java.io.IOException;
import java.net.URL;
import java.util.ArrayList;
import java.util.ResourceBundle;

public class viewCartController{
    //@FXML
    //private FlowPane ProductsPane;

    @FXML
    private Button CheckOutButton;
   
    @FXML
    private Label TotalpriceLabel;


    @FXML
    private VBox cartVBox;

    @FXML
    private AnchorPane viewpane;
    

    private Customer myCustomer=SessionManager.getCustomer();
   private ArrayList<Products> cartItems = myCustomer.getOrder().getOrderCart();
   
   
    public void initialize() {
     
        // cartVBox.getChildren().clear();

        // cartVBox.prefWidthProperty().bind(ProductsPane.widthProperty());
        // cartVBox.prefHeightProperty().bind(ProductsPane.heightProperty());

        // for(Products p : cartItems){
        //     HBox product = new HBox(10);
        //     product.setStyle("-fx-padding: 10; -fx-border-style: solid inside; -fx-border-width: 2; -fx-border-color: #87CEEB;");

        //     Label nameTag = new Label(p.getName());
        //     nameTag.setStyle("-fx-font-size: 18px; -fx-text-fill: #000000; -fx-padding: 55;");

        //     Label priceTag = new Label(String.valueOf(p.getPrice()));
        //     priceTag.setStyle("-fx-font-size: 18px; -fx-text-fill: #000000; -fx-padding: 55;");

        //     Label categoryTag = new Label(p.getMyCategory().getType());
        //     categoryTag.setStyle("-fx-font-size: 18px; -fx-text-fill: #000000; -fx-padding: 55;");

        //     Button rv = new Button("Remove");
        //     rv.setStyle("-fx-background-color: #FF0000; -fx-text-fill: white; -fx-padding: 55;");
        //     rv.setOnAction(e -> {
        //         cartItems.remove(p);
        //         cartVBox.getChildren().remove(product);
        //     });

        //     product.getChildren().addAll(nameTag, priceTag, categoryTag, rv);

        //     cartVBox.getChildren().add(product);
        // }
        TotalpriceLabel.setText("Total : " + myCustomer.getOrder().getTotalprice());
        VBox customerList = new VBox(10); 
        customerList.setPrefWidth(viewpane.getPrefWidth());

        // Loop through customers and display their details
        for (int i=0;i<cartItems.size();i++ ) {
            Products myProduct=cartItems.get(i);
          
            // for(int j=0;j<mySupplier.getMyProducts().size();j++ ){
            //     Products myProduct=mySupplier.getMyProducts().get(j);
                
            HBox ProductPane = new HBox(10); // Horizontal box for customer info
            ProductPane.setStyle("-fx-padding: 10; -fx-border-color: #ccc; -fx-background-color: #f9f9f9;");

            Label info = new Label(
                "Product: " + myProduct.getName() +
                " | Price: $ " + myProduct.getPrice()
            );
            info.setStyle("-fx-font-size: 14px;");
            
        
            Button removeButton = new Button("🗑️");
            removeButton.setOnAction(e -> {
                myCustomer.getOrder().getOrderCart().remove(myProduct);
                myCustomer.getOrder().setTotalPrice(myCustomer.getOrder().getTotalprice()-myProduct.getPrice());
                TotalpriceLabel.setText("Total : " + myCustomer.getOrder().getTotalprice());
                myProduct.setStock(myProduct.getStock()+1); // Toggle ban status
                customerList.getChildren().remove(ProductPane);
        
                
            });

            ProductPane.getChildren().addAll(info,removeButton); // Add info and button to the entry
            customerList.getChildren().add(ProductPane); // Add entry to the list
            
        }
            
        viewpane.getChildren().clear();
        viewpane.getChildren().add(customerList);
    }

    @FXML
    void handleBackButton(ActionEvent event) {
        try{
            Parent root = FXMLLoader.load(getClass().getResource("/viewProducts.fxml"));
            Stage stage = (Stage)((Node)event.getSource()).getScene().getWindow();
            Scene scene = new Scene(root);
            stage.setScene(scene);
            stage.show();
        }catch (IOException e){
            e.getStackTrace();
        }
    }

    @FXML
    void switchToPaymentMethods(ActionEvent event){
        try{
            Parent root = FXMLLoader.load(getClass().getResource("/Checkout.fxml"));
            Stage stage = (Stage)((Node)event.getSource()).getScene().getWindow();
            Scene scene = new Scene(root);
            stage.setScene(scene);
            stage.show();
           
        }catch (IOException e){
            e.getStackTrace();
        }
    }

    /*
    @FXML
    public void intilalize(ArrayList<Products> products){
        for(int i = 0 ; i < products.size() ; i++){
            Pane product = new Pane();
            Label label = new Label(products.get(i).getName());
            product.getChildren().add(label);
            ProductsPane.getChildren().add(product);
        }

    }

     */

}