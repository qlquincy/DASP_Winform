using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DASPClient.Global
{
    public class NodeData
    {
        public Guid NodeId
        {
            get;
            set;
        }

        public string NodeName
        {
            get;
            set;
        }

        public byte NodeType
        {
            get;
            set;
        }

        public NodeData Parent
        {
            get;
            set;
        }

        public List<NodeData> Children
        {
            get;
            set;
        }
    }
}
