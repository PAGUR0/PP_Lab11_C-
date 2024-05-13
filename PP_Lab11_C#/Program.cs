using System;
using System.Collections.Generic;

class Program
{
    delegate string GetNextDayDelegate();

    static void Main(string[] args)
    {
        List<string> daysOfWeek = new List<string>
        {
            "Понедельник",
            "Вторник",
            "Среда",
            "Четверг",
            "Пятница",
            "Суббота",
            "Воскресенье"
        };

        int currentIndex = 0;

        GetNextDayDelegate getNextDay = () =>
        {
            string nextDay = daysOfWeek[currentIndex];

            currentIndex = (currentIndex + 1) % daysOfWeek.Count;

            return nextDay;
        };

        for (int i = 0; i < 37; i++)
        {
            string nextDay = getNextDay();
            Console.WriteLine($"Следующий день недели: {nextDay}");
        }
    }
}