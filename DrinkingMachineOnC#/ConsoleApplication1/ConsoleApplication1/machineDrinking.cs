using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Media;
using System.IO;
using System.Reflection;

namespace ConsoleApplication1
{
    class machineDrinking
    {
        double moneyInMachine;

        const double NESCAFE = 3;
        const double CAFEBLACK = 5.20;
        const double TEA = 2.50;
        const double SHOKO = 4;
        const double SOUP = 9;
        const double fanta = 6.30;
        const double ORANGEJUICE = 8.40;
        const double GrapesJuice = 7.20;




        private design d;
        #region constactor
        public machineDrinking()
        {
            this.moneyInMachine = 0;
        }

        #endregion
        #region Get&Set
        public void setMoneyInMachine(double moneyInMachine)
        {
            this.moneyInMachine = moneyInMachine;
        }
        public double GetMoneyInMachine()
        {
            return this.moneyInMachine;
        }


        #endregion
        #region methoods


        public void keys()
        {
            Console.SetCursorPosition(60,22);
            double money1 = design.GetMoneyFromUser();
            ConsoleKeyInfo cki = Console.ReadKey();
            if (cki.Key == ConsoleKey.T)
            {
                if (money1 == TEA)
                {
                    Console.SetCursorPosition(33, 11);
                    Console.WriteLine("the tea will come in a moment");

                    design.animate(1);
                }
                else if (money1 > TEA)
                {
                    Console.SetCursorPosition(33, 11);
                    double Ationsimes = money1 - TEA;
                    Console.WriteLine("the less of  money is:" + Ationsimes);
                    design.animate(1);
                    design.animateCoin();
                    design.animateCoin2();

                }
                else if (money1 < TEA)
                {
                    Console.SetCursorPosition(33, 11);
                    Console.WriteLine("There is not enough money for the drink");
                }
            }
            else if (cki.Key == ConsoleKey.H)
            {
                if (money1 == SHOKO)
                {
                    Console.SetCursorPosition(33, 11);
                    Console.WriteLine("the shoko will come in a moment");
                    design.animate(2);
                }
                else if (money1 > SHOKO)
                {
                    double odef = money1 - SHOKO;
                    Console.SetCursorPosition(33, 11);
                    Console.WriteLine("the less of money is:" + odef);
                    design.animate(2);
                    design.animateCoin();
                    design.animateCoin2();
                }
                else if (money1 < SHOKO)
                {
                    Console.SetCursorPosition(33, 11);
                    Console.WriteLine("there is not enough money for the drink");
                }
            }
            else if (cki.Key == ConsoleKey.C)
            {
                if (money1 == CAFEBLACK)
                {
                    Console.SetCursorPosition(33, 11);
                    Console.WriteLine("the cafe will come in a moment");
                    design.animate(3);
                }
                else if (money1 > CAFEBLACK)
                {
                    Console.SetCursorPosition(33, 11);
                    double odef = money1 - CAFEBLACK;
                    Console.WriteLine("the less of money is:" + odef);
                    design.animate(3);
                    design.animateCoin();
                    design.animateCoin2();
                }
                else if (money1 < CAFEBLACK)
                {
                    Console.SetCursorPosition(33, 11);
                    Console.WriteLine("there is not enough money for the drink");
                }
            }
            else if (cki.Key == ConsoleKey.N)
            {
                if (money1 == NESCAFE)
                {

                    Console.SetCursorPosition(33, 11);
                    Console.WriteLine("the nesCafe will come in a moment");
                    design.animate(4);
                }
                else if (money1 > NESCAFE)
                {
                    double odef = money1 - NESCAFE;
                    Console.SetCursorPosition(33, 11);
                    Console.WriteLine("the less of money is:" + odef);
                    design.animate(4);
                    design.animateCoin();
                    design.animateCoin2();
                }
                else if (money1 < NESCAFE)
                {
                    Console.SetCursorPosition(33, 10);
                    Console.WriteLine("there is not enough money for the drink");
                }

            }
            else if (cki.Key == ConsoleKey.F)
            {
                if (money1 == fanta)
                {
                    Console.SetCursorPosition(33, 11);
                    Console.WriteLine("the fanta will come in a moment");
                    design.animate(5);
                }
                else if (money1 > fanta)
                {
                    Console.SetCursorPosition(33, 11);
                    double odef = money1 - fanta;
                    Console.WriteLine("the less of money is:" + odef);
                    design.animate(5);
                    design.animateCoin();
                    design.animateCoin2();
                }
                else if (money1 < fanta)
                {
                    Console.SetCursorPosition(33, 11);
                    Console.WriteLine("there is not enough money for the drink");

                }

            }
            else if (cki.Key == ConsoleKey.O)
            {
                if (money1 == ORANGEJUICE)
                {
                    Console.SetCursorPosition(33, 11);
                    Console.WriteLine("the ORANGEJUICE will come in a moment");
                    design.animate(6);
                }
                else if (money1 > ORANGEJUICE)
                {
                    Console.SetCursorPosition(33, 11);
                    double odef = money1 - ORANGEJUICE;
                    Console.WriteLine("the less of money is:" + odef);
                    design.animate(6);
                    design.animateCoin();
                    design.animateCoin2();
                }
                else if (design.GetMoneyFromUser() < ORANGEJUICE)
                {
                    Console.SetCursorPosition(33, 11);
                    Console.WriteLine("there is not enough money for the drink");

                }

            }
            else if (cki.Key == ConsoleKey.S)
            {
                if (money1 == SOUP)
                {
                    Console.SetCursorPosition(33, 11);
                    Console.WriteLine("the soup will come in a moment");
                    design.animate(7);
                }
                else if (money1 > SOUP)
                {
                    Console.SetCursorPosition(33, 11);
                    double odef = money1 - SOUP;
                    Console.WriteLine("the less of money is:" + odef);
                    design.animate(7);
                    design.animateCoin();
                    design.animateCoin2();
                }
                else if (money1 < SOUP)
                {
                    Console.SetCursorPosition(33, 11);
                    Console.WriteLine("there is not enough money for the drink");

                }

            }
            else if (cki.Key == ConsoleKey.R)
            {
                if (money1 == GrapesJuice)
                {
                    Console.SetCursorPosition(33, 11);
                    Console.WriteLine("the grape Juice will come in a moment");
                    design.animate(8);
                }
                else if (money1 > GrapesJuice)
                {
                    Console.SetCursorPosition(33, 11);
                    double odef = money1 - GrapesJuice;
                    Console.WriteLine("the less of money is:" + odef);
                    design.animate(8);
                    design.animateCoin();
                    design.animateCoin2();
                }
                else if (money1 < GrapesJuice)
                {
                    Console.SetCursorPosition(33, 11);
                    Console.WriteLine("there is not enough money for the drink");

                }
            }
            
        }
        public void music()
        {
            string filename = @"audio2.wav";
            string filePath = AppDomain.CurrentDomain.BaseDirectory + filename;
            string AssemblyPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location).ToString();

            var myPlayer = new System.Media.SoundPlayer();
            myPlayer.SoundLocation = filePath;
            myPlayer.Play();

        }
    }
}
    



        
        
        #endregion


    












