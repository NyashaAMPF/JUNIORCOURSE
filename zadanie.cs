using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

           /*Объявить 10 переменных разных типов данных. Переменные объявлять в статическом методе Main в классе Programm, которые создаются автоматически при создание консольного
           приложения в Visual Studio. Все переменные должны быть инициализированы литералами соответствующего типа. 
            дна из переменных должна содержать в своём имени цифры, но не должна начинаться с них (запрещено в C#), также следует попробовать объявить переменные которые начинаются с подчеркивания.
            2 переменных должны быть объявлены с неявным типом (var) и инициализированы литералами разных типов (true, 10). 
            Объявить статическую (static) переменную в классе Programm но вне метода Main. Объявить переменную с таким же именем внутри метода Main. Подумать над тем, будет ли это работать и почему?  
            Прочитать соглашения о написании кода на C# */


namespace ConsoleApp1
{
    class Program
    {

        static bool flatearth  = true;
        static void Main(string[] args)
        {

           

            float distance2moon = 500000;
            int reps;
            var visiblity = true;
             var numberstation = 1;

            string theme_of_stream = "number stations";
            decimal sakutin_salaryUSD = 9999999999999999999;
            byte mahatma_gandi = 255;
            bool flatearth = false;

            // it will work, but "false" will override "true" in  method "main"  because local variables have highest priority
            // работать будет, однако значение переменной будет соответствовать в рамках блока main объявленному локально.
            double _disttoNibiru = 500075364;

            reps = 10;


        }
    }
}
