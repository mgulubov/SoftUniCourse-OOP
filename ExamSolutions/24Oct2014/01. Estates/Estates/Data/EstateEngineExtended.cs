using System;
using System.Collections;
using System.Linq;
using Estates.Interfaces;

namespace Estates.Data
{
    using Engine;

    class EstateEngineExtended : EstateEngine
    {
        public EstateEngineExtended()
            : base()
        {
        }

        public override string ExecuteCommand(string cmdName, string[] cmdArgs)
        {
            switch (cmdName)
            {
                case "find-rents-by-location":
                    return this.ExecuteFindRentsByLocationCommand(cmdArgs[0]);
                case "find-rents-by-price":
                    return this.ExecuteFindRentsByPriceCommand(decimal.Parse(cmdArgs[0]), decimal.Parse(cmdArgs[1]));
                default:
                    return base.ExecuteCommand(cmdName, cmdArgs);
            }
        }

        private string ExecuteFindRentsByLocationCommand(string location)
        {
            var result = this.Offers
                .OfType<IRentOffer>()
                .Where(o => o.Estate.Location == location)
                .OrderBy(o => o.Estate.Name);

            return this.FormatQueryResults(result);
        }

        private string ExecuteFindRentsByPriceCommand(decimal minPrice, decimal maxPrice)
        {
            var result = this.Offers
                .OfType<IRentOffer>()
                .Where(o => o.PricePerMonth >= minPrice && o.PricePerMonth <= maxPrice)
                .OrderBy(o => o.PricePerMonth)
                .ThenBy(o => o.Estate.Name);

            return this.FormatQueryResults(result);
        }
    }
}
