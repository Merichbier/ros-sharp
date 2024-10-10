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
    public class ChangeControlDimensions_Request : Message
    {
        public const string RosMessageName = "moveit_msgs/msg/ChangeControlDimensions_Request";

        //  For use with moveit_jog_arm Cartesian planner
        // 
        //  Turn on/off jogging along these dimensions.
        //  Give 'true' to enable jogging in the direction, 'false' to disable
        public bool control_x_translation { get; set; }
        public bool control_y_translation { get; set; }
        public bool control_z_translation { get; set; }
        public bool control_x_rotation { get; set; }
        public bool control_y_rotation { get; set; }
        public bool control_z_rotation { get; set; }

        public ChangeControlDimensions_Request()
        {
            this.control_x_translation = false;
            this.control_y_translation = false;
            this.control_z_translation = false;
            this.control_x_rotation = false;
            this.control_y_rotation = false;
            this.control_z_rotation = false;
        }

        public ChangeControlDimensions_Request(bool control_x_translation, bool control_y_translation, bool control_z_translation, bool control_x_rotation, bool control_y_rotation, bool control_z_rotation)
        {
            this.control_x_translation = control_x_translation;
            this.control_y_translation = control_y_translation;
            this.control_z_translation = control_z_translation;
            this.control_x_rotation = control_x_rotation;
            this.control_y_rotation = control_y_rotation;
            this.control_z_rotation = control_z_rotation;
        }
    }
}
#endif
