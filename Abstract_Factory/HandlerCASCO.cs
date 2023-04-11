using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory;

namespace AbstractFactory
{
    // Obiect care gestionează polițele de asigurare CASCO
    public class CASCOPolicyHandler : IInsurancePolicyHandler
    {
        public void AddPolicy(string policyNumber, string driverName, string carModel)
        {
            Console.WriteLine($"Am adăugat polita CASCO cu numărul {policyNumber} pentru soferul {driverName} si masina {carModel}");
        }
    }
}
