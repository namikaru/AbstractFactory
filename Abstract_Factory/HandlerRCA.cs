using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory;

namespace AbstractFactory
{
    // Obiect care gestionează polițele de asigurare RCA
    public class RCAPolicyHandler : IInsurancePolicyHandler
    {
        public void AddPolicy(string policyNumber, string driverName, string carModel)
        {
            Console.WriteLine($"Am adăugat polita RCA cu numărul {policyNumber} pentru soferul {driverName} si masina {carModel}");
        }
    }
}
