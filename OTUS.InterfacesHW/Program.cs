namespace OTUS.InterfacesHW
{
    interface IDataProvider
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadrocopter quadrocopter = new Quadrocopter();

            FlyingRobot robot = new FlyingRobot();
        }
    }
    public class FlyingRobot : IFlyingRobot
    {
        public FlyingRobot() { }


    }
}