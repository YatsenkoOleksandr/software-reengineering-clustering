using software_reeingneering_clustering.Cluster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace software_reeingneering_clustering.AgglomerativeHierarchical
{
    class AgglomerativeHierarchicalClustering : IClustering
    {
        public List<INode> Cluster(List<INode> rawData)
        {
            throw new NotImplementedException();
        }

        private double JaccardCoefficient(INode node1, INode node2)
        {


            return 0;
        }

        private bool ClusterStep(List<INode> data, ref int clusterCounter)
        {
            double[,] distances = new double[data.Count, data.Count];

            double minimal_distance = -1;
            int firstNodeToJoinIndex = -1;
            int secondNodeToJoinIndex = -1;

            for(int i = 0; i < data.Count; i++)
            {
                for(int j = 0; j < data.Count; j++)
                {
                    if (i != j)
                    {
                        double distance = JaccardCoefficient(data[i], data[j]);
                        distances[i, j] = distance;

                        // Max distance means that object are most similar
                        if (minimal_distance == -1 || distance > minimal_distance)
                        {
                            minimal_distance = distance;
                            firstNodeToJoinIndex = i;
                            secondNodeToJoinIndex = j;
                        }
                    }
                }
            }

            // No joined clusters
            if (minimal_distance == -1)
            {
                return false;
            }

            INode firstNode = data[firstNodeToJoinIndex];
            INode secondNode = data[secondNodeToJoinIndex];
            string clusterName = "Cluster #" + clusterCounter++;

            // Join clusters and remove them from list
            INode joinedNode = new Cluster.Cluster(clusterName, firstNode, secondNode);
            data.RemoveAt(firstNodeToJoinIndex);
            if (firstNodeToJoinIndex < secondNodeToJoinIndex)
            {
                secondNodeToJoinIndex--;
            }
            data.RemoveAt(secondNodeToJoinIndex);
            data.Add(joinedNode);

            return true;
        }
    }
}
