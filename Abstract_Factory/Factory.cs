using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory;


namespace AbstractFactory
{
    // Fabrică abstractă pentru crearea obiectelor care gestionează polițele de asigurare auto
    public abstract class InsuranceFactory
    {
        public abstract IInsurancePolicyHandler CreatePolicyHandler();
    }
}
