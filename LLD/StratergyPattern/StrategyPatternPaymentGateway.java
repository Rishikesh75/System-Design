package stratergypattern;
interface PaymentMethod {
    void pay(double amount);
}

class CreditCardPayment implements PaymentMethod {
    @Override
    public void pay(double amount) {
        System.out.printf("Paying ₹%.2f using Credit Card\n", amount);
    }
}

class UPIPayment implements PaymentMethod {
    @Override
    public void pay(double amount) {
        System.out.printf("Paying ₹%.2f using UPI\n", amount);
    }
}

class PaymentContext {
    private PaymentMethod paymentMethod;

    public PaymentContext(PaymentMethod paymentMethod) {
        this.paymentMethod = paymentMethod;
    }

    public void payAmount(double amount) {
        paymentMethod.pay(amount);
    }
}

public class StrategyPatternPaymentGateway {
    public static void main(String[] args) {
        PaymentContext context = new PaymentContext(new CreditCardPayment());
        context.payAmount(1500.00);

        context = new PaymentContext(new UPIPayment());
        context.payAmount(750.00);
    }
}
