﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_DateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //local time
            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            //utc time
            DateTime dtu = DateTime.UtcNow;
            Console.WriteLine(dtu);

            Console.WriteLine($"Day: {dt.Day}");
            Console.WriteLine($"Month: {dt.Month}");
            Console.WriteLine($"Year: {dt.Year}");
            
            //Date time operarions
            var tenDaysFromNow = dt.AddDays( 10 );
            Console.WriteLine(tenDaysFromNow);

            var tenDaysAndTwentyHoursFromNow = dt.AddHours( 20 ).AddDays(10);
            Console.WriteLine(tenDaysAndTwentyHoursFromNow);

            // Formatting the output
            Console.WriteLine();
            Console.WriteLine($"Standard Output: {dt}");
            Console.WriteLine(dt.ToString("MM-dd-yyyy hh:mm:ss"));
            Console.WriteLine(dt.ToString("MM/dd/yyyy hh:mm:ss"));
            Console.WriteLine(dt.ToString("MM dd yyyy"));
            Console.WriteLine(dt.ToString("dd-MM-yyyy"));
            Console.WriteLine(dt.ToString("hh:mm:ss"));
        }
    }
}
