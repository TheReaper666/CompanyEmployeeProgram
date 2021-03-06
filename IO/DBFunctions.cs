﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace IO
{
    public class DBFunctions
    {
        private SqlConnection myConnection;
        private string _ConnectionString;
        public DBFunctions() { }

        protected string ConnectionString
        {
            get
            {
                return _ConnectionString;
            }
            set
            {
                if (value != ConnectionString)
                { 
                    _ConnectionString = value;
                    myConnection = new SqlConnection(_ConnectionString);
                }
            }
        }

        private void OpenDB()
        {
            try
            {
                if (myConnection != null && myConnection.State == ConnectionState.Closed)
                {
                    myConnection.Open();
                }
                else
                {
                    if (myConnection == null)
                    {
                        MessageBox.Show("Der er ikke angivet nogen, eller\nder er fejl i den angivne 'ConnectionString'");
                    }
                    else
                    {
                        CloseDB();
                        OpenDB();
                    }
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        private void CloseDB()
        {
            try
            {
                myConnection.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        protected DataTable DbReturnDataTable(string strSql)
        {
            DataTable dtRes = new DataTable();
            try
            {
                OpenDB();
                using (SqlCommand command = new SqlCommand(strSql, myConnection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(dtRes);
                }
                CloseDB();
            }
            catch (SqlException ex)
            {

                throw ex;
            }
            return dtRes;
        }
        protected void FunctionExecuteNonQuery(string strSql)
        {
            try
            {
                OpenDB();
                using (SqlCommand cmd = new SqlCommand(strSql, myConnection))
                {
                    cmd.ExecuteNonQuery();
                }
                CloseDB();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
