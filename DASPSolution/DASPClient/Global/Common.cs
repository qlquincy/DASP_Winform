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
            ITBTunnelManager tunnelManager;
            ITBFanPositionManager posManager;
            ITBTestDataManager testDataManager;

            projectManager = Utility.SpringUtils.Context.GetObject("ProjectManager") as ITBProjectManager;
            tunnelManager = Utility.SpringUtils.Context.GetObject("TunnelManager") as ITBTunnelManager;
            posManager = Utility.SpringUtils.Context.GetObject("FanPositionManager") as ITBFanPositionManager;
            testDataManager = Utility.SpringUtils.Context.GetObject("TestDataManager") as ITBTestDataManager;

            IList<TBProjectEntity> projectList = projectManager.FindAllProjects();

            if (null != projectList && projectList.Count > 0)
            {
                result.Children = new List<NodeData>();
                foreach (TBProjectEntity projectItem in projectList)
                {
                    NodeData nodeData = new NodeData();
                    nodeData.NodeId = projectItem.ProjectId;
                    nodeData.NodeName = projectItem.ProjectName;
                    nodeData.NodeType = 2; //2--合同

                    IList<TBTunnelEntity> tunnelList = tunnelManager.FindByProjectId(projectItem.ProjectId);
                    if (null != tunnelList && tunnelList.Count > 0)
                    {
                        nodeData.Children = new List<NodeData>();
                        foreach (TBTunnelEntity tunnelItem in tunnelList)
                        {
                            NodeData nodeDataItem = new NodeData();
                            nodeDataItem.NodeId = tunnelItem.TunnelId;
                            nodeDataItem.NodeName = tunnelItem.TunnelName;
                            nodeDataItem.NodeType = 3; //3--隧道
                            nodeData.Children.Add(nodeDataItem);

                            IList<TBFanPositionEntity> posList = posManager.FindByTunnelId(tunnelItem.TunnelId);
                            if (null != posList && posList.Count > 0)
                            {
                                nodeDataItem.Children = new List<NodeData>();
                                foreach (TBFanPositionEntity posItem in posList)
                                {
                                    NodeData nodeDataPosItem = new NodeData();
                                    nodeDataPosItem.NodeId = posItem.PositionId;
                                    nodeDataPosItem.NodeName = posItem.PositionName;
                                    nodeDataPosItem.NodeType = 4; //4--风机位置
                                    nodeDataItem.Children.Add(nodeDataPosItem);

                                    IList<TBTestDataEntity> dataList = testDataManager.FindByPosId(posItem.PositionId);
                                    if (null != dataList && dataList.Count > 0)
                                    {
                                        nodeDataPosItem.Children = new List<NodeData>();
                                        foreach (TBTestDataEntity dataItem in dataList)
                                        {
                                            NodeData nodeDataDataItem = new NodeData();
                                            nodeDataDataItem.NodeId = dataItem.DataId;
                                            nodeDataDataItem.NodeName = dataItem.TestCode + "#" +dataItem.ChannelCode;
                                            nodeDataDataItem.NodeType = 5; //5--采样数据
                                            nodeDataPosItem.Children.Add(nodeDataDataItem);
                                        }
                                    }
                                }
                            }

                        }
                    }
                    result.Children.Add(nodeData);
                }
            }

            return result;
        }
    }
}
