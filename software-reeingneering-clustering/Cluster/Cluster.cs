using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace software_reeingneering_clustering.Cluster
{
    class Cluster : INode
    {
        private List<INode> _childs = new List<INode>();

        public List<INode> Childs => _childs.Where(node => node is Cluster).ToList();// _childs.Where(node => node is Cluster).ToList()

        public string Name { get; set; }

        public List<INode> Methods => _childs.Where(node => node is Method).ToList();

        public void Add(INode child)
        {
            _childs.Add(child);
        }

        public void AddRange(IEnumerable<INode> childs)
        {
            _childs.AddRange(childs);
        }

        public Cluster(string name, List<INode> methods)
        {
            Name = name;
            _childs = methods;
        }

        public Cluster(string name, INode left, INode right)
        {
            Name = name;
            _childs.Add(left);
            _childs.Add(right);
        }
    }
}
