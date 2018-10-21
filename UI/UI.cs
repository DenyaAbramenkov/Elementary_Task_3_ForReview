using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elementary_Task_3
{
    public class UI_Console
    {

        public static void CallMenu()
        {
            const int RIGHT_COUNT_ARGS = 5;
            const int START_COUNT_OF_ARGS = 1;
            List<Triangle> triangleList = new List<Triangle>();
            string[] args = Environment.GetCommandLineArgs();
            if (args.Length == START_COUNT_OF_ARGS)
            {
                bool continueNext = false;
                do
                {
                    try
                    {
                        continueNext = false;
                        Console.WriteLine("Enter name and sides for a new triangle:");
                        string[] input = Console.ReadLine().Split(new char[] { ' ', ',' });
                        if (input.Length == RIGHT_COUNT_ARGS)
                        {
                            string name = input[1].ToLower();
                            string sideA = input[2];
                            string sideB = input[3];
                            string sideC = input[4];

                            Triangle triangle = Triangle.TriangleInitializer(name, sideA, sideB, sideC);
                            triangleList.Add(triangle);
                            triangleList.Sort();
                            Console.WriteLine(" Triangles list:");
                            foreach (Triangle trngl in triangleList)
                            {
                                Console.WriteLine(trngl.ToString());
                            }
                            Console.WriteLine("To continue press y/Y or yes/YES:");
                            string userAnsver = Console.ReadLine().ToLower();
                            continueNext = (userAnsver == "y" | userAnsver == "yes") ? true : false;
                        }
                        else
                        {
                            Console.WriteLine("Not enough ars to build triangle");
                        }
                    }
                    catch(Exception)
                    {
                        Instruction();
                    }
                }
                while (continueNext);
            }
            else
            {
                Instruction();
            }
        }
        public static void Instruction()
        {
            Console.WriteLine("To build new triangle you should input 4 args:"
                              + Environment.NewLine
                              + "Name, sideA, sideB, sideC"
                              + Environment.NewLine
                              + "Sides must be in double format");
        }
        
    }
}
