using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LibraryProject;

namespace CourseProject
{
    static class StartUp
    {
       
            

        

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //    var Figures = new List<BaseShape>();
            //    Console.WriteLine("Write the Figure That You Would Like To Diclare?");
            //    var input = Console.ReadLine();

            //    while (input != "end")
            //    {
            //        Console.WriteLine("Write The Parameter/s According the Figure:");
            //        var Consts = Console.ReadLine().Split();
            //        double[] figureConst = new double[Consts.Length];
            //        for (int i = 0; i < Consts.Length; i++)
            //        {
            //            var side = double.Parse(Consts[i]);
            //            figureConst[i] = side;
            //        }

            //        switch (input)
            //        {
            //            case "circle":
            //                {
            //                    if (figureConst.Length != 1)
            //                        throw new Exception("Only 1 Parimeter");

            //                    Figures.Add(new Circle(figureConst[0]));
            //                    break;
            //                }

            //            case "rectangle":
            //                {
            //                    if (figureConst.Length != 2)
            //                        throw new Exception("Only 2 Parimeters");

            //                    Figures.Add(new Rectangle(figureConst[0], figureConst[1]));
            //                    break;
            //                }

            //            case "triangle":
            //                {
            //                    if (figureConst.Length != 3)
            //                        throw new Exception("Only 3 Parimeters");

            //                    Figures.Add(new Triangle(figureConst[0], figureConst[1], figureConst[2]));
            //                    break;
            //                }
            //        }
            //        Console.WriteLine("If You want To End The Program Just Type END, If no Write The Type Of the Figure.");
            //        input = Console.ReadLine().ToLower();
            //    }
            //    foreach (var figure in Figures)
            //    {
            //        Console.WriteLine(figure);
            //        Console.WriteLine($"Area is: {figure.CalculateSurface():f2}");
            //        Console.WriteLine($"Perimeter is: {figure.CalculateParameter():f1}");
            //    }
            //}
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartWindow());
        }
    }
}

