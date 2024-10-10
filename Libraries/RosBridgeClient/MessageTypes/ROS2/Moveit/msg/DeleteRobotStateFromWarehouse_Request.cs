/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

#if ROS2

namespace RosSharp.RosBridgeClient.MessageTypes.Moveit
{
    public class DeleteRobotStateFromWarehouse_Request : Message
    {
        public const string RosMessageName = "moveit_msgs/msg/DeleteRobotStateFromWarehouse_Request";

        public string name { get; set; }
        public string robot { get; set; }

        public DeleteRobotStateFromWarehouse_Request()
        {
            this.name = "";
            this.robot = "";
        }

        public DeleteRobotStateFromWarehouse_Request(string name, string robot)
        {
            this.name = name;
            this.robot = robot;
        }
    }
}
#endif
