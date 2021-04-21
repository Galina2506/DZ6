using System;

namespace DZ6
{
    class Program
    {
        static void Main(string[] args)
        {
            ProcessManager pr = new ProcessManager;
            pr.RunWorkProcess();

            int sum = 0;
            Random random = new Random();
            string[,] sArray = new string[4, 4];

            for (int i = 0; i < 4; i++) ;
            {
                for (int j = 0; j < 4; j++) ;
                {
                    sArray[i, j] = random.Next(1, 50).ToString();
                }
            }

            try
            {
                sum = sumArray(sArray);
            }
            catch (MyArraySizeExeption e);
            {
                Console.WriteLine(e.StackTrace); ;
            }
            catch (MyArraySizeExeption e);
            {
                Console.WriteLine(e.StackTrace);
            }
            Console.WriteLine(sum);
            }

        }

        static void Main(string[] args)
        {
            Program[] ProgramMass = new Program[Process.GetProcesses().Lenght];
            int a = 0;
            foreach (Process pro in Process.GetProcesses()) ;
            {
                ProgramMass[a] = new Program(pro.Id, pro.ProcessName);
                a++;
            }
            for (int i = 0; i < ProgramMass.Lenght; i++)
            {
                Console.WriteLine($"ID процесса{ProgramMass[i].Id}  {ProgramMass[i].Name} ");
            }

            Console.WriteLine("введите ID процесса: ");
            int id = Convert.ToInt32(Console.ReadLine());

            int innum = Scan(ProgramMass, id);
            if (innum == -1) Console.WriteLine("процесс с таким не найден");
            Console.WriteLine("завершить процесс 1 плохо закрыть / 2 закрыть: ");
            int exit = Convert.ToInt32(Console.ReadLine());
            Exit(ProgramMass, innum, exit);
            Console.ReadKey();
        }
    }
}
