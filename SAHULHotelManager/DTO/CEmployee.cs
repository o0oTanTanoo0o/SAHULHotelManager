using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAHULHotelManager.DTO
{
    public class CEmployee : CPerson
    {
        #region "Attributes"
        private int _id;
        private DateTime _hireDate;
        private int _positionId;
        private int _departmentId;
        private double _basicSalary;
        private float _ratio;
        private int _status;
        private DateTime __hireDate;
        private int v1;
        private int v2;
        private int v3;
        private int v4;
        private float v5;
        private int v6;

        #endregion

        #region "Constructor"
        public CEmployee() : base()
        {
            this._id = 0;
            this._hireDate = new DateTime(0000, 0, 0);
            this._positionId = 0;
            this._departmentId = 0;
            this._basicSalary = 0;
            this._ratio = 0;
            this._status = 0;
        }
        /// <summary>
        /// Name, Age, dob, idcard, address, phone, folk

        public CEmployee(string name, int sex, DateTime doB, string idCard, string address, string phone, string folk, 
                         int id, DateTime hireDate, int positionId, int departmentId, double basicSalary, float ratio, int status) 
                         : base(name, sex, doB, idCard, address, phone, folk)
        {
            this._id = id;
            this._hireDate = hireDate;
            this._positionId = positionId;
            this._departmentId = departmentId;
            this._basicSalary = basicSalary;
            this._ratio = ratio;
            this._status = status;
        }

        public CEmployee(int v1, int v2, int v3, int v4, float v5, int v6)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
            this.v5 = v5;
            this.v6 = v6;
        }
        #endregion


        #region "propeties"
        public new string ToString
        {

            get
            {
                return this.ShowInFors();
            }

        }
       
        public int Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }


        public DateTime HireDate
        {
            get
            {
                return __hireDate;
            }

            set
            {
                __hireDate = value;
            }
        }

        public string HireDatetodate
        {
            get
            {
                return this.HireDate.Day + "/" + this.HireDate.Month + "/" + this.HireDate.Year;
            }
        }

        public string HireDateInVietnamese
        {
            get
            {
                return "Ngày " + this.HireDate.Day + " tháng " + this.HireDate.Month + " năm " + this.HireDate.Year;
            }
        }
        public int Positionid
        {
            get
            {
                return _positionId;

            }
            set
            {

                _positionId = value;
            }
        }


        public double BasicSalary
        {
            get
            {
                return _basicSalary;
            }

            set
            {
                _basicSalary = value;

            }
        }

        
        public float Ratio
        {
            get
            {
                return _ratio;

            }

            set
            {
                _ratio = value;

            }
        }

        public int status
        {
            get
            {
                return _status;
            }

            set
            {
                _status = value;
            }
        }
        #endregion

        #region "Methods"
        public string ShowInFors()
        {
            return ""
                + "Id: " + this._id + '\n'
                + "Hire date: " + this._hireDate + '\n'
                + "Position Id: " + this._positionId + '\n'
                + "Department Id: " + this._departmentId + '\n'
                + "Basic salary: " + this._basicSalary + '\n'
                + "Ratio: " + this._ratio + '\n'
                + "Status: " + this._status + '\n'
                + base.ShowInfors();
        }


        public List<CEmployee> GenerateObjects()
        {
            

            List<CEmployee> Employee = new List<CEmployee>();
            Employee.Add(new CEmployee(1, 2016/1/1, 1, 100,1f,1));
            Employee.Add(new CEmployee(1, 2016/2/1, 1, 100, 1f, 2));
            Employee.Add(new CEmployee(1, 2016/3/1, 1, 100, 1f, 3));
            Employee.Add(new CEmployee(1, 2016/4/1, 1, 100, 1f, 4));
            Employee.Add(new CEmployee(1, 2016/5/1, 1, 100, 1f, 5));
            Employee.Add(new CEmployee(1, 2016/6/1, 1, 100, 1f, 6));
            Employee.Add(new CEmployee(1, 2016/7/1, 1, 100, 1f, 7));
            Employee.Add(new CEmployee(1, 2016/8/1, 1, 100, 1f, 8));
            Employee.Add(new CEmployee(1, 2016/9/1, 1, 100, 1f, 9));
            Employee.Add(new CEmployee(1, 2016/10/1, 1, 100, 1f, 10));
            return Employee;

        }
        #endregion
    }
}
