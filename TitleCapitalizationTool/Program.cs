using System;
using System.Text.RegularExpressions;

namespace TitleCapitalizationTool
{
    class Program
    {
        static bool IsEnglish(string source)
        {
            return Regex.IsMatch(source, "[ -z]");
        }
        static string InputString()
        {
            Console.Write("Enter title to capitalize: ");
            Console.ForegroundColor = ConsoleColor.Red;
            string input = String.Empty;
            int left = Console.CursorLeft;
            int top = Console.CursorTop;
            while (input == String.Empty)
            {
                Console.SetCursorPosition(left, top);
                input = Console.ReadLine();
            }
            Console.ResetColor();
            return input;
        }
        static void Capitalize(string source)
        {
            if (source == null)
            {
                throw new ArgumentNullException();
            }
            if (!IsEnglish(source))
            {
                throw new ArgumentException("Incorrect language");
            }
            Console.Write("Capitalized title: ");
            Console.ForegroundColor = ConsoleColor.Green;

            StringBuilderList decorator =
                new FirsAndLastRegisterDecorator(
                    new SpecialWordRegisterDecorator(
                        new DashDecorator(new PunctuationDecorator(
                            new SpaceDecorator(new DefaultStringBuilderList(source))))));
            string str = decorator.GetString(decorator.GetStringBuilderList());

            Console.WriteLine(str);
            Console.ResetColor();
        }
        static void Execute(string context)
        {
            Capitalize(context);
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            if (args.Length==0)
            {
                do
                {
                    Execute(InputString());
                } while (true);
            }
            else
            {
                int i = 0;
                do
                {
                    Execute(args[i]);
                    ++i;
                } while (i < args.Length);
                Console.ReadKey();
            }
        }
    }
}
