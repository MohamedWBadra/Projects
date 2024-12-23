package controllers;

import java.io.IOException;
import java.util.function.Supplier;
import Classes.*;
import Classes.Database;
import Classes.SessionManager;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.FXMLLoader;
import javafx.scene.Node;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.scene.control.Button;
import javafx.scene.control.Label;
import javafx.scene.control.PasswordField;
import javafx.scene.control.TextField;
import javafx.scene.image.ImageView;
import javafx.scene.layout.AnchorPane;
import javafx.stage.Stage;

public class addProductsController {

    @FXML
    private Button button;

    @FXML
    private AnchorPane headerpane;

    @FXML
    private AnchorPane infopane;

    @FXML
    private ImageView logo;

    @FXML
    private AnchorPane mainpane;

    @FXML
    private Label myTitle;

    @FXML
    private TextField category;

    @FXML
    private TextField price;

    @FXML
    private TextField stock;

    @FXML
    private Label sTitle;

    @FXML
    private TextField username;

    private Classes.Supplier mySupplier = SessionManager.getCurrentSupplier();

    @FXML
    void createProduct(ActionEvent event) throws IOException {
        if(username.getText().trim().isEmpty() || price.getText().trim().isEmpty() || category.getText().trim().isEmpty() || stock.getText().trim().isEmpty())
        {
            username.setPromptText("Invalid");
            stock.setPromptText("Invalid");
            price.setPromptText("Invalid");
            category.setPromptText("Invalid");
        }
        else{
            try{
                Integer.parseInt(stock.getText());
                
            }
            catch(NumberFormatException e){
                stock.clear();
                stock.setPromptText("Enter a valid stock");
                return;
            }
            try{
                Float.parseFloat(price.getText());
                
            }
            catch(NumberFormatException e){
                price.clear();
                price.setPromptText("Enter a valid Price");
                return;
            }
        mySupplier.getMyProducts().add(new Classes.Products(username.getText(), Float.valueOf(price.getText()), category.getText(), Integer.valueOf(stock.getText())));
        username.clear();
            stock.clear();
            price.clear();
            category.clear();
      }
    }
    @FXML
    void handleBackButton(ActionEvent event) {
        try{
            Parent root = FXMLLoader.load(getClass().getResource("/viewSupplierProducts.fxml"));
            Stage stage = (Stage)((Node)event.getSource()).getScene().getWindow();
            Scene scene = new Scene(root);
            stage.setScene(scene);
            stage.show();
        }catch (IOException e){
            e.getStackTrace();
        }
    }
    
}
