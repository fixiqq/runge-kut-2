using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rudge_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 0, b = 1, h = 0.05, x0 = 0, y0 = 2, y; //Задание входных данных
            double it = (b - a) / h;
            Console.WriteLine($"a = {a}\nb = {b}\nh = {h}\nx(0) = {x0}\ny(0) = {y0}\nf(x,y) = x^(1/2)*y \nКоличество итераций = {it + 1}\n");
            double f = perems(x0, y0); ;
            double r1 = h * f;
            double x2 = x0 + h / 2;
            double y2 = y0 + r1 / 2;
            double r2 = h * perems(x2, y2);
            double x3 = x0 + h / 2;
            double y3 = y0 + r2 / 2;
            double r3 = h * perems(x3, y3); ;
            double x4 = x0 + h;
            double y4 = y0 + r3;
            double r4 = h * perems(x4, y4);
            Console.WriteLine("x = {0,6}    |||  f = {1,6}", x0, f);
            y = y0;
            for (int i = 0; i < it; i++)
            {
                x0 += h;
                y = y + (1 / (double)6) * (r1 + 2 * r2 + 2 * r3 + r4);
                f = perems(x0, y); ;
                r1 = h * f;
                x2 = x0 + h / 2;
                y2 = y + r1 / 2;
                r2 = h * perems(x2, y2);
                x3 = x0 + h / 2;
                y3 = y + r2 / 2;
                r3 = h * perems(x3, y3); ;
                x4 = x0 + h;
                y4 = y + r3;
                r4 = h * perems(x4, y4); ;
                Console.WriteLine("x = {0,6}    |||  y = {1,6}", x0, y);
            }
            Console.ReadLine();
        }
        public static double perems(double x, double y) => Math.Sqrt(x) * Math.Pow(y, 2);
    }
}