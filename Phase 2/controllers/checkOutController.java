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
import javafx.scene.control.Label;
import javafx.scene.control.TextField;
import javafx.scene.image.ImageView;
import javafx.scene.layout.AnchorPane;
import javafx.stage.Stage;

public class checkOutController{
    @FXML
    private Label Title;

    @FXML
    private Button backButton;

    @FXML
    private Button balanceButton;

    @FXML
    private Button cardButton;

    @FXML
    private Button cashButton;

    @FXML
    private TextField code;

    @FXML
    private TextField cvv;

    @FXML
    private AnchorPane headerpane;

    @FXML
    private TextField id;

    @FXML
    private ImageView logo;
    @FXML
    private Label paid;
    @FXML
    private AnchorPane viewpane;
    private Customer myCustomer=SessionManager.getCustomer();
    public void initialize() {
        if(myCustomer.getOrder().getPaymentMethod().equals("card"))
        {
            id.setText(myCustomer.getCredit_card().displayCardNumber());
            cvv.setText(myCustomer.getCredit_card().displayCardCVV());
        }
        code.setPromptText("your balance: $"+myCustomer.getBalance());
        
    }


    @FXML
    void handleBackButton(ActionEvent event) {
        try{
            Parent root = FXMLLoader.load(getClass().getResource("/viewCart.fxml"));
            Stage stage = (Stage)((Node)event.getSource()).getScene().getWindow();
            Scene scene = new Scene(root);
            stage.setScene(scene);
            stage.show();
        }catch (IOException e){
            e.getStackTrace();
        }
    }

    @FXML
    void payByBalance(ActionEvent event) {
        if(Database.balanceCodes.contains(code.getText()))
        {
            myCustomer.setBalance(code.getText());
        }
        if(myCustomer.getBalance()<myCustomer.getOrder().getTotalprice())
        {
            code.setPromptText("your balance: $"+myCustomer.getBalance()+" is not enough");
        }
        else{
            myCustomer.getOrder().setPaymentMethod("balance");
            myCustomer.setBalanceValue(myCustomer.getBalance()- myCustomer.getOrder().getTotalprice());
            code.clear();
            code.setPromptText("your balance: $"+myCustomer.getBalance());
            Database.Orders.add(myCustomer.getOrder());
            for(int i=0;i<myCustomer.getOrder().getOrderCart().size();i++)
            {
                myCustomer.getInterests().add(myCustomer.getOrder().getOrderCart().get(i).getMyCategory());
            }
            myCustomer.resetorder();
            // try {
            //     // Wait for 5 seconds (5000 milliseconds)
            //     Thread.sleep(8000);
            // } catch (InterruptedException e) {
            //     System.err.println("Thread was interrupted!");
            // }
            try{
                Parent root = FXMLLoader.load(getClass().getResource("/placeOrder.fxml"));
                Stage stage = (Stage)((Node)event.getSource()).getScene().getWindow();
                Scene scene = new Scene(root);
                stage.setScene(scene);
                stage.show();
            }catch (IOException e){
                e.getStackTrace();
            }
        }


     }


    

    @FXML
    void payByCard(ActionEvent event) {
        
        try{
            
            Long.parseLong(id.getText());
            
        }
        catch(NumberFormatException e){
            id.clear();
            return;
        }
        try{
            
            Integer.parseInt(cvv.getText());
            
        }
        catch(NumberFormatException e){
            cvv.clear();
            return;
        }

        if(id.getText().length()==16 && cvv.getText().length()==3)
        {
            myCustomer.getOrder().setPaymentMethod("card");
            myCustomer.setCredit_card(Long.valueOf(id.getText()), Integer.valueOf(cvv.getText()));
            Database.Orders.add(myCustomer.getOrder());
            for(int i=0;i<myCustomer.getOrder().getOrderCart().size();i++)
            {
                myCustomer.getInterests().add(myCustomer.getOrder().getOrderCart().get(i).getMyCategory());
            }
            myCustomer.resetorder();
            // try {
            //     // Wait for 5 seconds (5000 milliseconds)
            //     Thread.sleep(8000);
            // } catch (InterruptedException e) {
            //     System.err.println("Thread was interrupted!");
            // }

            try{
                Parent root = FXMLLoader.load(getClass().getResource("/placeOrder.fxml"));
                Stage stage = (Stage)((Node)event.getSource()).getScene().getWindow();
                Scene scene = new Scene(root);
                stage.setScene(scene);
                stage.show();
            }catch (IOException e){
                e.getStackTrace();
            }
        }
        else{
            id.setText("Invalid");
            cvv.setText("Invalid");

        }

        }



    

    @FXML
    void payByCash(ActionEvent event) {
        myCustomer.getOrder().setPaymentMethod("cash");
        Database.Orders.add(myCustomer.getOrder());
        for(int i=0;i<myCustomer.getOrder().getOrderCart().size();i++)
        {
            myCustomer.getInterests().add(myCustomer.getOrder().getOrderCart().get(i).getMyCategory());
        }
            myCustomer.resetorder();
        // try {
        //     // Wait for 5 seconds (5000 milliseconds)
        //     Thread.sleep(8000);
        // } catch (InterruptedException e) {
        //     System.err.println("Thread was interrupted!");
        // }
        try{
            Parent root = FXMLLoader.load(getClass().getResource("/placeOrder.fxml"));
            Stage stage = (Stage)((Node)event.getSource()).getScene().getWindow();
            Scene scene = new Scene(root);
            stage.setScene(scene);
            stage.show();
        }catch (IOException e){
            e.getStackTrace();
        }

}
}
