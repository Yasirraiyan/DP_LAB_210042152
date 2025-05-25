Strategy Pattern ব্যবহার করে আমরা payment করার behavior-টি runtime এ change করতে পারি। এখানে আমরা তিনটি আলাদা আলাদা পেমেন্ট সিস্টেম (CreditCard, Paypal, Crypto) ব্যবহার করছি, যেগুলা একেকটা আলাদা Strategy হিসেবে কাজ করছে। এখন নিচে পুরো কোডটা line-by-line Bangla ভাষায় ব্যাখ্যা করছি:

🔷 Interface Definition: IPaymentStrategy
csharp
Copy
Edit
public interface IPaymentStrategy
{
    void pay(int amount);
}
🟢 ব্যাখ্যা:

এটা একটা interface যেখানে pay নামে একটা method আছে যেটা int amount নিবে।

সব ধরনের পেমেন্ট ক্লাস (CreditCard, Paypal, Crypto) এই ইন্টারফেস implement করবে।

Strategy Pattern-এ আমরা একটা common interface ব্যবহার করে multiple strategy define করি।

🔷 Concrete Strategy 1: CreditCard
csharp
Copy
Edit
public class CreditCard : IPaymentStrategy
{
    public int cardno;
    public CreditCard(int cardno)
    {
        this.cardno = cardno;
    }

    public void pay(int amount)
    {
        Console.WriteLine($"Paid by CC the card no:{cardno}");
    }
}
🟢 ব্যাখ্যা:

CreditCard ক্লাস IPaymentStrategy implement করছে মানে এটা একটা পেমেন্ট স্ট্র্যাটেজি।

cardno হচ্ছে card number যা constructor দিয়ে নেয়া হয়।

pay method-এ কনসোলে card number সহ পেমেন্টের মেসেজ দেখায়।

🔷 Concrete Strategy 2: Crypto
csharp
Copy
Edit
public class Crypto : IPaymentStrategy
{
    public string phn;
    public Crypto(string phn)
    {
        this.phn = phn;
    }

    public void pay(int amount)
    {
        Console.WriteLine($"Paid by crypto for the card:{phn}");
    }
}
🟢 ব্যাখ্যা:

এটাও IPaymentStrategy implement করছে, মানে এটা দ্বিতীয় strategy।

পেমেন্ট মোবাইল নাম্বার দিয়ে হচ্ছে, যেটা constructor দিয়ে নেয়া হয়।

pay method মেসেজ আউটপুট দেয়।

🔷 Concrete Strategy 3: Paypal
csharp
Copy
Edit
public class Paypal : IPaymentStrategy
{
    public string email;
    public Paypal(string email)
    {
        this.email = email;
    }

    public void pay(int amount)
    {
        Console.WriteLine($"Paying {amount} using PayPal account {email}");
    }
}
🟢 ব্যাখ্যা:

Paypal-ও একটা পেমেন্ট স্ট্র্যাটেজি (Strategy 3) হিসেবে কাজ করছে।

Email দিয়ে constructor-এ একাউন্ট সেট করা হয়।

pay method amount ও email সহ মেসেজ আউটপুট দেয়।

🔷 Context Class
csharp
Copy
Edit
public class Context
{
    IPaymentStrategy _strategy;

    public void setpaymentstrategy(IPaymentStrategy strategy)
    {
        _strategy = strategy;
    }

    public void payamount(int amount)
    {
        if (_strategy == null)
        {
            Console.WriteLine("Not paying amount");
        }
        else
        {
            _strategy.pay(amount);
        }
    }
}
🟢 ব্যাখ্যা:

Context ক্লাসটা Strategy Pattern-এর মূল অংশ।

_strategy হলো current payment strategy যেটা runtime এ set করা যাবে।

setpaymentstrategy() method দিয়ে আমরা যে কোন strategy (Paypal, Crypto, etc.) inject করতে পারি।

payamount() method চেক করে কোনো strategy সেট করা আছে কি না। থাকলে সেই স্ট্র্যাটেজি অনুযায়ী পেমেন্ট করে।

🔷 Main Method
csharp
Copy
Edit
class Program
{
    public static void Main(string[] args)
    {
        Context c1 = new Context();

        c1.setpaymentstrategy(new CreditCard(123));
        c1.payamount(1000); // CreditCard দিয়ে পেমেন্ট

        c1.setpaymentstrategy(new Paypal("yasir 123 @ yahoo.com"));
        c1.payamount(500); // Paypal দিয়ে পেমেন্ট

        c1.setpaymentstrategy(new Crypto("01407841543"));
        c1.payamount(300); // Crypto দিয়ে পেমেন্ট
    }
}
🟢 ব্যাখ্যা:

