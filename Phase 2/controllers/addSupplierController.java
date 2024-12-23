package controllers;
import java.io.IOException;
import java.util.function.Supplier;

import Classes.*;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;  // Required for @FXML annotations
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

public class addSupplierController {

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
    private PasswordField password;

    @FXML
    private Label sTitle;

    @FXML
    private TextField username;

    @FXML
    void createSupplier(ActionEvent event) throws IOException {
        if(username.getText().trim().isEmpty() || password.getText().trim().isEmpty())
        {
            username.setPromptText("Invalid");
            password.setPromptText("Invalid");
        }
        else{
        Database.suppliers.add(new Classes.Supplier(username.getText(), password.getText()));
        FXMLLoader loader = new FXMLLoader(getClass().getResource("/Adminviews.fxml"));
            AnchorPane root = loader.load();
            // MainController myMainController=loader.getController() ;
            // myMainController.setCurrentUser(currentUser);
            // myMainController.populatefields();

            // Get the current stage
            Stage currentStage = (Stage) ((Button) event.getSource()).getScene().getWindow();
            currentStage.setScene(new Scene(root));

        }
    }
     @FXML
    void handleBackButton(ActionEvent event) {
        try{
            Parent root = FXMLLoader.load(getClass().getResource("/Adminviews.fxml"));
            Stage stage = (Stage)((Node)event.getSource()).getScene().getWindow();
            Scene scene = new Scene(root);
            stage.setScene(scene);
            stage.show();
        }catch (IOException e){
            e.getStackTrace();
        }
    }

}


