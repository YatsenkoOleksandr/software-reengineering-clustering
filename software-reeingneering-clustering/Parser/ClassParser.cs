using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace software_reeingneering_clustering.ClassEntities
{
    static class ClassParser
    {
        // "entity name"
        private const string NAME_REGEX_STRING = "\"[\\d\\w\\.\\$]+\"";

        // "class name"->"method name"
        private const string CLASSMETHOD_REGEX_STRING = NAME_REGEX_STRING + "->" + NAME_REGEX_STRING;

        public static Dictionary<string, IList<string>> ReadClassEntities(string filename)
        {
            Dictionary<string, IList<string>> classes = new Dictionary<string, IList<string>>();

            Regex classMethodRelationRegex = new Regex(CLASSMETHOD_REGEX_STRING);
            Regex nameRegex = new Regex(NAME_REGEX_STRING);
            
            using (StreamReader textReader = new StreamReader(filename))
            {
                string line;
                string className = string.Empty;
                string methodName = string.Empty;
                while((line = textReader.ReadLine()) != null)
                {
                    if (classMethodRelationRegex.IsMatch(line))
                    {
                        MatchCollection matches = nameRegex.Matches(line);
                        if (matches.Count == 2)
                        {
                            className = matches[0].Value;
                            methodName = matches[1].Value;

                            if (!classes.ContainsKey(className))
                            {
                                classes.Add(className, new List<string>());
                            }
                            classes[className].Add(methodName);
                        }
                    }
                }
            }
            return classes;
        }
    }
}
