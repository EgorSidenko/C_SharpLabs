using System;
using System.Collections.Generic;

namespace Lab5_2
{
    public abstract class institude : IComparable<institude>
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

        public int CompareTo(institude other)
        {
            // If other is not a valid object reference, this instance is greater.
            if (other == null) return 1;

            // The  comparison depends on the comparison of
            // price
            return Amount_Pupils.CompareTo(other.Amount_Pupils);
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
    public class School : institude, IComparable
    {

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            institude otherInstitude = obj as institude;
            if (otherInstitude != null)
                return base.CompareTo(otherInstitude);
            else
                throw new ArgumentException("Object is not a Book");
        }

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

    public class University : institude, IComparable
    {
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            institude otherInstitude = obj as institude;
            if (otherInstitude != null)
                return base.CompareTo(otherInstitude);
            else
                throw new ArgumentException("Object is not a Book");
        }
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