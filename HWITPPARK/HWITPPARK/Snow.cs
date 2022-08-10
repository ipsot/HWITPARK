using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWITPPARK
{
    class Snow
    {
        private static Random rnd = new Random();

        private int x, y;
        private float speed;
        private char face;

        public Snow()
        {
            x = 0;
            y = 0;
            speed = 0;
            face = '*';
        }

        public Snow(int x,int y, float speed, char face)
        {
            this.x = x;
            this.y = y;
            this.speed = speed;
            this.face = face;
        }

        public Snow(Snow snow)
        {
            this.x = snow.x;
            this.y = snow.y;
            this.speed = snow.speed;
            this.face = snow.face;
        }
        public void Show()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(face);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void MakeStep(int width)
        {
            int direction = rnd.Next(0, 2);
                switch(direction)
                {
                case 0:
                    x--;
                    if(x<0)
                    {
                        x = width;
                    }
                    break;
                case 1:
                    x++;
                    if(x>width)
                    {
                        x = 0;
                    }
                    break;
                }
            
        }
       
    }

}
