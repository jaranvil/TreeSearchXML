using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeSearchXML
{
    class TreeNodeWrapper : TreeNode
    {
        public string FilePath;

        public TreeNodeWrapper() { }

        public TreeNodeWrapper(string fp)
        {
            FilePath = fp;
            //this.Text = fp.Substring(fp.LastIndexOf("\\"));
            this.Text = fp;
        }
    }

}

