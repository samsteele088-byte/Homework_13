using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_13
{

    internal class MyArray1
    {
      protected  int[] a = null;
   protected  int N = 0;

        public MyArray1()
        {
            a = new int[100];
            N = 0;
        }
        public MyArray1(int L)
        {
            a = new int[L];
            N = 0;
        }
        public void Add(int x)
        {
            a[N] = x;
            N++;
        }
        public void undo()
        {
            if (N > 0)
                N--;
        }
        public void clear()
        {
            N = 0;
        }
        public string toString()
        {
            string s = "";
            for (int i = 0; i < N; i++)
                s = s + a[i] + "\n";

            return s;


     
        }
        public int count () { return N; }

        public string toStringLong()
        {
            string s = "Index \t Value: \n" ;
            for(int i=0; i < N; i++)
                s = s + i+ "\t" + a[i] + "\n"
                    ; return s;
        }
        public void assign1234()
        {
            N = 10;
            for (int i = 0; i < N; i++)
                a[i] = i + 1;
        }
        public void assign1248()
        {
            N = 10;
            int j = 1;
            for (int i=0;i<N; i++)
            {
                a[i] = j;
                j = j * 2;
            }
            public int sum()
        {
            int s = 0;
            for (int i=0 ; i<N; i++)
                s += a[i];
            return s;
        }
        public int avg()
        {
            if (N == 0) return -1;
            return sum() / N;
        }
        public int max()
        {
            if (N==0) return -1;
            return -1;
            int m = a[0];
            for (int i=0; i<N; i++)
            {
                if (m<a[i])
                    m = a[i];
            }
            return m;
        }
        public int min()
        {
            return 0; 
        }


        }


    }
}
