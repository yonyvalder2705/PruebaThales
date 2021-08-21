using CDatos;
using CModelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using utilities;

namespace CNegocio
{
    public class NEmploy : INEmploy
    {
        Calculations objCalculations = new Calculations();
        IDEmploy dEmploy = new DEmploy();

        public List<EmployModel> ListEmploy()
        {    
            var LstEmploy = dEmploy.ListEmploy();

            foreach(var item in LstEmploy)
            {
                item.Employee_anual_salary = objCalculations.CalculateSalaryAnual(item.employee_salary);
            }
            return LstEmploy;
        }

        public EmployModel EmployById(int id)
        {
            var employid = dEmploy.EmployById(id);
            employid.Employee_anual_salary = objCalculations.CalculateSalaryAnual(employid.employee_salary);
            return employid;
        }
    }
}
