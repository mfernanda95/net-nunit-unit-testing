using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace productionCode
{
    public class SerialPortParser
    {
        public int parsePort(String port)
        {
            if (!new Regex(@"^(COM)[0-9]{1}$").IsMatch(port))
            //if (!port.StartsWith("COM"))
            {
                throw new FormatException("El puerto ingresado no tiene el fomrato correcto");
            }
            else
            {
                return int.Parse(port.Substring(3));
            }
        }
    }
}
