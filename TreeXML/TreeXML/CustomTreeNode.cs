using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeXML
{    
    public class CustomTreeNode
    {
        public CustomTreeNode parent = null;
        public List<CustomTreeNode> children = new List<CustomTreeNode>();
        private string value = "";

        public CustomTreeNode(string value)
        {
            this.value = value;
        }

        public void AddChild(CustomTreeNode child)
        {
            child.parent = this;
            this.children.Add(child);
        }

    }
}
