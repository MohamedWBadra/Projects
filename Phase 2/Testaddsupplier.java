
import Classes.*;
import javafx.application.Application;
import javafx.fxml.FXMLLoader;
import javafx.scene.Scene;
import javafx.scene.layout.AnchorPane;
import javafx.scene.layout.BorderPane;
import javafx.stage.Stage;

public class Testaddsupplier extends Application {

    @Override
    public void start(Stage primaryStage) throws Exception {
        // Load the FXML file
        Database.suppliers.get(0).addproduct(new Products("iphone", 1500, "mobiles", 2));
        Database.suppliers.get(0).addproduct(new Products("vostro", 20000, "laptops", 1));
        
       FXMLLoader loader = new FXMLLoader(getClass().getResource("LogIn.fxml")); // Update path if necessary
        BorderPane root = loader.load();
        primaryStage.setTitle("My JavaFX Application");
        Scene scene = new Scene(root);
        primaryStage.setScene(scene);
        primaryStage.show();
    }

    public static void main(String[] args) {
        launch(args);
    }
}
