using System.Collections.Generic;
using System.Text;

namespace Leetcode.Random
{
    // Q. 890, Medium
    class FindAndReplacePatternProblem
    {
        public IList<string> FindAndReplacePattern(string[] words, string pattern)
        {
            var mappedPattern = TransformToPrimitive(pattern);
            var patternLength = mappedPattern.Length;
            var result = new List<string>();

            foreach(var item in words)
            {
                if(item.Length == patternLength)
                {
                    var transformedWord = TransformToPrimitive(item);
                    if(string.Equals(transformedWord, mappedPattern))
                    {
                        result.Add(item);
                    }
                }
            }

            return result.ToArray();
        }

        private string TransformToPrimitive(string pattern)
        {
            var currentChar = 'a';
            var characterMapping = new Dictionary<char, char>();
            StringBuilder transformed = new StringBuilder();

            for(int i = 0; i < pattern.Length; i++)
            {
                var mappedCharacter = currentChar;
                if(!characterMapping.ContainsKey(pattern[i]))
                {
                    characterMapping.Add(pattern[i], currentChar);
                    currentChar++;
                }
                else
                {
                    mappedCharacter = characterMapping[pattern[i]];
                }

                transformed.Append(mappedCharacter);
            }

            return transformed.ToString();
        }
    }
}
