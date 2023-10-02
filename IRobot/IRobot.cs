namespace IRobot.Interface
{
    interface IRobot
    {
        public string GetInfo()
        {
            return string.Empty;
        }
        public List<string> GetComponents()
        {
            return new List<string>();
        }
        public string GetRobotType()
        {
            return "I'm a simple robot.";
        }
    }
}