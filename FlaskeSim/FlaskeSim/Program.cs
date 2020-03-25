using System;

namespace FlaskeSim
{
    class Program
    {
        static void Main(string[] args)
        {

            var bottle1 = new Bottle(5);
            var bottle2 = new Bottle(3);
            var wanted = 2;
            var OperationsNO = 1;
            while (true)
            {
                Console.WriteLine("Operations Currently running : " + OperationsNO);
                var Operations = new int[OperationsNO];

                while (true)
                {
                    doOps(Operations, bottle1, bottle2);
                    if (bottle1.Content == wanted || bottle2.Content == wanted)
                    {
                        Console.WriteLine("Sultion found");
                        showOps(Operations);
                        Environment.Exit(0);
                    }

                    var sucsess = updateOps(Operations);
                    if (!sucsess) break;

                }
                OperationsNO++;
            }
        }

        private static bool updateOps(int[] operations)
        {
            int i;
            for (i = operations.Length - 1; i >= 0; i--)
            {
                if (operations[i] < 8)
                {
                    operations[i]++;
                    break;
                }

                operations[i] = 0;

            }
            return i != -1;
        }

        private static void showOps(int[] operations)
        {
            var opText = new string[]
            {

                "Fill Bottle 1 from fount",
                "Fill Bottle 2 from fount",
                "Empty Bottle 1 in Bottle 2",
                "Empty Bottle 2 in Bottle 1",
                "Fill Flask 2 from Flask 1",
                "Fill Flask 1 from Flask 2",
                "Empty Bottle 1 in endless Void",
                "Empty Bottle 2 in endless Void",

            };
            foreach (var operation in operations)
            {
                Console.WriteLine(opText[operation]);
            }
        }


        private static void doOps(int[] ops, Bottle bottle1, Bottle bottle2)
        {
            bottle1.EmptyFlask();
            bottle2.EmptyFlask();
            foreach (var operation in ops)
            {
                if (operation == 0) bottle1.FillToCapFromVoid();
                else if (operation == 1) bottle2.FillToCapFromVoid();
                else if (operation == 2)
                {
                    if (bottle1.isEmpty()) break;
                    var success = bottle2.Fill(bottle1.EmptyFlask());
                    if (!success) break;
                }
                else if (operation == 3)
                {
                    if (bottle2.isEmpty()) break;
                    var success = bottle1.Fill(bottle2.EmptyFlask());
                    if (!success) break;
                }
                else if (operation == 4)
                {
                    var success = bottle2.FillToCap(bottle1);
                    if (!success) break;
                }

                else if (operation == 5)
                {
                    var success = bottle1.FillToCap(bottle2);
                    if (!success) break;
                }
                else if (operation == 6)
                {
                    bottle1.EmptyFlask();
                }
                else if (operation == 7)
                {
                    bottle2.EmptyFlask();
                }
            }
        }
    }
}
