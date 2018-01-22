using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Entities;

namespace IO
{
    public class DBConnections : DBFunctions
    {
        public DBConnections()
        {
            ConnectionString = "Server=10.205.44.39,49172;Database=CompanyDB;User Id=Aspit;Password=Server2012;";
        }

        public DataTable DTGetAllInfo()
        {
            //string query = "SELECT TOP (100) PERCENT Id, FirstName, LastName, TitleOfCourtesy, Title, HireDate, Sex, EmployeeId, Position, IsHourlyPaid FROM Employees ORDER BY FirstName";
            string query = "SELECT Employees.Id, Employees.FirstName, Employees.LastName, Employees.TitleOfCourtesy, Employees.Title, Employees.HireDate, Employees.Sex, Employees.IsHourlyPaid, EmployeePosition.Position FROM Employees RIGHT OUTER JOIN EmployeePosition ON Employees.PositionId = EmployeePosition.Id  ORDER BY FirstName";
            return DbReturnDataTable(query);
        }
        public DataTable DTGetAllPositons()
        {
            string query = "SELECT * From EmployeePosition";
            return DbReturnDataTable(query);
        }
        public void insert(Employee employee)
        {
            string query = $"INSERT INTO Employees (FirstName, LastName, TitleOfCourtesy, Title, HireDate, Sex, IsHourlyPaid, EmployeePosition.Position) VALUES " +
                $"({employee.FirstName},{employee.LastName},{employee.TitleOfCourtesy},{employee.Title},{employee.HireDate.ToString()},{employee.Sex}, {employee.IsHourlyPaided},{employee.Position})";
        }
    }
}
