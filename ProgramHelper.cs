using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3OOP
{
    internal class ProgramHelper : ProgramConverter, ICodeChecker
    {
        public bool CodeCheckSyntax(string code, Languages language)
        {
            if (language == Languages.CSharp)
            {
                Console.WriteLine("C Sharp");
            }
            else
            {
                Console.WriteLine("Visual Basic");
            }
            return true;
        }
    }
}
