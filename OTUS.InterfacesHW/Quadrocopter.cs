using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTUS.InterfacesHW
{
    internal class Quadrocopter : IFlyingRobot, IChargeable
    {
        private List<string> _components;
        public Quadrocopter()
        {
            _components = new List<string> { "rotor1", "rotor2", "rotor3", "rotor4" };
        }
        
        public List<string> GetComponents()
        {
            return _components;
        }
    }
}
