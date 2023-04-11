using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory;


namespace AbstractFactory
{
    // Implementare a fabricii pentru polițele de asigurare RCA
    public class RCAInsuranceFactory : InsuranceFactory
    {
        public override IInsurancePolicyHandler CreatePolicyHandler()
        {
            return new RCAPolicyHandler();
        }
    }
}
