using System;
namespace CalendarApplication
{
    class CalendarApp
    {
        private static int GetWeekByDay(int year, int month, int day)
        {
            DateTime dt = new DateTime(year, month, day);
            return (int)dt.DayOfWeek;
        }
        //根据月份计算当月天数
        private static int GetDaysByMonth(int year, int month)
        {
            if (month >= 1 && month <= 12)
            {
                switch (month)
                {
                    case 2:
                        if (IsLeapYear(year) == true) //此处可用三元表达式 if IsLeapYear(year)?29:28;
                            return 29;
                        else return 28;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        return 30;
                    default:
                        return 31;
                }
            }
            else return 0; //此处可用短路语句放上去，减少一个else
        }
        private static bool IsLeapYear(int year)
        {
            if (year % 4 == 0 && year % 400 == 0 || year % 400 == 0)
                return true;
            else return false;
        }
        //打印日历
        private static void PrintMonthCalendar(int year, int month)
        {
            //显示表头
            Console.WriteLine("{0}年{1}月", year, month);
            Console.WriteLine("Su\tMo\tTu\tWd\tTh\tFr\tSa");
            int WeekDay = GetWeekByDay(year, month, 1);
            int SpaceNum = 0;
            while (SpaceNum < WeekDay)
            {
                Console.Write("\t");
                SpaceNum++;
            }
            int day = GetDaysByMonth(year, month);
            int DayNum = 0;
            while (DayNum < day)
            {
                Console.Write(DayNum + "\t");
                DayNum++;
                if (GetWeekByDay(year, month, day) == 6)
                {
                    Console.WriteLine();
                }
            }
        }
        private static void PrintYearCalendar(int year)
        {
            for (int month = 1; month <= 12; month++)
            {
                PrintMonthCalendar(year, month);
            }
        }
        private static void Main()
        {
            int year = int.Parse(Console.ReadLine());
            PrintYearCalendar(year);
        }
    }
}
