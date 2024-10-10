/* 
 * This message is auto generated by ROS#. Please DO NOT modify.
 * Note:
 * - Comments from the original code will be written in their own line 
 * - Variable sized arrays will be initialized to array of size 0 
 * Please report any issues at 
 * <https://github.com/siemens/ros-sharp> 
 */

#if ROS2

namespace RosSharp.RosBridgeClient.MessageTypes.FileServer
{
    public class SaveBinaryFileResponse : Message
    {
        public const string RosMessageName = "file_server2/srv/SaveBinaryFile";

        public string name { get; set; }

        public SaveBinaryFileResponse()
        {
            this.name = "";
        }

        public SaveBinaryFileResponse(string name)
        {
            this.name = name;
        }
    }
}
#endif
