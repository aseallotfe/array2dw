using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Matrix
    {

        private int[,] re;
        private int x;
        private int y;
        public Matrix(int x,int y)
        {
            this.x = x;
            this.y = y;
            re = new int[x, y]; 

        }
        public void ReadMatrix() 
        {
            Console.WriteLine("enter the elements");
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    re[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        public void Transpose()
        {
           int[,] trre = new int[x, y];
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j <y;j ++)
                {
                    trre[j,i] = re[i, j];

                }
            } re = trre;
            
            int temp = x;
            x = y;
            y = temp;
          
        } 
        public void print()
        {
            Console.WriteLine("the elements is");

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.WriteLine($"{re[i, j]}");
                }
                
            }

        }

    }
}
