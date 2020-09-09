using System;

namespace Human_Readable_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            GetReadableTime(5);
        }

        public static string GetReadableTime(int seconds)
        {
            int hours = 0;
            int minutes = 0;
            
            while (seconds >= 3600)
            {
                hours += 1;
                seconds -= 3600;
            }
            while (seconds >= 60)
            {
                minutes += 1;
                seconds -= 60;
            }
            string stringHours = hours.ToString();
            if (hours < 10)
            {
                stringHours = "0" + hours.ToString();
            }
            string stringMinutes = minutes.ToString();
            if (minutes < 10)
            {
                stringMinutes = "0" + minutes.ToString();
            }
            string stringSeconds = seconds.ToString();
            if (seconds < 10)
            {
                stringSeconds = "0" + seconds.ToString();
            }
            string result = stringHours + ":" + stringMinutes + ":" + stringSeconds;

            return result;
        }
    }
}
