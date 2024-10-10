/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

#if ROS2

namespace RosSharp.RosBridgeClient.MessageTypes.Std
{
    public class Float32MultiArray : Message
    {
        public const string RosMessageName = "std_msgs/msg/Float32MultiArray";

        //  This was originally provided as an example message.
        //  It is deprecated as of Foxy
        //  It is recommended to create your own semantically meaningful message.
        //  However if you would like to continue using this please use the equivalent in example_msgs.
        //  Please look at the MultiArrayLayout message definition for
        //  documentation on all multiarrays.
        public MultiArrayLayout layout { get; set; }
        //  specification of data layout
        public float[] data { get; set; }
        //  array of data

        public Float32MultiArray()
        {
            this.layout = new MultiArrayLayout();
            this.data = new float[0];
        }

        public Float32MultiArray(MultiArrayLayout layout, float[] data)
        {
            this.layout = layout;
            this.data = data;
        }
    }
}
#endif
