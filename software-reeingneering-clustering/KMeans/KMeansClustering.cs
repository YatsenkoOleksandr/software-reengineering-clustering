using software_reeingneering_clustering.Cluster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace software_reeingneering_clustering.KMeans
{
    class KMeansClustering : IClustering
    {
        private int ClusterNumber = 0;

        public KMeansClustering(int ClusterNumber)
        {
            this.ClusterNumber = ClusterNumber;
        }

        public List<INode> Clusterize(List<INode> rawData)
        {
            List<INode> clusters = InitializeCentroids(rawData);

            bool changed = true;
            bool success = true;

            int maxIteration = rawData.Count * 10;
            int iteration = 0;

            while (success && changed && iteration < maxIteration)
            {
                iteration++;
                success = UpdateClusterMembership(clusters, rawData);
                changed = CalculateClusterMembership(clusters, rawData);
            }

            return clusters;
        }

        private List<INode> InitializeCentroids(List<INode> rawData)
        {
            List<INode> centroids = new List<INode>(ClusterNumber);

            // Create k-clusters
            for(int i = 0; i < ClusterNumber; i++)
            {
                Node centroidCluster = new Node("Cluster #" + i, i); 
            }

            for (int i = 0; i < rawData.Count; i++)
            {
                // Copy class nodes
                List<INode> classMethods = new List<INode>(rawData[i].Methods.Count);                
                for(int j = 0; j < rawData[i].Methods.Count; j++)
                {
                    Method classMethod = new Method(rawData[i].Methods[j].Name);
                    classMethods.Add(classMethod);
                }
                INode classNode = new Node(rawData[i].Name, classMethods);

                // Select cluster
                int centroidId = i % ClusterNumber;

                // Save parent cluster id
                classNode.ClusterId = centroidId;
                rawData[i].ClusterId = centroidId;

                // Move class to one of the clusters
                centroids[centroidId].Childs.Add(classNode);
            }
            return centroids;
        }


        private bool UpdateClusterMembership(List<INode> clusters, List<INode> classes)
        {
            if (ClusterIsEmpty(clusters))
            {
                return false;
            }

            for(int i = 0; i < classes.Count; i++)
            {
                for(int j = 0; j < clusters.Count; j++)
                {
                    int classInClusterIndex = clusters[j].Childs.FindIndex(node => node.Name == classes[i].Name);
                    // There no class in current cluster
                    if (classInClusterIndex == -1)
                    {
                        continue;
                    }
                    
                    INode classInCluster = clusters[j].Childs[classInClusterIndex];
                    int oldClusterId = classInCluster.ClusterId;
                    int newClusterId = classes[i].ClusterId;
                    // Move class to another cluster if it is required
                    if (oldClusterId != newClusterId)
                    {
                        clusters[newClusterId].Childs.Add(classInCluster);
                        clusters[oldClusterId].Childs.RemoveAt(classInClusterIndex);
                    }
                    break;
                }
            }
            return true;
        }

        private bool CalculateClusterMembership(List<INode> clusters, List<INode> classes)
        {
            bool changed = false;            

            for(int i = 0; i < classes.Count; i++)
            {
                int newClusterId = -1;
                int min_distance = -1;
                double distance = -1;
                for (int k = 0; k < ClusterNumber; k++)
                {
                    // Distance - it is similarity of entities
                    // Max similarity means that distance between entities is minimal
                    distance = NodeSimilarity.JaccardCoefficient(clusters[k], classes[i]);
                    if (newClusterId == -1 || distance > min_distance)
                    {
                        newClusterId = k;
                        distance = min_distance;
                    }
                }

                // Mark class to move into another cluster
                if (newClusterId != classes[i].ClusterId)
                {
                    classes[i].ClusterId = newClusterId;
                    changed = true;
                }
            }
            return changed;
        }



        private bool ClusterIsEmpty(List<INode> clusters)
        {
            foreach(var cluster in clusters)
            {
                if (cluster.Childs.Count == 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
