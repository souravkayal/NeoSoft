using Neosoft_Application_Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace NeoSoft_Application_DataAccess
{
    public class AppCrudDataDataAccess
    {
        public AppCrudDataDataAccess()
        {

        }
        
        public List<EmployeeMaster> GetEmployees(int CountryId , int StateId , int CityId)
        {
            List<EmployeeMaster> employees = new List<EmployeeMaster>();

            AdoHelper adoHelper = new AdoHelper();

            var par = new List<Object>();
            par.Add("CountryId");
            par.Add(CountryId);

            par.Add("StateId");
            par.Add(StateId);

            par.Add("CityId");
            par.Add(CityId);


            var employeeSet = adoHelper.ExecDataSetProc ("stp_employee_get_mployees", par);

            if (employeeSet.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in employeeSet.Tables[0].Rows)
                {
                    employees.Add(new EmployeeMaster
                    {
                        //READ ALL OTHER COLUMN HERE
                        Row_Id = Convert.ToInt32(row["Row_Id"]),


                    });
                }
            }

            return employees;
        }

    }
}
