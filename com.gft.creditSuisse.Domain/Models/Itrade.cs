using System;
using System.Collections.Generic;
using System.Text;

namespace com.gft.creditSuisse.Domain.Models
{
    public interface ITrade
    {
        double Value { get; }
        string ClientSector { get; }
    }
}
