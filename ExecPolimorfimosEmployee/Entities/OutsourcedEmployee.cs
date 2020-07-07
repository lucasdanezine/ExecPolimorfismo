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

        public OutsourcedEmployee(string name, int hours, double valuePerHour) : base(name, hours, valuePerHour)
        {
        }

        public sealed override double Payament()
        {
            double salary = ValuePerHour*Hours;

            salary += (AdditionalCharge * 1.10);

            return salary;
        }
    }
}
