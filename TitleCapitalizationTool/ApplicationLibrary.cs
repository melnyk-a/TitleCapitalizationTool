using System.Collections.Generic;

namespace TitleCapitalizationTool
{
    internal static class ApplicationLibrary
    {
        private static IEnumerable<char> _punctuators = new char[]
        {
            ',', ';', ':', '-', '.', '!', '?'
        };
        private static IEnumerable<string> _articles = new string[]
        {
            "a", "an", "the"
        };
        private static IEnumerable<string> _conjunctions = new string[]
        {
            "and", "but", "for", "nor", "so", "yet"
        };
        private static IEnumerable<string> _prepositions = new string[]
        {
            "at", "by", "in", "of", "on", "or", "out", "to", "up"
        };

        public static bool ContainsPunctuation(char symbol)
        {
            return IsContains(_punctuators, symbol);
        }

        public static bool IsSpecialWorld(string word)
        {
            return IsContains(_articles, word) ||
                IsContains(_conjunctions, word) ||
                IsContains(_prepositions, word);
        }
        private static bool IsContains<T>(IEnumerable<T> collection, T context)
        {
            bool isContains = false;
            foreach (var item in collection)
            {
                if (item.Equals(context))
                {
                    isContains = true;
                }
            }
            return isContains;
        }
    }
}