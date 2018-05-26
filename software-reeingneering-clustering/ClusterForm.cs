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
            DialogResult dialogResult = openClassMethodsFile.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                string inputfile = openClassMethodsFile.FileName;

                Dictionary<string, IList<string>> classes = ClassParser.ReadClassEntities(inputfile);
            }
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
            node.Nodes.AddRange(rootNode.Methods.Select(x =>
            {
                var res = new TreeNode(x.Name);
                res.ImageIndex = (int)x.ImageType;
                res.SelectedImageIndex = (int)x.ImageType;
                return res;
            }).ToArray());

            foreach (var children in rootNode.Childs)
                node.Nodes.Add(GetTreeNode(children));

            return node;
        }
    }
}
