// See https://aka.ms/new-console-template for more information
using ConsoleApp3;
using System;
using System.Runtime.CompilerServices;
Console.WriteLine("enter the number of rows");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter the number of columns");
int y = Convert.ToInt32(Console.ReadLine());
Matrix str = new Matrix(x,y);
str.ReadMatrix( );
str.print();
str.Transpose();
str.print();