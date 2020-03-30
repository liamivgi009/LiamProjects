using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class drawDigit
    {
        public static void draw(int x , int y,digit d)
        {
            if (d.getNum() == 0)
                draw0(x, y, d);
            else if (d.getNum() == 1)
                draw1(x, y, d);
            else if (d.getNum() == 2)
                draw2(x, y, d);
            else if (d.getNum() == 3)
                draw3(x, y, d);
            else if (d.getNum() == 4)
                draw4(x, y, d);
            else if (d.getNum() == 5)
                draw5(x, y, d);
            else if (d.getNum() == 6)
                draw6(x, y, d);
            else if (d.getNum() == 7)
                draw7(x, y, d);
            else if (d.getNum() == 8)
                draw8(x, y, d);
            else if (d.getNum() == 9)
                draw9(x, y, d);
           

        }
        #region tools
        private static void horizontalRow(int x , int y,int size,int color,char c)
        {
            Console.ForegroundColor = (ConsoleColor)color;
            for (int i = 0;i<size;i++)
            {
                Console.SetCursorPosition(x + i, y);
                Console.Write(c);
            }
        }
        private static void verticalRow(int x, int y, int size, int color,char c)
        {
            Console.ForegroundColor = (ConsoleColor)color;
            for (int i = 1; i <= size; i++)
            {
                Console.SetCursorPosition(x, y + i- 1);
                Console.Write(c);
            }
        }
        private static void horizontalRowSymbol(int x, int y, int size, int color)
        {
            horizontalRow(x, y, size, color, '█');
        }


        private static void horizontalRowSpace(int x, int y, int size, int color)
        {
            horizontalRow(x, y, size, color, ' ');
        }
        private static void verticalRowSpace(int x, int y, int size, int color)
        {
            verticalRow(x, y, size, color, ' ');
        }

        private static void verticalRowSymbol(int x, int y, int size, int color)
        {
            verticalRow(x, y, size, color, '█');
        }



        #endregion
        public static void draw9(int x, int y, digit d)
        {
            horizontalRowSymbol(x, y, d.getSize(), d.getColor());
            verticalRowSymbol(x + d.getSize() - 1, y, d.getSize(), d.getColor());
            horizontalRowSymbol(x, y + d.getSize() / 2, d.getSize(), d.getColor());
            verticalRowSymbol(x, y, d.getSize() / 2, d.getColor());
            horizontalRowSymbol(x, y + d.getSize() - 1, d.getSize(), d.getColor());
        }

        public static void draw8(int x, int y, digit d)
        {
            verticalRowSymbol(x, y, d.getSize(), d.getColor());
            horizontalRowSymbol(x, y, d.getSize(), d.getColor());
            verticalRowSymbol(x + d.getSize() - 1, y, d.getSize(), d.getColor());
            horizontalRowSymbol(x , y + d.getSize() - 1, d.getSize(), d.getColor());
            horizontalRowSymbol(x, y + d.getSize() / 2, d.getSize(), d.getColor());
            horizontalRowSymbol(x + d.getSize() - 2, y + d.getSize() - 1, d.getSize() / 2, d.getColor());
        }

        public static void draw7(int x, int y, digit d)
        {
            horizontalRowSymbol(x + d.getSize() / 2 - 2, y, d.getSize() / 2 + 2, d.getColor());
            verticalRowSymbol(x + d.getSize() - 1, y, d.getSize(), d.getColor());
        }

        public static void draw6(int x, int y, digit d)
        {
            horizontalRowSymbol(x, y, d.getSize(), d.getColor());
            verticalRowSymbol(x, y, d.getSize(), d.getColor());
            horizontalRowSymbol(x, y + d.getSize() - 1, d.getSize(), d.getColor());
            verticalRowSymbol(x + d.getSize() - 1, y + d.getSize() / 2, d.getSize() / 2, d.getColor());
            horizontalRowSymbol(x, y + d.getSize() / 2, d.getSize(), d.getColor());
        }

        public static void draw5(int x, int y, digit d)
        {
            horizontalRowSymbol(x, y, d.getSize(), d.getColor());
            horizontalRowSymbol(x, y + d.getSize() / 2, d.getSize(), d.getColor());
            horizontalRowSymbol(x, y + d.getSize() - 1, d.getSize(), d.getColor());
            verticalRowSymbol(x, y, d.getSize() / 2, d.getColor());
            verticalRowSymbol(x + d.getSize() - 1, y +d.getSize() / 2, d.getSize() / 2, d.getColor());
        }

        public static void draw4(int x, int y, digit d)
        {
            verticalRowSymbol(x + d.getSize() - 1, y, d.getSize(), d.getColor());
            verticalRowSymbol(x, y, d.getSize() / 2, d.getColor());
            horizontalRowSymbol(x, y + d.getSize() / 2, d.getSize(), d.getColor());
        }

        public static void draw3(int x, int y, digit d)
        {
            horizontalRowSymbol(x, y, d.getSize(), d.getColor());
            horizontalRowSymbol(x, y + d.getSize() / 2, d.getSize(), d.getColor());
            horizontalRowSymbol(x, y + d.getSize() - 1, d.getSize(), d.getColor());
            verticalRowSymbol(x + d.getSize() - 1, y, d.getSize() / 2, d.getColor());
            verticalRowSymbol(x + d.getSize() - 1, y + d.getSize() / 2 + 1, d.getSize() / 2, d.getColor());
        }

        public static void draw2(int x, int y, digit d)
        {
            horizontalRowSymbol(x,y,d.getSize(),d.getColor());
            horizontalRowSymbol(x,y + d.getSize() / 2,d.getSize(),d.getColor());
            horizontalRowSymbol(x,y + d.getSize() - 1,d.getSize(),d.getColor());
            verticalRowSymbol(x + d.getSize() - 1, y,d.getSize() / 2,d.getColor());
            verticalRowSymbol(x, y + d.getSize() / 2, d.getSize() / 2, d.getColor());

           
           
            
        }

        public static void draw1(int x, int y, digit d)
        {
            verticalRowSymbol(x + d.getSize() -1, y, d.getSize(), d.getColor());
        }

        public static void draw0(int x, int y, digit d)
        {
            horizontalRowSymbol(x, y, d.getSize(), d.getColor());
            horizontalRowSymbol(x, y + d.getSize() - 1, d.getSize(), d.getColor());
            verticalRowSymbol(x, y, d.getSize(), d.getColor());
            verticalRowSymbol(x + d.getSize() - 1, y, d.getSize(), d.getColor());

        }

        public static void clearDigit(int x , int y ,digit d)
        {
            verticalRowSpace(x, y, d.getSize(), d.getColor());
            horizontalRowSpace(x, y, d.getSize(), d.getColor());
            verticalRowSpace(x + d.getSize() - 1, y, d.getSize(), d.getColor());
            horizontalRowSpace(x, y + d.getSize() - 1, d.getSize(), d.getColor());
            horizontalRowSpace(x, y + d.getSize() / 2, d.getSize(), d.getColor());
            horizontalRowSpace(x + d.getSize() - 2, y + d.getSize() - 1, d.getSize() / 2, d.getColor());

        }
    }
}
