/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

#if !ROS2

namespace RosSharp.RosBridgeClient.MessageTypes.ActionlibTutorials
{
    public class AveragingGoal : Message
    {
        public const string RosMessageName = "actionlib_tutorials/AveragingGoal";

        // goal definition
        public int samples { get; set; }

        public AveragingGoal()
        {
            this.samples = 0;
        }

        public AveragingGoal(int samples)
        {
            this.samples = samples;
        }
    }
}
#endif
