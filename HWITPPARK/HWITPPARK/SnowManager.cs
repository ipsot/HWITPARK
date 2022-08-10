using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWITPPARK
{
    class SnowManager
    {
        private static Random rnd = new Random();
        private List<Snow> snows;

        private char[] faces = { '*','#','@','^','+'};
        private int width, height;

        public SnowManager()
        {
            snows = new List<Snow>();
            width = Console.WindowWidth - 2;
            height = Console.WindowHeight - 2;
        }
        public void AddSnow(int count)
        {
            for(int i=0;i<count;i++)
            {
                snows.Add(CreateNewSnow());
            }
        }
        public void AddSingleSnow(Snow snow)
        {
            snows.Add(snow);
        }
        public void StartSimulation()
        {
            Console.Clear();
            ShowAll();
            MakeAllSteps();
            System.Threading.Thread.Sleep(10);
        }
        private void ShowAll()
        {
            for (int i = 0; i < snows.Count; i++)
            {
                snows[i].Show();
            }
        }
        private void MakeAllSteps()
        {
            for (int i = 0; i < snows.Count; i++)
            {
                snows[i].MakeStep(height);
            }
            
        }
        private Snow CreateNewSnow()
        {
            int x = rnd.Next(0,width);
            int y = 0;
            float speed = rnd.Next(1, 3);
            char face = faces[rnd.Next(0, faces.Length)];

            Snow snow = new Snow(x,y,speed,face);
            return snow;
        }

    }
}
