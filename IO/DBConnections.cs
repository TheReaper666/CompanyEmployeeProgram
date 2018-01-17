﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

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
            string query = "SELECT TOP (100) PERCENT Id, FirstName, LastName, TitleOfCourtesy, Title, HireDate, Sex, EmployeeId, Position, IsHourlyPaid FROM dbo.Employees ORDER BY FirstName";
            return DbReturnDataTable(query);
        }
    }

}