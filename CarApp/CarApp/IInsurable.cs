using System;
using System.Collections.Generic;
using System.Text;

namespace CarApp
{
    public interface IInsurable
    {
        string RegistrationNumber { get; }
        double GetInsuranceRate();
    }
}
