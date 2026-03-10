///породжувальні Prototype
///структурні Bridge
///поведінкові Observer
using Patterns.Bridge;
using Patterns.Observer;
using Patterns.Prototype;
using System;

class Program
{
    static void Pattern()
    {
        Character original = new Character("Invoker", 100);

        Character clone = original.Clone();
        clone.Name = "Invoker's Illusion";

        original.Print();
        clone.Print();
    }

    static void Bridge()
    {
        IMessageSender emailSender = new EmailSender();
        IMessageSender smsSender = new SmsSender();

        Message urgentEmail = new UrgentMessage(emailSender);
        Message normalSms = new NormalMessage(smsSender);

        urgentEmail.Send("Server is down !");
        normalSms.Send("Daily report sent.");
    }

    static void Observer () 
    {
        PhoneDisplay phone = new PhoneDisplay();
        ComputerDisplay computer = new ComputerDisplay();
        
        WeatherStation station = new WeatherStation();
        station.Attach(phone);
        station.Attach(computer);
        station.SetTemperature(10);
        station.Notify();
    }
    static void Main ()
    {
        Pattern();
        Console.WriteLine();
        Bridge();
        Console.WriteLine();
        Observer();
    }
}