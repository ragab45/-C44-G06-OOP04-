namespace Assemente
{
  
        internal class Duration
        {
            #region Assemente
            public int Hours { get; set; }
            public int Minutes { get; set; }
            public int Seconds { get; set; }

            // Constructor: (hours, minutes, seconds)
            public Duration(int h, int m, int s)
            {
                Hours = h;
                Minutes = m;
                Seconds = s;
                Normalize();
            }

            // Constructor: total seconds
            public Duration(int totalSeconds)
            {
                Hours = totalSeconds / 3600;
                totalSeconds %= 3600;
                Minutes = totalSeconds / 60;
                Seconds = totalSeconds % 60;
            }

            // ToString method
            public override string ToString()
            {
                string result = "";
                if (Hours > 0)
                    result += $"Hours: {Hours}, ";
                if (Minutes > 0 || Hours > 0)
                    result += $"Minutes: {Minutes}, ";
                result += $"Seconds: {Seconds}";
                return result;
            }

            // Normalize to fix if seconds >= 60 or minutes >= 60
            private void Normalize()
            {
                if (Seconds >= 60)
                {
                    Minutes += Seconds / 60;
                    Seconds %= 60;
                }

                if (Minutes >= 60)
                {
                    Hours += Minutes / 60;
                    Minutes %= 60;
                }

                if (Seconds < 0 || Minutes < 0 || Hours < 0)
                {
                    Hours = Minutes = Seconds = 0; // simple reset
                }
            }

            // Convert full time to total seconds
            private int ToTotalSeconds()
            {
                return Hours * 3600 + Minutes * 60 + Seconds;
            }

            // Operator +
            public static Duration operator +(Duration d1, Duration d2)
            {
                return new Duration(d1.ToTotalSeconds() + d2.ToTotalSeconds());
            }

            public static Duration operator +(Duration d, int seconds)
            {
                return new Duration(d.ToTotalSeconds() + seconds);
            }

            public static Duration operator +(int seconds, Duration d)
            {
                return d + seconds;
            }

            // Operator -
            public static Duration operator -(Duration d1, Duration d2)
            {
                int diff = d1.ToTotalSeconds() - d2.ToTotalSeconds();
                if (diff < 0) diff = 0;
                return new Duration(diff);
            }

            // ++ operator: add 1 minute
            public static Duration operator ++(Duration d)
            {
                return new Duration(d.ToTotalSeconds() + 60);
            }

            // -- operator: subtract 1 minute
            public static Duration operator --(Duration d)
            {
                int result = d.ToTotalSeconds() - 60;
                if (result < 0) result = 0;
                return new Duration(result);
            }

            // Operator >
            public static bool operator >(Duration d1, Duration d2)
            {
                return d1.ToTotalSeconds() > d2.ToTotalSeconds();
            }

            // Operator <
            public static bool operator <(Duration d1, Duration d2)
            {
                return d1.ToTotalSeconds() < d2.ToTotalSeconds();
            }
            static void Main()
            {
                Duration D1 = new Duration(1, 10, 15);
                Console.WriteLine("D1: " + D1);

                Duration D2 = new Duration(7800);
                Console.WriteLine("D2: " + D2);

                Duration D3 = new Duration(666);
                Console.WriteLine("D3: " + D3);

                D3 = D1 + D2;
                Console.WriteLine("D3 = D1 + D2: " + D3);

                D3 = D1 + 7800;
                Console.WriteLine("D3 = D1 + 7800: " + D3);

                D3 = 666 + D3;
                Console.WriteLine("D3 = 666 + D3: " + D3);

                D3 = ++D1;
                Console.WriteLine("D3 = ++D1: " + D3);

                D3 = --D2;
                Console.WriteLine("D3 = --D2: " + D3);

                D1 = D1 - D2;
                Console.WriteLine("D1 = D1 - D2: " + D1);

                if (D1 > D2)
                    Console.WriteLine("D1 is greater than D2");
                else
                    Console.WriteLine("D2 is greater than or equal to D1");
            }
            #endregion
        }
    }



