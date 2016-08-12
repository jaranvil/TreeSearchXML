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
    public partial class SearchForm : Form
    {
        private TreeView theTree;
        private int resultCount = 0;

        public SearchForm(TreeView theTree)
        {
            InitializeComponent();
            this.theTree = theTree;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            resultCount = 0;
            ResetTree();
            theTree.CollapseAll();
            resultsTreeView.Nodes.Clear();
            SearchTree(tbNodeName.Text);     
        }

        private void SearchTree(string query)
        {            
            TreeNodeCollection nodes = theTree.Nodes;
            foreach (TreeNodeWrapper n in nodes)
            {
                SearchNode(n, query);
            }
            Console.WriteLine(resultCount+"");
        }

        private void SearchNode(TreeNodeWrapper theNode, string query)
        {
            if (theNode.Text.IndexOf(query, 0, StringComparison.CurrentCultureIgnoreCase) != -1)
            {
                resultCount++;
                ExpandNode(theNode);
                theNode.isSearchResult = true;                
                TreeNodeWrapper clone = (TreeNodeWrapper)theNode.Clone();
                theNode.BackColor = Color.Yellow;
                resultsTreeView.Nodes.Add(clone);
            }
         
            foreach (TreeNodeWrapper tn in theNode.Nodes)
            {
                SearchNode(tn, query);
            }
        }

        private void ExpandNode(TreeNodeWrapper node)
        {
            while (node != null)
            {
                node.Expand();
                node = (TreeNodeWrapper)node.Parent;
            }
        }

        private void ResetTree()
        {
            TreeNodeCollection nodes = theTree.Nodes;
            foreach (TreeNodeWrapper n in nodes)
            {
                ResetNode(n);
            }
        }

        private void ResetNode(TreeNodeWrapper theNode)
        {

            theNode.isSearchResult = false;
            theNode.BackColor = Color.White;

            foreach (TreeNodeWrapper tn in theNode.Nodes)
            {
                ResetNode(tn);
            }
        }

        

        private void SearchForm_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        
    }
}
