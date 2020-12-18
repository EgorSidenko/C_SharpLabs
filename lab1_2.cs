using Sidenko.lab01.Task02.ClassLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sidenko.lab01.Task02.ClassLib;

namespace Task02.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            geometric_figure figure1 = new geometric_figure();
            geometric_figure figure2 = new geometric_figure();
            geometric_figure figure3 = new geometric_figure();

            figure1.setName("Squere");
            figure1.setX(0);
            figure1.setY(0);
            figure1.setMultiply(1);
            figure1.setRadius(2);
            figure1.print();


            figure2.setName("Circle");
            figure2.setX(0.5);
            figure2.setY(0.5);
            figure2.setMultiply(2);
            figure2.setRadius(4);
            figure2.print();

            figure2.setName("triangle");
            figure2.setX(1.25);
            figure2.setY(1.25);
            figure2.setMultiply(2);
            figure2.setRadius(9);
            figure2.print();
        }
    }
}
