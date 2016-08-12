using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace TreeXML
{
    public partial class ParentForm : Form
    {
        private string fileName;

        public ParentForm(string fileName)
        {
            InitializeComponent();
            this.fileName = fileName;
        }

        private void ParentForm_Load(object sender, EventArgs e)
        {
            try
            {
                // SECTION 1. Create a DOM Document and load the XML data into it.
                XmlDocument dom = new XmlDocument();
                dom.Load(fileName);

                // SECTION 2. Initialize the TreeView control.
                mainTreeView.Nodes.Clear();
                mainTreeView.Nodes.Add(new TreeNodeWrapper(dom.DocumentElement.Name));
                TreeNodeWrapper tNode = new TreeNodeWrapper();
                tNode = (TreeNodeWrapper)mainTreeView.Nodes[0];

                // SECTION 3. Populate the TreeView with the DOM nodes.
                AddNode(dom.DocumentElement, tNode);
                //mainTreeView.ExpandAll();

             
            }
            catch (XmlException xmlEx)
            {
                MessageBox.Show(xmlEx.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            SearchForm searchForm = new SearchForm(mainTreeView);
            searchForm.MdiParent = this;
            searchForm.Show();
        }

        private void AddNode(XmlNode inXmlNode, TreeNodeWrapper inTreeNode)
        {
            XmlNode xNode;
            TreeNodeWrapper tNode;
            XmlNodeList nodeList;
            int i;

            // Loop through the XML nodes until the leaf is reached.
            // Add the nodes to the TreeView during the looping process.
            if (inXmlNode.HasChildNodes)
            {
                nodeList = inXmlNode.ChildNodes;
                for (i = 0; i <= nodeList.Count - 1; i++)
                {
                    xNode = inXmlNode.ChildNodes[i];
                    inTreeNode.Nodes.Add(new TreeNodeWrapper(xNode.Name));
                    tNode = (TreeNodeWrapper)inTreeNode.Nodes[i];
                    AddNode(xNode, tNode);
                }
            }
            else
            {
                // Here you need to pull the data from the XmlNode based on the
                // type of node, whether attribute values are required, and so forth.
                inTreeNode.Text = (inXmlNode.OuterXml).Trim();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
        }

    }
}
