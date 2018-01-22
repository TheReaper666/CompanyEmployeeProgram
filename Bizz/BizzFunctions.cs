using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using IO;

namespace Bizz
{

    public class BizzFunctions
    {
        ObservableCollection<Employee> OCEmployees;
        List<string> EmployeePostions;
        DBConnections DBC;

        public BizzFunctions()
        {
            DBC = new DBConnections();
        }

        public ObservableCollection<Employee> GetAllEmployees()
        {
            DataTable dt = DBC.DTGetAllInfo();
            OCEmployees = new ObservableCollection<Employee>();
            DataTableReader reader = new DataTableReader(dt);
            while (reader.Read())
            {
                int Id = Convert.ToInt32(reader["Id"]);
                string FirstName = reader["FirstName"].ToString();
                string LastName = reader["LastName"].ToString();
                string TitleOfCourtesy = reader["TitleOfCourtesy"].ToString();
                string Title = reader["Title"].ToString();
                string Position = reader["Position"].ToString();
                bool IsHourlyPaided = Convert.ToBoolean(reader["IsHourlyPaid"]);
                DateTime HireDate = Convert.ToDateTime(reader["HireDate"]);
                string Sex = reader["Sex"].ToString();
                Employee Employer = new Employee(Id, FirstName, LastName, TitleOfCourtesy, Title, Position, IsHourlyPaided, HireDate, Sex);
                OCEmployees.Add(Employer);
            }
            return OCEmployees;
        }
        public void InsertIntoEmployees(Employee employer)
        {

        }
        public List<string> GetAllPostions()
        {
            DataTable dt = DBC.DTGetAllPositons();
            EmployeePostions = new List<string>();
            DataTableReader reader = new DataTableReader(dt);
            while (reader.Read())
            {
                string Postion = reader["Position"].ToString();
                EmployeePostions.Add(Postion);
            }
            return EmployeePostions;
        }
    }
}
