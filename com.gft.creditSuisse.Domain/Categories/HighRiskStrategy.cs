using System;
using System.Collections.Generic;
using System.Text;
using com.gft.creditSuisse.Domain.Models;

namespace com.gft.creditSuisse.Domain.Categories
{
    public class HighRiskStrategy : CategoriesStrategy
    {
        public override string Categorize()
        {
            return "HIGHRISK";
        }
    }
}
