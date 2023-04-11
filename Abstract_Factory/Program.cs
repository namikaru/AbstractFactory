using System;
using AbstractFactory;


// Clasă de test
public class InsuranceTest
{
    public static void Main()
    {
        // Creare fabrica pentru polițele RCA
        InsuranceFactory rcaFactory = new RCAInsuranceFactory();

        // Creare obiect care gestionează polițele RCA
        IInsurancePolicyHandler rcaPolicyHandler = rcaFactory.CreatePolicyHandler();

        // Adăugare poliță RCA
        rcaPolicyHandler.AddPolicy("1234", "Ion Popescu", "Volkswagen Golf");

        // Creare fabrica pentru polițele CASCO
        InsuranceFactory cascoFactory = new CASCOInsuranceFactory();

        // Creare obiect care gestionează polițele CASCO
        IInsurancePolicyHandler cascoPolicyHandler = cascoFactory.CreatePolicyHandler();

        // Adăugare poliță CASCO
        cascoPolicyHandler.AddPolicy("5678", "Maria Ionescu", "BMW X5");
    }
}

