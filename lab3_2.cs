using System;

namespace Practise
{
        public abstract class institude
        {
            private string name;
            private int amount_pupils;
            private int year_studying;
            private int number;
            private int amount_staff;
            
            public string Name
            {
                get { return name; }
                set
                {
                    if (value == "")
                        throw new ArgumentNullException();
                    else
                        name = value;
                }
            }

            public int Amount_Pupils
            {
                get { return amount_pupils; }
                set
                {
                    if (value < 0)
                        throw new ArgumentOutOfRangeException();
                    else
                        amount_pupils = value;
                }
            }

            public int Year_Studying
            {
                get { return year_studying; }
                set
                {
                    if (value < 0)
                        throw new ArgumentOutOfRangeException();
                    else
                        year_studying = value;
                }
            }

            public int Number
            {
                get { return number; }
                set
                {
                    if (value < 0)
                        throw new ArgumentOutOfRangeException();
                    else
                        number = value;
                }
            }

            public int Amount_staff
            {
                get { return amount_staff; }
                set
                {
                    if (value < 0)
                        throw new ArgumentOutOfRangeException();
                    else
                        amount_staff = value;
                }
            }

            public virtual string GetInfo()
            {
                return $"{name} of number {number}. There are  {amount_pupils}  pupils, and {amount_staff} staff. You need {year_studying} year of studing";
            }

            public institude()
            {
            
            }

            public institude(string Name)
            {
            
                this.Name = Name;
            }
            public institude(int Year_Studying, int Number)
            {
                this.Year_Studying = Year_Studying;
                this.Number = Number;
            }

            public institude(int Amount_Pupils, int Amount_staff, bool kostil)
            {
                this.Amount_staff = Amount_staff;
                this.Amount_Pupils = Amount_Pupils;
            }

        }

        public class School : institude
        {
            public override string GetInfo()
            {
                return base.GetInfo();
            }
            public School() : base()
            {

            }

            public School(string Name) : base(Name)
            {

            }

            public School(int Amount_pupils, int Year_Studing) : base(Amount_pupils, Year_Studing)
            {


            }

            public School(int Number, int Amount_staff, bool kostil) : base(Number, Amount_staff)
            {

            }
        }

        public class University : institude
        {
            public override string GetInfo()
            {
                return base.GetInfo();
            }

            public University() : base()
            {

            }

            public University(string Name) : base(Name)
            {


            }

            public University(int Amount_pupils, int Year_Studing) : base(Amount_pupils, Year_Studing)
            {

            }

            public University(int Number, int Amount_staff, bool kostil) : base(Number, Amount_staff)
            {

            }
        
    }
}