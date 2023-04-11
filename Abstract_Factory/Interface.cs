using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory;

namespace AbstractFactory
{
    // Interfață pentru obiectele care gestionează polițele de asigurare auto
    public interface IInsurancePolicyHandler
    {
        void AddPolicy(string policyNumber, string driverName, string carModel);
    }
}
