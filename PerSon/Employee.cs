using System;
using System.Collections.Generic;
using System.Text;

namespace Human
{
    class Employee : Person
    {
        //- SalaryOfHour (saatbaşı qazandığı maaş)
        //- WorkingHour(30 gün ərzində neçə saat işlədiyi)
        //- CalculateSalary() - Ümumi maaşı hesablayan method.
        //memberləri olur.

        
        public double SalaryOfHour { get; set; }
        
        public int WorkingHour { get; set; }
        

        public Person person { get; set; }
        
        public Employee(double SalaryOfHour, int WorkingHour):base()
        {
            this.SalaryOfHour = SalaryOfHour;
            this.WorkingHour = WorkingHour;
        }

        public Employee()  {}

        public string CalculateSalary(double  SalaryOfHour , int WorkingHour,int age)

        {
            if (age < 18) return "Sizin ishleme huququnuz yoxdur!";
            double TotalSalary = SalaryOfHour * WorkingHour;

           

            string text = $"Teyin etdiyiniz ayliq maash: {TotalSalary} azn-dir.";
            if (TotalSalary < 250) text += "\nAyliq maash 250-den ashagi olmamalidir.";

            if (WorkingHour / 22 > 8)
            {
                text = "Ayliq ortalama ish saati 8 saatdan artiq olmalaidir!!!";
            }

            return text;
        }
    }
}
