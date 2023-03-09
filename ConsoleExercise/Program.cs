using System;

namespace ConsoleExercise
{
    class Program
    {
        /// <summary>
        /// 根据年月日，获取星期数的方法
        /// </summary>
        /// <param name="year">年</param>
        /// <param name="month">月</param>
        /// <param name="day">日</param>
        /// <returns>星期数</returns>
        private static int GetWeekByDay(int year, int month, int day)
        {
            DateTime dt = new DateTime(year, month, day);
            return (int)dt.DayOfWeek;
           
        }
        private static bool IsLeapYear(int year)
        {
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
                return true;
            else
                return false;
        }
        private static int GetDaysByMonth(int year,int month)
        {
            if (month >= 1 && month <= 12)
            {
                switch(month)
                {
                    case2:
                    return IsLeapYear(year) ? 29 : 28;
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 11:
                    return 31;
                default:
                    return 30;
                }
            }
            else return 0;
        
        
        }
    private static void PrintMonthCalender(int year,int month)
    {
        //显示表头
        Console.WriteLine("{0}年{1}月", year, month);
        Console.WriteLine(日/t一/t二/t三/t四/t五/t六)；
            //根据星期数打印空格
            int week=GetWeekByDay(year,month,1)
            for (int i = 0, i<= week, i++)
            Console.Write("/t");
            
            //根据当月总天数显示日
           int days=GetDaysByMonth(year,month)
    }
    }
}