Context object c1 বানানো হয়েছে।

প্রথমে credit card দিয়ে 1000 টাকা পেমেন্ট করা হয়েছে।

পরে Paypal সেট করে 500 টাকা পেমেন্ট।

আবার strategy change করে Crypto দিয়ে 300 টাকা পেমেন্ট করা হয়েছে।

এইভাবে runtime এ স্ট্র্যাটেজি পরিবর্তন করা হচ্ছে।

How Runtime Change:
-------------------
  অবশ্যই! আমরা এই কোডে Strategy Pattern ব্যবহার করে দেখিয়েছি কীভাবে runtime-এ algorithm (মানে, পেমেন্ট করার পদ্ধতি) পরিবর্তন করা যায়। এখন নিচে ধাপে ধাপে বুঝিয়ে বলছি রানটাইমে কোন অংশ পরিবর্তিত হয় এবং কীভাবে algorithm বা behavior পরিবর্তন হয়:

✅ মূল বিষয়: কীভাবে runtime-এ algorithm (payment behavior) পরিবর্তন হয়?
🔹 কোডের এই লাইনটি runtime-এ strategy বা algorithm change করে:
csharp
Copy
Edit
c1.setpaymentstrategy(new CreditCard(123));
🟢 ব্যাখ্যা:

এখানে Context ক্লাসের setpaymentstrategy() method কে আমরা একটা নতুন পেমেন্ট স্ট্র্যাটেজি (algorithm) দিয়ে দিচ্ছি — new CreditCard(123)।

মানে এখন থেকে Context object (c1) যেকোনো পেমেন্ট করলে সেটা ক্রেডিট কার্ড দিয়ে হবে।

🔹 আবার এই লাইনটি algorithm আবার change করে:
csharp
Copy
Edit
c1.setpaymentstrategy(new Paypal("yasir 123 @ yahoo.com"));
🟢 ব্যাখ্যা:

এখন algorithm (মানে strategy) Paypal হয়ে গেছে।

Context object c1 এখন যদি payamount() call করে, তাহলে পেমেন্ট Paypal দিয়ে হবে, CreditCard না।

🔹 তৃতীয়বার পরিবর্তন:
csharp
Copy
Edit
c1.setpaymentstrategy(new Crypto("01407841543"));
🟢 ব্যাখ্যা:

এবার strategy আবার পরিবর্তন হল — এখন পেমেন্ট হবে Crypto Currency দিয়ে।

📌 কীভাবে runtime-এ behavior বা algorithm change হচ্ছে?
Context ক্লাসের ভিতরে ↓
csharp
Copy
Edit
IPaymentStrategy _strategy;

public void setpaymentstrategy(IPaymentStrategy strategy)
{
    _strategy = strategy;
}
🟢 ব্যাখ্যা:

_strategy নামে একটা variable আছে যেটা interface টাইপের।

যখন আমরা setpaymentstrategy() call করি, তখন _strategy তে নতুন strategy object (CreditCard, Paypal, Crypto) assign হয়ে যায়।

এরপর যখনই payamount() call হয়, তখন _strategy.pay(amount) call হয় — আর সেটা এখন নতুন strategy অনুযায়ী কাজ করে।

📊 এক লাইনে বললে:
👉 Strategy Pattern আমাদের এই সুবিধা দেয় যে আমরা runtime-এ object-কে একটা behavior (algorithm) দিই এবং সেটা পরে আবার change করতে পারি, without modifying original class (Context class বদলাতে হয়নি)।

🔁 Runtime Changing Algorithm Summary:
কোড	কী পরিবর্তন হয়
setpaymentstrategy(new CreditCard(123));	পেমেন্ট algorithm হয় CreditCard
setpaymentstrategy(new Paypal(...));	algorithm হয় Paypal
setpaymentstrategy(new Crypto(...));	algorithm হয় Crypto

🎯 উপসংহার:
🔸 মূল algorithm (payment method) হচ্ছে pay() method।
🔸 আমরা যেকোনো সময় Context class-এ setpaymentstrategy() call করে algorithm/behavior runtime-এ পরিবর্তন করতে পারি।
🔸 এটাই হলো Strategy Pattern-এর মূল শক্তি।

