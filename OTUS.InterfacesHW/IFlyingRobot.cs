using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OTUS.InterfacesHW
{
    public interface IFlyingRobot : IRobot
    {
        public new string GetRobotType()
        {
            return "I am a flying robot.";
        }
    }
}
