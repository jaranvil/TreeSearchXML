using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeXML
{
    public partial class DataStructureSearchForm : Form
    {
        CustomTreeNode tree;

        public DataStructureSearchForm(CustomTreeNode tree)
        {
            InitializeComponent();
            this.tree = tree;
        }

        private void DataStructureSearchForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = tbNodeName.Text;
        }

        public void SearchTree(string query)
        {
            for (int x = 0;x < tree.children.Count - 1;x++)
            {

            }
        }
    }
}
