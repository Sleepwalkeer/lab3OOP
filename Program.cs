using lab3OOP;

    ProgramConverter[] converters = new ProgramConverter[2];
    converters[0] = new ProgramConverter();
    converters[1] = new ProgramHelper();

    foreach (var converter in converters)
    {
        if (converter is ICodeChecker)
        {
            string input = converter.ConvertToCSharp("из визуальной базы в цэ хэштэг");
            bool isWorking = ((ICodeChecker)converter).CodeCheckSyntax(input, Languages.CSharp);
            Console.WriteLine("Работает? " + Convert.ToString(isWorking));
        }
        else
        {
            Console.WriteLine("ICodeChecker is not working at: " + Convert.ToString(converter.GetType()));
        }
    }
    Console.ReadKey();