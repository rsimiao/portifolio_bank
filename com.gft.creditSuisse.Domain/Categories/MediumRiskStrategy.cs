using System;
using System.Collections.Generic;
using System.Text;
using com.gft.creditSuisse.Domain.Models;

namespace com.gft.creditSuisse.Domain.Categories
{
    public class MediumRiskStrategy : CategoriesStrategy
    {
        public override string Categorize()
        {
           return "MEDIUMRISK";
        }
    }
}
