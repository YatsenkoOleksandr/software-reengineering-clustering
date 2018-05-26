using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace software_reeingneering_clustering.Cluster
{
    class Method : INode
    {
        public List<INode> Childs => new List<INode>();
        public string Name { get; set; }
        public List<INode> Methods { get; }

        public Method(string name)
        {
            Name = name;
        }
    }
}
