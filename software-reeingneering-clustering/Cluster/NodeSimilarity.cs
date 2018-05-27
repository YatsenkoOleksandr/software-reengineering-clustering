using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace software_reeingneering_clustering.Cluster
{
    static class NodeSimilarity
    {
        public static double JaccardCoefficient(INode firstNode, INode secondNode)
        {
            IEnumerable<string> firstMethods = firstNode.Methods.Select(m => m.Name);
            IEnumerable<string> secondMethods = secondNode.Methods.Select(m => m.Name);

            IEnumerable<string> commonMethods = firstMethods.Intersect(secondMethods);
            double commonMethodsCount = commonMethods.Count();

            IEnumerable<string> firstUniqueMethods = firstMethods.Except(commonMethods);
            double firstUniqueMethodsCount = firstUniqueMethods.Count();

            IEnumerable<string> secondUniqueMethods = secondMethods.Except(commonMethods);
            double secondUniqueMethodsCount = secondUniqueMethods.Count();

            double coef = commonMethodsCount / (commonMethodsCount + firstUniqueMethodsCount + secondUniqueMethodsCount);

            return coef;
        }
    }
}
