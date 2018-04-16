using System;
using System.Text.RegularExpressions;

namespace TitleCapitalizationTool
{
    internal class Program
    {
        private static bool IsEnglish(string source)
        {
            return Regex.IsMatch(source, "[ -z]");
        }

        private static string InputString()
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

        private static void Capitalize(string source)
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
                new FirstAndLastRegisterDecorator(
                    new SpecialWordRegisterDecorator(
                        new DashDecorator(new PunctuationDecorator(
                            new SpaceDecorator(new DefaultStringBuilderList(source))))));
            string result = decorator.GetString(decorator.GetStringBuilderList());

            Console.WriteLine(result);
            Console.ResetColor();
        }

        private static void Execute(string context)
        {
            Capitalize(context);
            Console.WriteLine();
        }

        public static void Main(string[] commandLineArguments)
        {
            if (commandLineArguments.Length==0)
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
                    Execute(commandLineArguments[i]);
                    ++i;
                } while (i < commandLineArguments.Length);
                Console.ReadKey();
            }
        }
    }
}