using software_reeingneering_clustering.ClassEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using software_reeingneering_clustering.Cluster;
using software_reeingneering_clustering.AgglomerativeHierarchical;
using software_reeingneering_clustering.KMeans;

namespace software_reeingneering_clustering
{
    public partial class ClusterForm : Form
    {
        public ClusterForm()
        {
            InitializeComponent();
        }

        private void clusterButton_Click(object sender, EventArgs e)
        {
            IClustering clustering = new AgglomerativeHierarchicalClustering();
            Clustering(clustering);
        }

        private void Clustering(IClustering clusterAlgorithm)
        {
            DialogResult dialogResult = openClassMethodsFile.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                string inputfile = openClassMethodsFile.FileName;

                Dictionary<string, List<string>> rawClasses = ClassParser.ReadClassEntities(inputfile);

                List<INode> clusters = initializeClusters(rawClasses);

                List<INode> clustered = clusterAlgorithm.Clusterize(clusters);

                ReloadTree(clustered[0]);
            }
        }

        private List<INode> initializeClusters(Dictionary<string, List<string>> rawClasses)
        {
            List<INode> clusters = new List<INode>();

            foreach(var className in rawClasses.Keys)
            {
                List<INode> methodNodes = new List<INode>();
                foreach(var methodName in rawClasses[className])
                {
                    methodNodes.Add(new Method(methodName));
                }

                Node classCluster = new Node(className, methodNodes);
                clusters.Add(classCluster);
            }

            return clusters;
        }

        private void ReloadTree(INode root)
        {
            trvResultTree.Nodes.Clear();
            trvResultTree.Nodes.Add(GetTreeNode(root));
        }

        private TreeNode GetTreeNode(INode rootNode)
        {
            var node = new TreeNode(rootNode.Name);
            node.ImageIndex = (int)rootNode.ImageType;
            node.SelectedImageIndex = (int)rootNode.ImageType;
            if (rootNode.ImageType == NodeType.Class)
            {
                node.Nodes.AddRange(rootNode.Methods.Select(x =>
                {
                    var res = new TreeNode(x.Name);
                    res.ImageIndex = (int)x.ImageType;
                    res.SelectedImageIndex = (int)x.ImageType;
                    return res;
                }).ToArray());
            }
            else
            {
                foreach (var children in rootNode.Childs)
                    node.Nodes.Add(GetTreeNode(children));
            }

            return node;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int clusterNumber = (int)numericUpDown1.Value;

            IClustering clustering = new KMeansClustering(clusterNumber);

            Clustering(clustering);
        }
    }
}
