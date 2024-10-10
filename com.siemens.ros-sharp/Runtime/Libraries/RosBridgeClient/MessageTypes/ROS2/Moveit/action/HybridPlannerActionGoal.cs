/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

#if ROS2
using RosSharp.RosBridgeClient.MessageTypes.Std;
using RosSharp.RosBridgeClient.MessageTypes.Actionlib;

namespace RosSharp.RosBridgeClient.MessageTypes.Moveit
{
    public class HybridPlannerActionGoal : ActionGoal<HybridPlannerGoal>
    {
        public const string RosMessageName = "moveit_msgs/HybridPlannerActionGoal";

        public HybridPlannerActionGoal() : base()
        {
            this.goal = new HybridPlannerGoal();
        }

        public HybridPlannerActionGoal(Header header, GoalID goal_id, HybridPlannerGoal goal) : base(header, goal_id)
        {
            this.goal = goal;
        }
    }
}
#endif
