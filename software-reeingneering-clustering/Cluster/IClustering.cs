using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace software_reeingneering_clustering.Cluster
{
    interface IClustering
    {
        List<INode> Cluster(List<INode> rawData);
    }
}
