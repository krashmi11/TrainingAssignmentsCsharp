using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace DateTime1
{
    internal class Program
    {
        static void formatDateTime(DateTime dateTime)
        {
            Console.WriteLine(dateTime.ToString("yyyy-MM-dd HH:mm:ss"));
            Console.WriteLine(dateTime.ToString(@"MM\/dd\/yyyy"));
            Console.WriteLine(dateTime.ToString("dddd, dd MMMM yyyy"));
        }

        static void addSubtractTime(DateTime dateTime)
        {
            Console.WriteLine("Today's Date:"+ dateTime.ToString("yyyy-MM-dd HH:mm:ss"));
            Console.WriteLine("New Date after adding 10 days to current Date:"+ dateTime.AddDays(10).ToString("yyyy-MM-dd HH:mm:ss"));
            Console.WriteLine("Time after subtracting 5 hours:" + dateTime.AddHours(-5).ToString("yyyy-MM-dd HH:mm:ss"));

        }

        static void compareDate(DateTime dateTime1, DateTime dateTime2)
        {
            int result=DateTime.Compare(dateTime1, dateTime2);
            Console.WriteLine("###" + result);
            if (result == 0) { Console.WriteLine("Both Dates are equal"); }
            else if (result > 0)
            {
                Console.WriteLine("Date 1 is later of Date 2.");
            }
            else
            {
                Console.WriteLine("Date 1 is earlier of Date 2");
            }
        }

        static double findDiffInDays(DateTime dateTime1,DateTime dateTime2)
        {
            return Math.Abs(dateTime1.Subtract(dateTime2).TotalDays);
        }

        static void convertUTC(DateTime dateTime)
        {
            Console.WriteLine("Local Time:"+dateTime.ToLocalTime().ToString());
            Console.WriteLine("UTC Time zone:"+dateTime.ToUniversalTime().ToString());
                
        }
        static void extractDateComponents(DateTime date)
        {
            Console.WriteLine("Current Date:" + date.ToString());
            Console.WriteLine("Year:"+date.Year);
            Console.WriteLine("Month:"+date.Month);
            Console.WriteLine("Day:"+date.Day);
            Console.WriteLine("Hour:"+date.Hour);
            Console.WriteLine("Minute:"+date.Minute);
            Console.WriteLine("Second:"+date.Second);
        }
        static DateTime addTimeDuration(DateTime date,TimeSpan timeSpan)
        {
            DateTime updatedTime=date.Add(timeSpan);
            return updatedTime;
        }
        static bool checkLeapYear(int year)
        {
            return DateTime.IsLeapYear(year);
        }

        

        static void Main(string[] args)
        {
            //1.Formatting DateTime
            //Problem:
            //Write a program that prints the current date and time in the following formats:
            // yyyy - MM - dd HH: mm: ss
            // MM / dd / yyyy
            // dddd, dd MMMM yyyy
            //Expected Output(example):
            //2025 - 02 - 14 15:30:00
            //02 / 14 / 2025
            //Friday, 14 February 2025
            DateTime dateTime = DateTime.Now;
            Console.WriteLine("Task1: Formatting DateTime:");
            formatDateTime(dateTime);
            Console.WriteLine("-----------------------------------------------------------------------");

            //2.Adding and Subtracting Time Problem:
            //Write a program to:
            //1.Print today’s date.
            //2.Add 10 days to the current date and display the new date.
            //3.Subtract 5 hours from the current time and display the result.
            Console.WriteLine("Task2: Adding and Subtracting Time:");
            addSubtractTime(dateTime);
            Console.WriteLine("-----------------------------------------------------------------------");

            //3.Parsing Date Problem:
            //Given a string dateString = "14-Feb-2025", convert it into a DateTime object using DateTime.Parse().
            //Print the parsed date.
            //Also Use DateTime.TryParse() to ensure no errors occur if the string format is invalid.
            Console.WriteLine("Task3: Parsing Date Problem:");
            Console.WriteLine("Enter a date string(ex:14-Feb-2025) in this format:");
            DateTime dateTimeObj1 = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Date printed using Parse:" + dateTimeObj1.ToString("yyyy-MM-dd"));
            Console.WriteLine("Enter a date string(ex:14-Feb-2025) in this format again to validate:");
            bool success = DateTime.TryParse(Console.ReadLine(), out dateTimeObj1);
            if (success) { Console.WriteLine("Date:" + dateTimeObj1.ToString("yyyy-MM-dd ")); }
            else { Console.WriteLine("Conversion Failed!!!Invalid input string"); }
            Console.WriteLine("-----------------------------------------------------------------------");


            //4.Comparing Date Problem:
            //Create two DateTime objects:
            // date1 = 2025 - 02 - 14
            // date2 = 2025 - 02 - 20
            //Compare the two dates and print whether date1 is earlier, later, or the same as date2.
            Console.WriteLine("Task4: Comparing Date Problem::");
            Console.WriteLine("Enter input date1 in this format (yyyy-MM-dd):");
            DateTime date1 = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter input date2 in this format (yyyy-MM-dd):");
            DateTime date2 = DateTime.Parse(Console.ReadLine());
            compareDate(date1, date2);
            Console.WriteLine("-----------------------------------------------------------------------");



            //5.Calculating the Difference Between Two Dates Problem:
            //Write a program that calculates the number of days between two dates:
            // Start date: 2025 - 01 - 01
            // End date: 2025 - 02 - 14
            //Print the difference in days.
            Console.WriteLine("Task5: Calculating the Difference Between Two Dates Problem:");
            Console.WriteLine("Enter input date1 in this format (yyyy-mm-dd):");
            date1 = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter input date2 in this format (yyyy-mm-dd):");
            date2 = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("The number of days between two dates:" + findDiffInDays(date1, date2));
            Console.WriteLine("-----------------------------------------------------------------------");


            //6.Extracting Date and Time Components Problem:
            //Print the following components of the current date and time:
            // Year
            // Month
            // Day
            // Hour
            // Minute
            // Second
            Console.WriteLine("Task 6:Extracting Date and Time Components Problem:");
            extractDateComponents(dateTime);
            Console.WriteLine("-----------------------------------------------------------------------");


            //7.Time Zones and UTC Conversion Problem:
            //1.Print the current local date and time.
            //2.Convert it to UTC using ToUniversalTime() and print the result.
            Console.WriteLine("Task 7:Time Zones and UTC Conversion Problem:");
            convertUTC(dateTime);
            Console.WriteLine("-----------------------------------------------------------------------");

            //8.Checking Leap Year Problem:
            //Write a program that checks if a given year(e.g., 2024) is a leap year using DateTime.IsLeapYear().
            Console.WriteLine("Task 8:Checking Leap Year Problem:");
            Console.WriteLine("Enter year:");
            int year = int.Parse(Console.ReadLine());
            if (checkLeapYear(year))
            {
                Console.WriteLine($"{year} is a leap year.");
            }
            else
            {
                Console.WriteLine($"{year} is not a leap year.");
            }
            Console.WriteLine("-----------------------------------------------------------------------");


            //9.Display the First and Last Day of the Month Problem:
            //Write a program that takes any date as input and displays the first and last day of that month.
            Console.WriteLine("Task 9:Display the First and Last Day of the Month Problem:");
            Console.WriteLine("Enter date in format (yyyy-MM-dd):");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime dateTime1))
            {
                DateTime firstDay = new DateTime(dateTime1.Year, dateTime1.Month, 1);
                DateTime lastDay = new DateTime(dateTime1.Year, dateTime1.Month, DateTime.DaysInMonth(dateTime1.Year, dateTime1.Month));
                Console.WriteLine("First Day of Month:" + firstDay.ToString("yyyy-MM-dd") + " " + firstDay.DayOfWeek);
                Console.WriteLine("Last Day of Month:" + lastDay.ToString("yyyy-MM-dd") + " " + lastDay.DayOfWeek);
            }
            else
            {
                Console.WriteLine("Invalid Conversion!!");
            }
            Console.WriteLine("-----------------------------------------------------------------------");

            //10.Add a Specific Time Duration Problem:
            //Write a program that adds a TimeSpan of 2 hours, 30 minutes to the current time and prints the result.
            Console.WriteLine("Task 10.Add a Specific Time Duration Problem:");
            TimeSpan timeSpan = new TimeSpan(2, 30, 0);
            Console.WriteLine("Updated time:" + addTimeDuration(dateTime, timeSpan));
            Console.WriteLine("-----------------------------------------------------------------------");

            //11.Countdown Timer Problem:
            //Given a future date(e.g., "2025-12-31"), calculate the number of days, hours, and minutes remaining
            //until that date.
            Console.WriteLine("Task 11.Countdown Timer Problem:");
            Console.WriteLine("Enter any future date(yyyy-MM-dd):");
            if(DateTime.TryParse(Console.ReadLine(), out DateTime fDate))
            {
               
                DateTime currentDate= DateTime.Now;
                if (fDate > currentDate)
                {
                    timeSpan = fDate - currentDate;
                    Console.WriteLine($"Time Remaining till future Date:{timeSpan.Days} days {timeSpan.Hours} hours {timeSpan.Minutes} minutes");
                }
                else
                {
                    Console.WriteLine("Future date should be greater than current Date");
                }
            }
            else
            {
                Console.WriteLine("Invalid Date Format");
            }















        }
    }
}
