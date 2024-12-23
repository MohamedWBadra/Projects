package controllers;
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
import javafx.stage.Stage;

import java.io.IOException;

public class SignupController {

    @FXML
    private Button SignupButton;

    @FXML
    private TextField tfAddress;

    @FXML
    private PasswordField tfConfirmPassword;

    @FXML
    private TextField tfDays;

    @FXML
    private TextField tfMonths;

    @FXML
    private PasswordField tfPassword;

    @FXML
    private TextField tfUsername;

    @FXML
    private TextField tfYears;
    @FXML
private ComboBox<String> genderComboBox;


public void initialize() {
    genderComboBox.setItems(FXCollections.observableArrayList("Male", "Female"));
 
}


    @FXML
    void onButtonClick(ActionEvent event) {
        if(tfUsername.getText().trim().isEmpty() ||tfAddress.getText().trim().isEmpty() || tfConfirmPassword.getText().trim().isEmpty() || tfDays.getText().trim().isEmpty() || tfMonths.getText().trim().isEmpty() || tfPassword.getText().trim().isEmpty() || tfYears.getText().trim().isEmpty() || genderComboBox.getValue().isEmpty())
        {
            tfAddress.clear();
            tfAddress.setPromptText("Invalid");
            tfConfirmPassword.clear();
            tfConfirmPassword.setPromptText("Invalid");
            tfDays.clear();
            tfDays.setPromptText("Invalid");
            tfMonths.clear();
            tfMonths.setPromptText("Invalid");
            tfPassword.clear();
            tfPassword.setPromptText("Invalid");
            tfUsername.clear();
            tfUsername.setPromptText("Invalid");
            tfYears.clear();
            tfYears.setPromptText("Invalid");
        }
        else{
            try{
                Integer.parseInt(tfDays.getText());
                
            }
            catch(NumberFormatException e){
                tfDays.clear();
                tfDays.setPromptText("Enter a valid Day");
                return;
            }
            try{
                
                Integer.parseInt(tfMonths.getText());
                
            }
            catch(NumberFormatException e){
                tfMonths.clear();
                tfMonths.setPromptText("Enter a valid Month");
                return;
            }
            try{
                
                Integer.parseInt(tfYears.getText());
                
            }
            catch(NumberFormatException e){
                tfYears.clear();
                tfYears.setPromptText("Enter a valid Year");
                return;
            }
            if(Integer.valueOf(tfDays.getText())<0 || Integer.valueOf(tfDays.getText())>31 || Integer.valueOf(tfMonths.getText())<0 || Integer.valueOf(tfMonths.getText())>12 || Integer.valueOf(tfYears.getText())<1900 || Integer.valueOf(tfYears.getText())>2012){
               
                tfDays.clear();
                tfDays.setPromptText("Invalid Birthday");
                tfMonths.clear();
                tfMonths.setPromptText("Invalid Birthday");
                tfYears.clear();
                tfYears.setPromptText("Invalid Birthday");
            }
            else{
        try{
            SignUp.signup(tfUsername.getText(),tfPassword.getText(),Integer.valueOf((tfYears.getText())),Integer.valueOf((tfMonths.getText())),Integer.valueOf((tfDays.getText())),tfAddress.getText(),tfConfirmPassword.getText(),genderComboBox.getValue());
           SessionManager.setCustomer(Database.Customers.get(Database.Customers.size()-1));
            Parent root = FXMLLoader.load(getClass().getResource("/viewProducts.fxml"));
            Stage stage = (Stage)((Node)event.getSource()).getScene().getWindow();
            Scene scene = new Scene(root);
            stage.setScene(scene);
            stage.show();
        }catch (IOException e){
            e.getStackTrace();
        }

    }
}
}
}