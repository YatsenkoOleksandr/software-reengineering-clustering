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
        public NodeType ImageType => NodeType.Method;
        public int ClusterId { get; set; }

        public void Add(INode child) { }
        public void AddRange(IEnumerable<INode> childs) { }
        public void RemoveChildByName(string name) { }

        public Method(string name)
        {
            Name = name;
        }
    }
}
