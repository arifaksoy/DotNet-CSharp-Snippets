using System.Diagnostics.Contracts;


var mobile = new MobileUI();
var web = new WebUI();

mobile.ApplyPlatformSpecificLogic();
mobile.StartPayment(PaymentType.Credit);
Console.WriteLine("mobile payment finished successfully");

web.ApplyPlatformSpecificLogic();
web.StartPayment(PaymentType.Credit);
Console.WriteLine("web payment finished successfully");


public enum PaymentType
{
    Credit,
    Paypal,
    Crypto
}
public interface IPayment
{
    void GetInfo();
    abstract void PaymentProcess();
}

public class CreditCardPayment : IPayment
{
    public void GetInfo()
    {
        Console.WriteLine("Credit Card info is gotten...");
    }

    public void PaymentProcess() 
    {
        Console.WriteLine("Credit Card payment is processing");
    }
}

public class PayPalPayment : IPayment
{
    public void GetInfo()
    {
        Console.WriteLine("paypal info is gotten...");
    }

    public void PaymentProcess()
    {
        Console.WriteLine("paypal payment is processing");
    }
}

public class CryptoPayment : IPayment
{
    public void GetInfo()
    {
        Console.WriteLine("Crypto info is gotten...");
    }

    public void PaymentProcess()
    {
        Console.WriteLine("Crypto payment is processing");
    }
}

public abstract class PaymentFactory
{
    public abstract IPayment CreatePayment(PaymentType paymentType);

    public abstract void ApplyPlatformSpecificLogic();

    public IPayment StartPayment(PaymentType paymentType)
    {
       IPayment payment = CreatePayment(paymentType);
        payment.GetInfo();
        payment.PaymentProcess();
        return payment;
    }
}

public class MobileUI : PaymentFactory
{
    public override IPayment CreatePayment(PaymentType paymentType)
    {
        switch (paymentType)
        {
            case PaymentType.Credit:
                return new CreditCardPayment();
            case PaymentType.Crypto: 
                return new CryptoPayment();
            case PaymentType.Paypal: 
                return new PayPalPayment();    
            default:
                throw new NotImplementedException();
        };
    }

    public override void ApplyPlatformSpecificLogic()
    {
        Console.WriteLine("Mobile verification code (OTP) is sent.");
    }
}

public class WebUI : PaymentFactory
{
    public override IPayment CreatePayment(PaymentType paymentType)
    {
        switch (paymentType)
        {
            case PaymentType.Credit:
                return new CreditCardPayment();
            case PaymentType.Crypto:
                return new CryptoPayment();
            case PaymentType.Paypal:
                return new PayPalPayment();
            default:
                throw new NotImplementedException();
        };
    }

    public override void ApplyPlatformSpecificLogic()
    {
        Console.WriteLine("Browser verification is applied.");
    }
}


