using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace ConsoleApplication1
{
    class time
    {
        static int hours = 0;
        static int min = 0;
        static int sec = 0;
        static digit[] d = {   new digit(0, 5, 3), new digit(1, 5, 3),
                            new digit(2, 5, 3), new digit(3, 5, 3),
                            new digit(4, 5, 3), new digit(5, 5, 3),
                            new digit(6, 5, 3), new digit(7, 5, 3),
                            new digit(8, 5, 3), new digit(9, 5, 3)};
        #region methoods
        public static void clearTime(int x, int y)
        {
            drawDigit.clearDigit(x, y,d[0]);
            drawDigit.clearDigit(x + 7, y, d[0]);

            drawDigit.clearDigit(x + 20, y, d[0]);
            drawDigit.clearDigit(x + 27, y, d[0]);

            drawDigit.clearDigit(x + 40, y, d[0]);
            drawDigit.clearDigit(x + 47, y, d[0]);
        }
        public static void getFromUser(int x, int y)
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("welcome to stoper");
            Console.SetCursorPosition(0, 2);
            Console.WriteLine("insert hour you want to stoper please");
            hours = int.Parse(Console.ReadLine());
            Console.SetCursorPosition(0, 4);
            Console.WriteLine(" insert min you want to stoper");
            min = int.Parse(Console.ReadLine());
            Console.SetCursorPosition(0, 6);
            Console.WriteLine(" insert sec you want to stoper");
            sec = int.Parse(Console.ReadLine());
            
          }
        public static void timeShow(int hours , int min , int sec,int x , int y)
        {
            clearTime(x, y);
            drawDigit.draw(x + 40, y, d[sec / 10]);
            drawDigit.draw(x + 47, y, d[sec % 10]);

            drawDigit.draw(x + 20, y, d[min / 10]);
            drawDigit.draw(x + 27, y, d[min % 10]);

            drawDigit.draw(x, y, d[hours / 10]);
            drawDigit.draw(x + 7, y, d[hours % 10]);
        }
        public static void timer()
        {
            getFromUser(0,0);
            while ((hours != 0 || min != 0 || sec != 0))
            {
                
                time.timeShow(hours, min, sec, 90, 23);
                Thread.Sleep(1000);
                sec--;
                if (sec < 0)
                {
                    min--;
                    sec = 59;

                }
                if (min < 0)
                {
                    hours--;
                    min = 59;
                }

            }
            time.timeShow(0, 0, 0, 90, 23);
            music();
        }
        public static void music()
        {
            string filename = @"alarm_clock.wav";
            string filePath = AppDomain.CurrentDomain.BaseDirectory + filename;
            string AssemblyPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location).ToString();

            var myPlayer = new System.Media.SoundPlayer();
            myPlayer.SoundLocation = filePath;
            myPlayer.Play();

        }
        public static void changeColor(int hours,int min,int sec)
        {
            int c = 0;
            int all = hours + min + sec;
            for(int i=0;i<= all;i++)
            {
               // Console.ForegroundColor = ConsoleColor.y
            }
        }
        public void SetClock()
        {
            int selectedoption = 0;
            bool start = false;
            int hourSetOption = 3;// 3 - second, 2 - minutes 1 - hours

            ConsoleKeyInfo cki = new ConsoleKeyInfo();
            while(start == false)
            {
                if(Console.KeyAvailable == true)
                {
                    cki = Console.ReadKey();
                    if (cki.Key == ConsoleKey.LeftArrow)
                    { 
                        selectedoption--;
                        if (selectedoption < 1)
                            selectedoption = 4;
                        // view selected button by color

                }
                    if (cki.Key == ConsoleKey.RightArrow)
                    {
                        selectedoption++;
                        if (selectedoption>4)
                            selectedoption = 1;
                        // view selected button by color

                    }

                    if (cki.Key == ConsoleKey.UpArrow)
                    {
                        if(hourSetOption == 3)
                        {
                            // update seconds
                        }
                        else if(hourSetOption == 2)
                        {
                            // update minutes
                        }
                        else
                        {
                            // update hours
                        }
                    }

                    if (cki.Key == ConsoleKey.DownArrow)
                    {
                        if (hourSetOption == 3)
                        {
                            // update seconds
                        }
                        else if (hourSetOption == 2)
                        {
                            // update minutes
                        }
                        else
                        {
                            // update hours
                        }
                    }

                    if (cki.Key == ConsoleKey.End && selectedoption==1)
                    {
                        hourSetOption--;
                        if(hourSetOption<1)
                        {
                            hourSetOption = 3;
                            
                        }
                        if (hourSetOption >3)
                        {
                            hourSetOption = 1;
                        }
                        // view S, M or H

                    }


                    }

                if (cki.Key == ConsoleKey.Enter && selectedoption == 4)
                {
                    // start timer
                    start = true;
                }
    
        #endregion
}

