using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeXML
{
    class TreeNodeWrapper : TreeNode
    {
        public string FilePath;
        public bool isSearchResult = false; 

        public TreeNodeWrapper() { }

        public TreeNodeWrapper(string fp)
        {
            FilePath = fp;            
            this.Text = fp;
        }
    }
}
