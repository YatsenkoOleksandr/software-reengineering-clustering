using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace software_reeingneering_clustering.Cluster
{
    interface INode
    {
        List<INode> Childs { get; }
        string Name { get; set; }
        List<INode> Methods { get; }
        NodeType ImageType { get; }
        void Add(INode child);
        void AddRange(IEnumerable<INode> childs);
    }
}
