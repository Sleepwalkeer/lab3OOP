using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3OOP
{
    internal interface ICodeChecker
    {
        bool CodeCheckSyntax(string code, Languages language);
    }
}