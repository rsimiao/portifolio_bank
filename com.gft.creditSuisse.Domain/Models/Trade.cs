using System;
using System.Collections.Generic;
using System.Text;

namespace com.gft.creditSuisse.Domain.Models
{
    public class Trade : ITrade
    {
        public double Value { get; set; }

        public string ClientSector { get; set; }

    }
}
