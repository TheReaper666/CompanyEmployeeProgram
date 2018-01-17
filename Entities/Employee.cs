using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Employee
    {
        private int _Id;
        private string _FirstName;
        private string _LastName;
        private string _TitleOfCourtesy;
        private string _Title;
        private string _Position;
        private bool _IsHourlyPaided;
        private int _EmployeeId;
        private DateTime _HireDate;
        private string _Sex;

        public Employee(int Id, string FirstName, string LastName, string TitleOfCourtesy, string Title, string Position, bool IsHourlyPaided, int EmployeeId, DateTime HireDate, string Sex)
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.TitleOfCourtesy = TitleOfCourtesy;
            this.Title = Title;
            this.Position = Position;
            this.IsHourlyPaided = IsHourlyPaided;
            this.EmployeeId = EmployeeId;
            this.HireDate = HireDate;
            this.Sex = Sex;
        }

        public int Id
        {
            get
            {
                return _Id;
            }
            set
            {
                _Id = value;
            }
        }
        public string FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                _FirstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                _LastName = value;
            }
        }
        public string TitleOfCourtesy
        {
            get
            {
                return _TitleOfCourtesy;
            }
            set
            {
                _TitleOfCourtesy = value;
            }
        }
        public string Title
        {
            get
            {
                return _Title;
            }
            set
            {
                _Title = value;
            }
        }
        public string Position
        {
            get
            {
                return _Position;
            }
            set
            {
                _Position = value;
            }
        }
        public bool IsHourlyPaided
        {
            get
            {
                return _IsHourlyPaided;
            }
            set
            {
                _IsHourlyPaided = value;
            }
        }
        public int EmployeeId
        {
            get
            {
                return _EmployeeId;
            }
            set
            {
                _EmployeeId = value;
            }
        }
        public DateTime HireDate
        {
            get
            {
                return _HireDate;
            }
            set
            {
                _HireDate = value;
            }
        }
        public string Sex
        {
            get
            {
                return _Sex;
            }
            set
            {
                _Sex = value;
            }
        }
    }
}
