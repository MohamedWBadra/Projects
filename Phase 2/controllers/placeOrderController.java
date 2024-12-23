package controllers;

import java.io.IOException;

import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.fxml.FXMLLoader;
import javafx.scene.Node;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.scene.control.Button;
import javafx.scene.control.Label;
import javafx.scene.image.ImageView;
import javafx.scene.layout.AnchorPane;
import javafx.stage.Stage;

public class placeOrderController {

    @FXML
    private Label Title;

    @FXML
    private Label Title1;

    @FXML
    private AnchorPane headerpane;

    @FXML
    private ImageView logo;

    @FXML
    private Button proceed;

    @FXML
    void proceed(ActionEvent event) {
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

}

