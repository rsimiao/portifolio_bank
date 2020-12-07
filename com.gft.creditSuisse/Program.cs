using com.gft.creditSuisse.Domain;
using com.gft.creditSuisse.Domain.Categories;
using com.gft.creditSuisse.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace com.gft.creditSuisse
{
    class Program
    {
        static void Main(string[] args)
        {
            var Trade1 = new Trade { Value = 2000000, ClientSector = "Private" };
            var Trade2 = new Trade { Value = 400000, ClientSector = "Public" };
            var Trade3 = new Trade { Value = 500000, ClientSector = "Public" };
            var Trade4 = new Trade { Value = 3000000, ClientSector = "Public" };

            var portifolio = new[] { Trade1, Trade2, Trade3, Trade4 };

            var risks =
            portifolio.Select(trade => ContextRisk.Get(trade).Categorize());

            Show(risks);

        }

        static void Show(IEnumerable<string> risks)
        {
            Console.WriteLine(risks.Aggregate((i, j) => $"{i} , {j}"));
            Console.Read();
        }


    }
}
