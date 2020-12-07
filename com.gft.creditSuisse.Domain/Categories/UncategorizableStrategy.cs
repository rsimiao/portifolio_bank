using System;
using System.Collections.Generic;
using System.Text;

namespace com.gft.creditSuisse.Domain.Categories
{
    public class UncategorizableStrategy : CategoriesStrategy
    {
        public override string Categorize()
        {
            return "NOTFOUND";
        }
    }
}
