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
    }
}
