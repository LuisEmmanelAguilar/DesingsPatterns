using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingsPatterns.stateExcercise
{
    public class DirectionService
    {
        private ITravelMode _travelMode;

        public DirectionService(ITravelMode _travelMode)
        {
            this._travelMode = _travelMode;
        }

        public Object getETA()
        {
            return _travelMode.getEta();
        }

        public Object getDirection()
        {
            return _travelMode.getDirection();
        }

        public ITravelMode getTravelMode()
        {
            return _travelMode;
        }

        public void setTravelMode(ITravelMode travelModel)
        {
            this._travelMode = _travelMode;
        }
    }
}
