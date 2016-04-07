using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAHULHotelManager.DTO
{
    public class CPerson
    {
        public enum PersonSex
        {
            Male=0,
            Female=1
        }

        #region "Attributes"
        private string _name;
        private int _sex;
        private DateTime _doB;
        private string _idCard;
        private string _address;
        private string _phone;
        private string _folk;
        private string v1;
        private int v2;
        private int v3;
        private string v4;
        private string v5;
        private string v6;
        private string v7;
        #endregion

        #region "Property"
        public new string ToString
        {
            get
            {
                return this.ShowInfors();
            }
        }

        public int Sex
        {
            get
            {
                return _sex;
            }

            set
            {
                if (value == 0 || value == 1)
                {
                    _sex = value;
                }
                else
                {
                    _sex = 0;
                }    
            }
        }
        public string SexToString
        {
            get
            {
                if (this.Sex == (int)PersonSex.Male)
                {
                    return "Male";
                }
                else
                {
                    return "Female";
                }
            }
        }
        public string SexToStringInVietnamese
        {
            get
            {
                if (this.Sex == (int)PersonSex.Male)
                {
                    return "Nam";
                }
                else
                {
                    return "Nữ";
                }
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }
        public DateTime DoB
        {
            get
            {
                return _doB;
            }

            set
            {
                _doB = value;
            }
        }
        public string DoBToDate
        {
            get
            {
                return this.DoB.Day + "/" + this.DoB.Month + "/" + this.DoB.Year;
            }
        }
        public string DoBToDateInVietnamese
        {
            get
            {
                return "Ngày " + this.DoB.Day + " tháng " + this.DoB.Month + " năm " + this.DoB.Year;
            }
        }
        public string IdCard
        {
            get
            {
                return _idCard;
            }

            set
            {
                if (value.Length >= 9)
                {
                    _idCard = value.Substring(0, 9);
                }
                else
                {
                    for (int i = 1; i <= (9 - value.Length); i++)
                    {
                        this._idCard += "0";
                    }
                    this._idCard += value;
                }
                    
            }
        }
        public string Address
        {
            get
            {
                return _address;
            }

            set
            {
                _address = value;
            }
        }
        public string Phone
        {
            get
            {
                return _phone;
            }

            set
            {
                _phone = value;
            }
        }
        public string Folk
        {
            get
            {
                return _folk;
            }

            set
            {
                _folk = value;
            }
        }
        #endregion

        #region "Constructor"
        ~CPerson() { }

        public CPerson()
        {
            this.Name = String.Empty;
            this.Sex = 0;
            this.DoB = new DateTime(0000, 0, 0);
            this.IdCard = String.Empty;
            this.Address = String.Empty;
            this.Phone = String.Empty;
            this.Folk = String.Empty;
        }
        public CPerson(string name, int sex, DateTime doB, string idCard, string address, string phone, string folk)
        {
            this.Name = name;
            this.Sex = sex;
            this.IdCard = idCard;
            this.Address = address;
            this.Phone = phone;
            this.Folk = folk;
            this.DoB = doB;
        }

        public CPerson(string v1, int v2, int v3, string v4, string v5, string v6, string v7)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
            this.v5 = v5;
            this.v6 = v6;
            this.v7 = v7;
        }
        #endregion

        #region "Methods"
        public string ShowInfors()
        {
            return ""
                + "Name: " + this.Name + '\n'
                + "Sex: " + this.SexToString + '\n'
                + "Id Card:" + this.IdCard + '\n'
                + "Address: " + this.Address + '\n'
                + "Phone: " + this.Phone + '\n'
                + "Folk: " + this.Folk + '\n'
                + "Date of Birth: " + this.DoBToDateInVietnamese + '\n';
        }

        public List<CPerson> GenerateObjects()
        {

        List<CPerson> Person = new List<CPerson>();
            Person.Add(new CPerson("Trần Ngọc Tân", 0, 1996/7/14, "1","Hà Nội", "0639576810", "Kinh"));
            Person.Add(new CPerson("Nguyễn Tuấn Anh", 0, 1996 / 7 / 14, "1", "Hà Nội", "0639576810", "Kinh"));
            Person.Add(new CPerson("Đặng Huy Phong", 0, 1996 / 7 / 14, "1", "Hà Nội", "0639576810", "Kinh"));
            Person.Add(new CPerson("Uông Đức Tùng", 0, 1996 / 7 / 14, "1", "Hà Nội", "0639576810", "Kinh"));
            Person.Add(new CPerson("Nguyễn Huy Công", 0, 1996 / 7 / 14, "1", "Hà Nội", "0639576810", "Kinh"));
            Person.Add(new CPerson("Doãn Trọng Anh", 0, 1996 / 7 / 14, "1", "Hà Nội", "0639576810", "Kinh"));
            Person.Add(new CPerson("Trần Ngọc Tân", 0, 1996 / 7 / 14, "1", "Hà Nội", "0639576810", "Kinh"));
            Person.Add(new CPerson("Trần Ngọc Tân", 0, 1996 / 7 / 14, "1", "Hà Nội", "0639576810", "Kinh"));
            Person.Add(new CPerson("Trần Ngọc Tân", 0, 1996 / 7 / 14, "1", "Hà Nội", "0639576810", "Kinh"));
            Person.Add(new CPerson("Trần Ngọc Tân", 0, 1996 / 7 / 14, "1", "Hà Nội", "0639576810", "Kinh"));
            return Person;
        }
        #endregion
    }
}
