namespace OTUS.InterfacesHW
{
    public interface IRobot
    {
        public string GetInfo();
        public List<string> GetComponents()
        public virtual string GetRobotType()
        {
            return "I'm a simple robot.";
        }
    }
}
