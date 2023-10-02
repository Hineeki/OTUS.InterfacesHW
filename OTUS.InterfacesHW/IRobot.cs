namespace OTUS.InterfacesHW
{
    public interface IRobot
    {
        public string GetInfo()
        {
            return string.Empty;
        }
        public List<string> GetComponents()
        {
            return new List<string>();
        }
        public virtual string GetRobotType()
        {
            return "I'm a simple robot.";
        }
    }
}
