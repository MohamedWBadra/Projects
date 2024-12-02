class CreditCard {
    private int card_number;//16
    private int cvv;//3

    public CreditCard(int card_number, int cvv) {
        setCard_number(card_number);//add expiry date
        set_cvv(cvv);

    }
//    public CreditCard() {
//        card_number = 0;
//        cvv = 0;
//    }
    public int getCard_number () {
        return card_number;
    }
    public int getCvv () {
        return cvv;
    }
    public void setCard_number ( int card_number){

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
    public String displayCardInfo () {
        String out=String.valueOf(card_number);
        return "Card number : **** **** **** " + out.substring(12)+ " \n cvv : ***";

    }

}