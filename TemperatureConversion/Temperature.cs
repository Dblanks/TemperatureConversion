using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConversion
{
    public class Temperature
    {
        //fields
        private float temp;
        private float _newTemp;
        private bool _isCelsius;

        //Constructor
        public Temperature(string u_temp, bool isCelsius)
        {
            temp = Convert.ToSingle(u_temp);
            _isCelsius = isCelsius;
        }

        public string getConvTemp()
        {
            if (_isCelsius)
            {
                return getCels();
            }
            else
            {
                return getFahrenheit();
            }
        }

        private string getCels()
        {
            _newTemp = 5 * (temp - 32) / 9;
            Convert.ToString(_newTemp);
            return string.Format("{0}\u00B0C", _newTemp);

        }

        private string getFahrenheit()
        {
            _newTemp = (9 * temp / 5) + 32;
            Convert.ToString(_newTemp);
            return string.Format("{0}\u00B0F", _newTemp);

        }

    }
}
