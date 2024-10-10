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
    public class GraspPlanningRequest : Message
    {
        public const string RosMessageName = "moveit_msgs/srv/GraspPlanning";

        //  Requests that grasp planning be performed for the target object
        //  returns a list of candidate grasps to be tested and executed
        //  the planning group used
        public string group_name { get; set; }
        //  the object to be grasped
        public CollisionObject target { get; set; }
        //  the names of the relevant support surfaces (e.g. tables) in the collision map
        //  can be left empty if no names are available
        public string[] support_surfaces { get; set; }
        //  an optional list of grasps to be evaluated by the planner
        public Grasp[] candidate_grasps { get; set; }
        //  an optional list of obstacles that we have semantic information about
        //  and that can be moved in the course of grasping
        public CollisionObject[] movable_obstacles { get; set; }

        public GraspPlanningRequest()
        {
            this.group_name = "";
            this.target = new CollisionObject();
            this.support_surfaces = new string[0];
            this.candidate_grasps = new Grasp[0];
            this.movable_obstacles = new CollisionObject[0];
        }

        public GraspPlanningRequest(string group_name, CollisionObject target, string[] support_surfaces, Grasp[] candidate_grasps, CollisionObject[] movable_obstacles)
        {
            this.group_name = group_name;
            this.target = target;
            this.support_surfaces = support_surfaces;
            this.candidate_grasps = candidate_grasps;
            this.movable_obstacles = movable_obstacles;
        }
    }
}
#endif
