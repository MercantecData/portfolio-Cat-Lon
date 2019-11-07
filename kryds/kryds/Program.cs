using System;

namespace kryds
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] grid = { " ", " ", " ", " ", " ", " ", " ", " ", " ", };
            bool end = false;
            Console.WriteLine("\nKryds vælg dit nummer 1-2: ");
            int krydsNum = int.Parse(Console.ReadLine());
            if (krydsNum == 1)
            {
                Console.WriteLine("Bolle dit nummer er 2");
            }
            else
            {
                Console.WriteLine("Bolle dit nummer er 1");
            }
            bool krydsStart = NumCheck(krydsNum);
            if (krydsStart)
            {
                while (end == false)
                {
                    PrintBoard(grid);
                    Console.WriteLine("Kryds' tur!\n Vælg hvor du vil have dit kryds:\n top venstre(TV)  top midt(TM) top højre(TH)\n midt venstre(MV) midt midte(MM) midt højre(MH)\n bund venstre(BV) bund midte(BM) bund højre(BH)");
                    PrintBoard(grid);
                    AChecker(grid, "X");
                    end = Wincheck(grid, "X");
                    if (end == false)
                    {
                        Console.WriteLine("Bolles tur!\n Vælg hvor du vil have din bolle:\n top venstre(TV)  top midt(TM) top højre(TH)\n midt venstre(MV) midt midte(MM) midt højre(MH)\n bund venstre(BV) bund midte(BM) bund højre(BH)");
                        PrintBoard(grid);
                        AChecker(grid, "O");
                        end = Wincheck(grid, "O");
                    }
                }
            }
            else
            {
                while (end == false)
                {
                    PrintBoard(grid);
                    Console.WriteLine("Bolles tur!\n Vælg hvor du vil have din bolle:\n top venstre(TV) top midt(TM) top højre(TH)\n midt venstre(MV) midt midte(MM) midt højre(MH)\n bund venstre(BV) bund midte(BM) bund højre(BH)");
                    AChecker(grid, "O");
                    PrintBoard(grid);
                    end = Wincheck(grid, "O");
                    if (end == false)
                    {
                        Console.WriteLine("Kryds' tur!\n Vælg hvor du vil have dit kryds:\n top venstre(TV) top midt(TM) top højre(TH)\n midt venstre(MV) midt midte(MM) midt højre(MH)\n bund venstre(BV) bund midte(BM) bund højre(BH)");
                        AChecker(grid, "X");
                        PrintBoard(grid);
                        end = Wincheck(grid, "X");
                    }
                }
            }
            //Lader kryds gætte på et nummer hvor at Bolle får det ikke brugte ud af de to og bestemmer derved hvem der starter
            static bool NumCheck(int num)
            {
                Random rnd = new Random();
                int rNum = rnd.Next(1, 3);
                Console.WriteLine($"nummer: {rNum} starter");
                if (num == rNum)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            //Printer "brættet" for at vise brugeren hvor at deres krydser og boller ligger
            static void PrintBoard(string[] grid)
            {
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~");
                Console.WriteLine($"{grid[0]}|{grid[1]}|{grid[2]}");
                Console.WriteLine("-----");
                Console.WriteLine($"{grid[3]}|{grid[4]}|{grid[5]}");
                Console.WriteLine("-----");
                Console.WriteLine($"{grid[6]}|{grid[7]}|{grid[8]}");
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~");
            }

            //Tjekker om kryds eller bolle har vundet
            static bool Wincheck(string[] grid, string xOrNot)
            {

                if (grid[0] == xOrNot && grid[1] == xOrNot && grid[2] == xOrNot || grid[3] == xOrNot && grid[4] == xOrNot && grid[5] == xOrNot || grid[6] == "X" && grid[7] == "X" && grid[8] == "X" || grid[0] == "X" && grid[3] == "X" && grid[6] == "X" || grid[1] == "X" && grid[4] == "X" && grid[7] == "X" || grid[7] == "X" && grid[4] == "X" && grid[1] == "X" || grid[2] == "X" && grid[5] == "X" && grid[8] == "X" || grid[0] == "X" && grid[4] == "X" && grid[8] == "X" || grid[2] == "X" && grid[4] == "X" && grid[6] == "X")
                {
                    Console.WriteLine("Kryds vinder!");
                    return true;
                }
                else if (grid[0] == "O" && grid[1] == "O" && grid[2] == "O" || grid[3] == "O" && grid[4] == "O" && grid[5] == "O" || grid[6] == "O" && grid[7] == "O" && grid[8] == "O" || grid[0] == "O" && grid[3] == "O" && grid[6] == "O" || grid[1] == "O" && grid[4] == "O" && grid[7] == "O" || grid[7] == "O" && grid[4] == "O" && grid[1] == "O" || grid[2] == "O" && grid[5] == "O" && grid[8] == "O" || grid[0] == "O" && grid[4] == "O" && grid[8] == "O" || grid[2] == "O" && grid[4] == "O" && grid[6] == "O")
                {
                    Console.WriteLine("Bolle vinder!");
                    return true;
                }
                else if (grid[0] != " " && grid[1] != " " && grid[2] != " " && grid[3] != " " && grid[4] != " " && grid[5] != " " && grid[6] != " " && grid[7] != " " && grid[8] != " ")
                {
                    Console.WriteLine("Ingen vandt ;(");
                    return true;
                }
                else
                {
                    return false;
                }
            }

            //Tjekker om det sted hvor kryds/bolle prøver at placerer deres brik hvorvidt det er i brug og hvis ikke ændrer den grid[]
            static void AChecker(string[] grid, string xOrNot)
            {
                bool correction;
                do
                {
                    string uInput = Console.ReadLine();
                    switch (uInput)
                    {

                        case "TV":
                            if (grid[0] == " ")
                            {
                                grid[0] = xOrNot;
                                correction = false;
                            }
                            else
                            {
                                Console.WriteLine("den plads er allerede taget!");
                                correction = true;
                            }
                            break;
                        case "TM":
                            if (grid[1] == " ")
                            {
                                grid[1] = xOrNot;
                                correction = false;
                            }
                            else
                            {
                                Console.WriteLine("den plads er allerede taget!");
                                correction = true;
                            }
                            break;
                        case "TH":
                            if (grid[2] == " ")
                            {
                                grid[2] = xOrNot;
                                correction = false;
                            }
                            else
                            {
                                Console.WriteLine("den plads er allerede taget!");
                                correction = true;
                            }
                            break;
                        case "MV":
                            if (grid[3] == " ")
                            {
                                grid[3] = xOrNot;
                                correction = false;
                            }
                            else
                            {
                                Console.WriteLine("den plads er allerede taget!");
                                correction = true;
                            }
                            break;
                        case "MM":
                            if (grid[4] == " ")
                            {
                                grid[4] = xOrNot;
                                correction = false;
                            }
                            else
                            {
                                Console.WriteLine("den plads er allerede taget!");
                                correction = true;
                            }
                            break;
                        case "MH":
                            if (grid[5] == " ")
                            {
                                grid[5] = xOrNot;
                                correction = false;
                            }
                            else
                            {
                                Console.WriteLine("den plads er allerede taget!");
                                correction = true;
                            }
                            break;
                        case "BV":
                            if (grid[6] == " ")
                            {
                                grid[6] = xOrNot;
                                correction = false;
                            }
                            else
                            {
                                Console.WriteLine("den plads er allerede taget!");
                                correction = true;
                            }
                            break;
                        case "BM":
                            if (grid[7] == " ")
                            {
                                grid[7] = xOrNot;
                                correction = false;
                            }
                            else
                            {
                                Console.WriteLine("den plads er allerede taget!");
                                correction = true;
                            }
                            break;
                        case "BH":
                            if (grid[8] == " ")
                            {
                                grid[8] = xOrNot;
                                correction = false;
                            }
                            else
                            {
                                Console.WriteLine("den plads er allerede taget!");
                                correction = true;
                            }
                            break;
                        default:
                            Console.WriteLine("prøv igen");
                            correction = true;
                            break;
                    }
                } while (correction == true);
            }

        }
    }
}