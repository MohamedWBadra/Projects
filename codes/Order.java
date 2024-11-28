public class Order {
    Cart orderCart;

    private String[] payment={"balance","Card","cash"};

    private String PaymentMethod;

    Order(){

        orderCart = new Cart();
    }

    //el function dyh 3amltha 3a4an trg3 el total 3omomn wa 7war el balance aw cash 5aleto yb2a 3nd el customer be if
    //Momken nb2a n4of lw n3delha sena aw 7aga aw nzbot el functions ely t7t bs ana 7ases en mlhom4 lazma aw y3ny 
    //my2dro4 y3ml 7aga talama m4 by3mlo access le el customer
    public float Payment(){
        return orderCart.getTotalprice();
    }

    public String getPaymentMethod() {
        return PaymentMethod;
    }

    public void setPaymentMethod(String p) {//lma class el card yet3emel hankhaleha takhod integer w tsearch fel array bta3 el payment   
        p = p.toLowerCase();
        for(int i = 0; i < payment.length; i++){
            if(payment[i].equals(PaymentMethod)){
                this.PaymentMethod = p;
                break;
            }
        }
    }

    
    // public double balancemethod(){}

     public void cardmethod(int ID,int code){
        //class card
        //check en el id sa7 wel code sa7
        //search fel cards 3ala el id
        
     }

    // public double cashmethod(){}


}