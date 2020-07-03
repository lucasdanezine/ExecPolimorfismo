using System;
using System.Collections.Generic;
using System.Text;

namespace ExecPolimorfimosEmployee.Entities
{
    class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourcedEmployee()
        {
        }

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge) : base (name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public sealed override double Payament()
        {
            double salary = base.Payament();

            salary += ((AdditionalCharge * 1.10) + AdditionalCharge);

            return salary;
        }
    }
}
