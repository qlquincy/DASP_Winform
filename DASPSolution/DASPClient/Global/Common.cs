using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DASPClient.UI.CommonModule;
using DASP.Business.IManager;
using DASP.Domain.Entitys;

namespace DASPClient.Global
{
    public class Common
    {
        public static NodeData BuildCommonData()
        {
            NodeData result = null;
            result = new NodeData();

            result.NodeId = Guid.NewGuid();
            result.NodeName = "默认";
            result.NodeType = 1; //1--默认根
            result.Parent = null;

            ITBProjectManager projectManager;
            projectManager = Utility.SpringUtils.Context.GetObject("ProjectManager") as ITBProjectManager;
            IList<TBProjectEntity> projectList = projectManager.FindAllProjects();

            if (null != projectList)
            {
                result.Children = new List<NodeData>();
                foreach (TBProjectEntity projectItem in projectList)
                {
                    NodeData nodeData = new NodeData();
                    nodeData.NodeId = projectItem.ProjectId;
                    nodeData.NodeName = projectItem.ProjectName;
                    nodeData.Parent = result;
                    nodeData.NodeType = 2; //2--合同a
                    result.Children.Add(nodeData);
                }
            }

            return result;
        }
    }
}
