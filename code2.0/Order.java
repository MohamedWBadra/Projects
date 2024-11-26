public class Order {
    Cart orderCart;

    String[] payment={"balance"/* ,"Card"*/,"cash"};

    String PaymentMethod;

    Order(String PaymentMethod){
        PaymentMethod = PaymentMethod.toLowerCase();
        for(int i = 0; i < payment.length; i++){
            if(payment[i].equals(PaymentMethod)){
                this.PaymentMethod = PaymentMethod;
                break;
            }
        }
        orderCart = new Cart();
    }

    //el function dyh 3amltha 3a4an trg3 el total 3omomn wa 7war el balance aw cash 5aleto yb2a 3nd el customer be if
    //Momken nb2a n4of lw n3delha sena aw 7aga aw nzbot el functions ely t7t bs ana 7ases en mlhom4 lazma aw y3ny my2dro4 y3ml 7aga talama m4 by3mlo access le el customer
    public double Payment(){
        orderCart.CalcTotalPrice();
        return orderCart.getTotalPrice();
    }

    /*
    public double balancemethod(){
    }

    //public void cardmethod() {}

    public double cashmethod(){

    }
*/

}