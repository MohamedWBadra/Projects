import java.util.Date;

abstract public class Person {
    protected String username;
    protected String password;
    protected Date date_of_birth;

    Person(String username, String password){
        this.username = username;
        this.password = password;
        date_of_birth = new Date();
    }


}
