using com.gft.creditSuisse.Domain.Categories;
using com.gft.creditSuisse.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace com.gft.creditSuisse.Domain
{
    public class ContextRisk
    {
        public static CategoriesStrategy Get(ITrade trade)
        {
            if (trade.Value < 1_000_000 && trade.ClientSector == "Public")
            {
                return new LowRiskStrategy();
            }
            else if (trade.Value > 1_000_000 && trade.ClientSector == "Public")
            {
                return new MediumRiskStrategy();
            }
            else if (trade.Value > 1_000_000 && trade.ClientSector == "Private")
            {
                return new HighRiskStrategy();
            }
            else
            {
                return new UncategorizableStrategy();
            }
        }
    }
}
