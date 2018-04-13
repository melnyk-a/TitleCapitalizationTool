using System.Collections.Generic;

namespace TitleCapitalizationTool
{
    internal static class ApplicationLibrary
    {
        private static List<char> _charLibrary = new List<char>{
            ',', ';', ':', '-', '.', '!', '?' };
        private static List<string> _articles = new List<string> { "a", "an", "the" };
        private static List<string> _unions = new List<string>{
            "and", "but", "for", "nor", "so", "yet" };
        private static List<string> _preposition = new List<string>{
            "at", "by", "in", "of", "on", "or", "out", "to", "up"};

        public static bool ContainsPunctuation(char symbol)
        {
            return _charLibrary.Contains(symbol);
        }

        public static bool IsSpecialWorld(string word)
        {
            return _articles.Contains(word) ||
                _unions.Contains(word) ||
                _preposition.Contains(word);
        }
    }
}