/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

#if !ROS2

namespace RosSharp.RosBridgeClient.MessageTypes.Std
{
    public class Int32MultiArray : Message
    {
        public const string RosMessageName = "std_msgs/Int32MultiArray";

        //  Please look at the MultiArrayLayout message definition for
        //  documentation on all multiarrays.
        public MultiArrayLayout layout { get; set; }
        //  specification of data layout
        public int[] data { get; set; }
        //  array of data

        public Int32MultiArray()
        {
            this.layout = new MultiArrayLayout();
            this.data = new int[0];
        }

        public Int32MultiArray(MultiArrayLayout layout, int[] data)
        {
            this.layout = layout;
            this.data = data;
        }
    }
}
#endif
