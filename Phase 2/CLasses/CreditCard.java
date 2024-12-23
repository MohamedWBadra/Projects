package Classes;
public class CreditCard {
    private long card_number=-1;//16
    private int cvv;//3

    public CreditCard(long card_number, int cvv) {
        setCard_number(card_number);//add expiry date
        set_cvv(cvv);

    }
//    public CreditCard() {
//        card_number = 0;
//        cvv = 0;
//    }
    public long getCard_number () {
        return card_number;
    }
    public int getCvv () {
        return cvv;
    }
    public void setCard_number ( long card_number){

            this.card_number = card_number;
//        }else {
//            System.out.println("Card number must be 16 digits exactly");
//        }
    }
    public void set_cvv ( int cvv){
            this.cvv = cvv;
//        else {
//            System.out.println("cvv can be 3 digits only");
//        }
    }
    public String displayCardNumber () {
        String out=String.valueOf(card_number);
        return "Card number : **** **** **** " + out.substring(12);

    }
    public String displayCardCVV () {
       
        return "  ***";

    }


}