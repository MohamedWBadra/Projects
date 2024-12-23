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

public class viewSupplierProductsController {

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
    private Supplier mySupplier=SessionManager.getCurrentSupplier();
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
    public void initialize() {
       
        VBox productList = new VBox(10); // Vertical box for customer entries
        productList.setPrefWidth(viewpane.getPrefWidth());

        // Loop through customers and display their details
        
            for(int j=0;j<mySupplier.getMyProducts().size();j++ ){
                Products myProduct=mySupplier.getMyProducts().get(j);
                
                HBox Productpane = new HBox(10); // Horizontal box for customer info
                Productpane.setStyle("-fx-padding: 10; -fx-border-color: #ccc; -fx-background-color: #f9f9f9;");

                Label info = new Label(
                    "Product: " + myProduct.getName() +
                    " | Price: $ " + myProduct.getPrice() +
                    " |In stock: " + (myProduct.getStock()!=0 ? "Yes" : "No") 
                
                
                );
                info.setStyle("-fx-font-size: 14px;");
                
            
                Button removeButton = new Button("🗑️");
                removeButton.setOnAction(e -> {
                mySupplier.getMyProducts().remove(myProduct);
                productList.getChildren().remove(Productpane);
            });

                Productpane.getChildren().addAll(info,removeButton); // Add info and button to the entry
                productList.getChildren().add(Productpane); // Add entry to the list
            
        }
    
        viewpane.getChildren().clear();
        viewpane.getChildren().add(productList);

        
}
 

    @FXML
    void searching(ActionEvent event) {
        if(!searchpanel.getText().trim().isEmpty())
        {
            if(category.isSelected())
            {
                VBox productList = new VBox(10); // Vertical box for customer entries
                productList.setPrefWidth(viewpane.getPrefWidth());

                    for(int j=0;j<mySupplier.getMyProducts().size();j++ ){
                        Products myProduct=mySupplier.getMyProducts().get(j);
                        if(myProduct.getCategoryType().equals(searchpanel.getText())){
                      HBox Productpane = new HBox(10); // Horizontal box for customer info
                Productpane.setStyle("-fx-padding: 10; -fx-border-color: #ccc; -fx-background-color: #f9f9f9;");

                Label info = new Label(
                    "Product: " + myProduct.getName() +
                    " | Price: $ " + myProduct.getPrice() +
                    " |In stock: " + (myProduct.getStock()!=0 ? "Yes" : "No") 
                
                
                );
                info.setStyle("-fx-font-size: 14px;");
                
            
                Button removeButton = new Button("🗑️");
                removeButton.setOnAction(e -> {
                mySupplier.getMyProducts().remove(myProduct);
                productList.getChildren().remove(Productpane);
            });

                Productpane.getChildren().addAll(info,removeButton); // Add info and button to the entry
                productList.getChildren().add(Productpane); // Add entry to the list
        }
        
        }
    
        viewpane.getChildren().clear();
        viewpane.getChildren().add(productList);
    }
            
            else{
                VBox productList = new VBox(10); // Vertical box for customer entries
                productList.setPrefWidth(viewpane.getPrefWidth());

                    for(int j=0;j<mySupplier.getMyProducts().size();j++ ){
                        Products myProduct=mySupplier.getMyProducts().get(j);
                        if(myProduct.getName().equals(searchpanel.getText())){
                      HBox Productpane = new HBox(10); // Horizontal box for customer info
                Productpane.setStyle("-fx-padding: 10; -fx-border-color: #ccc; -fx-background-color: #f9f9f9;");

                Label info = new Label(
                    "Product: " + myProduct.getName() +
                    " | Price: $ " + myProduct.getPrice() +
                    " |In stock: " + (myProduct.getStock()!=0 ? "Yes" : "No") 
                
                
                );
                info.setStyle("-fx-font-size: 14px;");
                
            
                Button removeButton = new Button("🗑️");
                removeButton.setOnAction(e -> {
                mySupplier.getMyProducts().remove(myProduct);
                productList.getChildren().remove(Productpane);
            });

                Productpane.getChildren().addAll(info,removeButton); // Add info and button to the entry
                productList.getChildren().add(Productpane); // Add entry to the list
        }
        
        }
    
        viewpane.getChildren().clear();
        viewpane.getChildren().add(productList);
    
            }
      
        }else{
            VBox productList = new VBox(10); // Vertical box for customer entries
        productList.setPrefWidth(viewpane.getPrefWidth());

        // Loop through customers and display their details
        
            for(int j=0;j<mySupplier.getMyProducts().size();j++ ){
                Products myProduct=mySupplier.getMyProducts().get(j);
                
                HBox Productpane = new HBox(10); // Horizontal box for customer info
                Productpane.setStyle("-fx-padding: 10; -fx-border-color: #ccc; -fx-background-color: #f9f9f9;");

                Label info = new Label(
                    "Product: " + myProduct.getName() +
                    " | Price: $ " + myProduct.getPrice() +
                    " |In stock: " + (myProduct.getStock()!=0 ? "Yes" : "No") 
                
                
                );
                info.setStyle("-fx-font-size: 14px;");
                
            
                Button removeButton = new Button("🗑️");
                removeButton.setOnAction(e -> {
                mySupplier.getMyProducts().remove(myProduct);
                productList.getChildren().remove(Productpane);
            });

                Productpane.getChildren().addAll(info,removeButton); // Add info and button to the entry
                productList.getChildren().add(Productpane); // Add entry to the list
            
        }
    
        viewpane.getChildren().clear();
        viewpane.getChildren().add(productList);
        }
    }

   
    @FXML
    void goToAddProducts(ActionEvent event) {
        try{
            Parent root = FXMLLoader.load(getClass().getResource("/addProducts.fxml"));
            Stage stage = (Stage)((Node)event.getSource()).getScene().getWindow();
            Scene scene = new Scene(root);
            stage.setScene(scene);
            stage.show();
        }catch (IOException e){
            e.getStackTrace();
        }

    }


}
