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
    public class PlannerParams : Message
    {
        public const string RosMessageName = "moveit_msgs/msg/PlannerParams";

        //  parameter names (same size as values)
        public string[] keys { get; set; }
        //  parameter values (same size as keys)
        public string[] values { get; set; }
        //  parameter description (can be empty)
        public string[] descriptions { get; set; }

        public PlannerParams()
        {
            this.keys = new string[0];
            this.values = new string[0];
            this.descriptions = new string[0];
        }

        public PlannerParams(string[] keys, string[] values, string[] descriptions)
        {
            this.keys = keys;
            this.values = values;
            this.descriptions = descriptions;
        }
    }
}
#endif