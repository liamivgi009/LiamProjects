using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class digit
    {
        int num;
        int size;
        int color;
        public digit(int num, int size, int color)
        {
            this.num = num;
            this.size = size;
            this.color = color;
        }
        public digit()
        {
            this.color = 5;
            this.num = 0;
            this.size = 5;
        }
        public int getNum()
        {
            return this.num;
        }
        public void setNum(int num)
        {
            this.num = num;
        }
        public int getSize()
        {
            return this.size;
        }
        public void setSize(int size)
        {
            this.size = size;
        }
        public int getColor()
        {
            return this.color;
        }
        public void setColor(int color)
        {
            this.color = color;
        }


        static int reverse(int num)
        {
            int reverse = 0;
            while (num > 0)
            {
                reverse = reverse * 10 + num % 10;
                num = num / 10;
            }
            return reverse;
        }
    }
        
}
