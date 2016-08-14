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
using System.IO;

namespace TreeXML
{
    public partial class ProcessXmlForm : Form
    {
        private BackgroundWorker bw = new BackgroundWorker();
        StringBuilder output = new StringBuilder();
        String theXml;
        CustomTreeNode tree;        

        public ProcessXmlForm(string fileName, CustomTreeNode tree)
        {
            InitializeComponent();            
            theXml = System.IO.File.ReadAllText(fileName);
            this.tree = tree;

            bw.WorkerReportsProgress = true;
            bw.WorkerSupportsCancellation = true;
            bw.DoWork += new DoWorkEventHandler(bw_DoWork);
            bw.ProgressChanged += new ProgressChangedEventHandler(bw_ProgressChanged);
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);

            if (bw.IsBusy != true)
            {
                bw.RunWorkerAsync();
            }
        }

        private void btrnCancel_Click(object sender, EventArgs e)
        {
            if (bw.WorkerSupportsCancellation == true)
            {
                bw.CancelAsync();
            }
        }       

        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            
            CustomTreeNode currentNode = tree;
            int count = 0;

            using (XmlReader reader = XmlReader.Create(new StringReader(theXml)))
            {
                XmlWriterSettings ws = new XmlWriterSettings();
                ws.Indent = true;
                using (XmlWriter writer = XmlWriter.Create(output, ws))
                {

                    // Parse the file and display each of the nodes.
                    while (reader.Read())
                    {
                        switch (reader.NodeType)
                        {
                            case XmlNodeType.Element:
                                //writer.WriteStartElement(reader.Name);

                                currentNode.AddChild(new CustomTreeNode(reader.Name));
                                currentNode = currentNode.children[currentNode.children.Count - 1];
                                count++;

                                break;
                            case XmlNodeType.Text:
                                //writer.WriteString(reader.Value);
                                //Console.WriteLine("value " + reader.Value);

                                currentNode.AddChild(new CustomTreeNode(reader.Name));
                                currentNode = currentNode.children[currentNode.children.Count - 1];
                                count++;

                                //this.Invoke((MethodInvoker)delegate {
                                //    mainTreeView.Nodes.Add(new TreeNodeWrapper(reader.Value));
                                //});

                                break;
                            case XmlNodeType.XmlDeclaration:
                            case XmlNodeType.ProcessingInstruction:
                                //writer.WriteProcessingInstruction(reader.Name, reader.Value);
                                break;
                            case XmlNodeType.Comment:
                                //writer.WriteComment(reader.Value);
                                break;
                            case XmlNodeType.EndElement:
                                //writer.WriteFullEndElement();

                                currentNode = currentNode.parent;

                                break;
                        }
                    }
                }
            }
            //worker.ReportProgress((i * 10));
            Console.WriteLine(count);
   

        }
      

        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //if ((e.Cancelled == true))
            //{
            //    this.tbProgress.Text = "Canceled!";
            //}

            //else if (!(e.Error == null))
            //{
            //    this.tbProgress.Text = ("Error: " + e.Error.Message);
            //}

            //else
            //{
            //    this.tbProgress.Text = "Done!";
            //}
            this.Close();
        }

        private void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //this.tbProgress.Text = (e.ProgressPercentage.ToString() + "%");
        }
    }
}
