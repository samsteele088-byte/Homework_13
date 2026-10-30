using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Homework_13
{
    class MyArray2 : MyArray1

    {
        public MyArray2() : base()
        {

        }
        public MyArray2(int l) : base(l)
        {

        }

        public int sum()
        {
            int s = 0;
            for (int i = 0; i < N; i++)
                s = s + a[i];
            return s;
        }

        public string grade()
        {
            int a = avg();
            string g = "";
            if (a > 90)
                g = "A";
            else if (a >= 80)
                g = "B";
            else if (a >= 70)
                g = "C";
            else if (a >= 60)
                g = "D";
            else
                g = "F";
            return g;
        }

        public void cash4()
        {
            N = 4;
            Random r = new Random();
            for (int i = 0; i < N;i++)
                a[i] = r.Next(0,10);
        }

        public int search (int x)
        {
            for (int i = 0; i < N; i++)
            {
                if (x == a[i])
                    return i;
            }
            return -1;
        }
        
        
      















        internal class Array2
        {
        }
    }
}



    

