using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tast_1
{
    public class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        public Duration(int Hours=0, int minutes=0, int Seconds = 0)
        {
            this.Hours = Hours;
            this.Minutes = minutes;
            this.Seconds = Seconds;

        }
        public Duration(int Seconds)
        {
            this.Hours = Seconds / 3600;
            this.Minutes = (Seconds % 3600) / 60;
            this.Seconds = Seconds % 60;
        }
        //override get string function of object
        public override string ToString()
        {
            if (Hours > 0)
            {
                return $"format data as : {Hours} H : {Minutes} M : {Seconds} S";

            }
            else
            {
                return $"format data as :  {Minutes} M : {Seconds} S";

            }



        }
        public override bool Equals(object? obj)
        {
            if (obj is Duration D)
                return (Hours==D.Hours&&Minutes==D.Minutes&&Seconds==D.Seconds);
            return false;

        }
        public  static Duration operator +(Duration d1, Duration d2) {
            Duration d3 = new Duration();
            int Seconds = (d1.Hours + d2.Hours)*3600+(d1.Minutes + d2.Minutes)*60+(d1.Seconds+d2.Seconds);
            d3.Hours = Seconds / 3600;
            d3.Minutes= (Seconds % 3600) / 60;
            d3.Seconds = Seconds % 60;
            return d3;
        }
        public static Duration operator +(int Second, Duration d2)
        {
            Duration d3 = new Duration();
            int Seconds = (d2.Hours) * 3600 + ( d2.Minutes) * 60 + ( d2.Seconds)+Second;
            d3.Hours = Seconds / 3600;
            d3.Minutes = (Seconds % 3600) / 60;
            d3.Seconds = Seconds % 60;
            return d3;
        }
        public static Duration operator ++(Duration d2)
        {
            Duration d3 = new Duration();
            int Seconds = (d2.Hours) * 3600 + (d2.Minutes) * 60 + (d2.Seconds) +60;
            d3.Hours = Seconds / 3600;
            d3.Minutes = (Seconds % 3600) / 60;
            d3.Seconds = Seconds % 60;
            return d3;
        }
        public static Duration operator --(Duration d2)
        {
            Duration d3 = new Duration();
            int Seconds = (d2.Hours) * 3600 + (d2.Minutes) * 60 + (d2.Seconds) -60;
            d3.Hours = Seconds / 3600;
            d3.Minutes = (Seconds % 3600) / 60;
            d3.Seconds = Seconds % 60;
            return d3;
        }

        public static bool operator <=(Duration d1, Duration d2)
        {
           
            int Seconds1 = (d2.Hours) * 3600 + (d2.Minutes) * 60 + (d2.Seconds) - 60;

            int Seconds2 = (d2.Hours) * 3600 + (d2.Minutes) * 60 + (d2.Seconds) - 60;

            
            return Seconds1<=Seconds2;
        }
        public static bool operator >=(Duration d1, Duration d2)
        {

            int Seconds1 = (d2.Hours) * 3600 + (d2.Minutes) * 60 + (d2.Seconds) - 60;

            int Seconds2 = (d2.Hours) * 3600 + (d2.Minutes) * 60 + (d2.Seconds) - 60;


            return Seconds1 >= Seconds2;
        }


        //public string getstring()
        //{
        //    if (Hours > 0)
        //    {
        //        return $"Hours= {Hours} - minutes = {Minutes} - seconds= {Seconds}";
        //    }

        //    else
        //    {
        //        return $"minutes= {Minutes} - seconds = {Seconds}";
        //    }


        //}
    }
}
