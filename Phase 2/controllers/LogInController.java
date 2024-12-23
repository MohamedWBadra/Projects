package controllers;
import java.io.IOException;
import java.lang.reflect.Type;

import Classes.*;
import javafx.collections.FXCollections;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.FXMLLoader;
import javafx.scene.Node;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.scene.control.Button;
import javafx.scene.control.ComboBox;
import javafx.scene.control.PasswordField;
import javafx.scene.control.TextField;
import javafx.scene.layout.AnchorPane;
import javafx.stage.Stage;

public class LogInController {

    
    @FXML
    private Button LogInButton;

    @FXML
    private PasswordField tfPassword;

    @FXML
    private TextField tfUserName;
    @FXML
    private ComboBox<String> Tyoe;
    public void initialize() {
    Tyoe.setItems(FXCollections.observableArrayList("Customer", "Admin","Supplier"));
 
}

    @FXML
    void goSignUp(ActionEvent event)  throws Exception{
        FXMLLoader loader = new FXMLLoader(getClass().getResource("/signup.fxml"));
        Parent root = loader.load();

        // Get the controller of HomePage and set the customer
       

        Stage stage = (Stage) ((Node) event.getSource()).getScene().getWindow();
        Scene scene = new Scene(root);
        stage.setScene(scene);
        stage.show();

    }
    @FXML
    void onBtnClick(ActionEvent event)  throws Exception{
        int t;
        if(tfUserName.getText().trim().isEmpty()){
            tfUserName.setPromptText("Invalid");
            return;
        }
        if(tfPassword.getText().trim().isEmpty()){
            tfPassword.setPromptText("Invalid");
            return;
        }
        if(Tyoe.getValue()==null){
            Tyoe.setPromptText("Invalid");
            return;
        }
        if(Tyoe.getValue().equals("Customer")){t=0;}
        else if(Tyoe.getValue().equals("Admin")){t=1;}
        else {t=2;}

        int i=LogIn.login(tfUserName.getText(),tfPassword.getText(),t);
        if(i==-1)
        {
            tfUserName.clear();
            tfUserName.setPromptText("Wrong username");
            tfPassword.clear();
            tfPassword.setPromptText("Wrong password");
        }
        else if(t==0){
            if(i==-2)
            {
                tfUserName.setPromptText("YOU ARE BANNED");
            }
    else{
        SessionManager.setCustomer(Database.Customers.get(i));

        FXMLLoader loader = new FXMLLoader(getClass().getResource("/viewProducts.fxml"));
        Parent root = loader.load();

        Stage stage = (Stage) ((Node) event.getSource()).getScene().getWindow();
        Scene scene = new Scene(root);
        stage.setScene(scene);
        stage.show();
            }
        }
        else if(t==1){
            SessionManager.setCurrentAdmin(Database.Admins.get(i));
            
            
            FXMLLoader loader = new FXMLLoader(getClass().getResource("/Adminviews.fxml"));
            AnchorPane root = loader.load();
            // MainController myMainController=loader.getController() ;
            // myMainController.setCurrentUser(currentUser);
            // myMainController.populatefields();

            // Get the current stage
            Stage currentStage = (Stage) ((Button) event.getSource()).getScene().getWindow();
            currentStage.setScene(new Scene(root));
        }
        else
        {
            SessionManager.setCurrentSupplier(Database.suppliers.get(i));
            FXMLLoader loader = new FXMLLoader(getClass().getResource("/viewSupplierProducts.fxml"));
            AnchorPane root = loader.load();
            Stage currentStage = (Stage) ((Button) event.getSource()).getScene().getWindow();
            currentStage.setScene(new Scene(root));
        }


        

    }

}
