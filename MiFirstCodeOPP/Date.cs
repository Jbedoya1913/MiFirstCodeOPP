using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace MiFirstCodeOPP
{
    internal class Date
    {
        public int _year;
        public int _month;
        public int _day;
        
        

        #region Constructor

        public Date(int year, int month, int day)
        {
            this._year = ValidateYear(year);
            this._month = ValidateMonth(month);
            this._day = ValidateDay(day,month);
            
                     
        }

        #endregion

        public override string ToString()
        {        
            return $"{_year:0000} / { _month:00} / {_day:00}";
        }

        private int ValidateDay(int day,int month)
        {
            if(month == 2)
            {
                if (day>= 1 && day<= 28)
                {
                    return day;
                }

                throw new DayException("The Day is incorrect!");

            }
            
            if(month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
            {
                if (day >= 1 && day<= 31)
                {
                    return day;
                }
            }

            else
            {
                if (day >= 1 && day <= 30)
                {
                    return day;
                }
            }

            throw new DayException("The Day is incorrect!");
        }


        private int ValidateMonth(int month)
        {
            if(month > 1 && month <= 12)
            {
                return month;
            }

            throw new MonthException("The Month is incorrect!");

        }

        private int ValidateYear(int year)
        {
           
            if(year > 1900)
            {
                return year;
            }

            throw new YearException("The Year is incorrect!");
        }

    }
}
