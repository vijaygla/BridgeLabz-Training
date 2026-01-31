using System;
using System.Text.RegularExpressions;

namespace FutureLogistics
{
    public class Utility
    {
        public GoodsTransport parseDetails(string input)
        {
            string[] data = input.Split(':');

            string transportId = data[0];
            string transportDate = data[1];
            int rating = int.Parse(data[2]);
            string transportType = data[3];

            if (transportType.Equals("BrickTransport", StringComparison.OrdinalIgnoreCase))
            {
                return new BrickTransport(
                    transportId,
                    transportDate,
                    rating,
                    float.Parse(data[4]),
                    int.Parse(data[5]),
                    float.Parse(data[6])
                );
            }
            else
            {
                return new TimberTransport(
                    transportId,
                    transportDate,
                    rating,
                    float.Parse(data[4]),
                    float.Parse(data[5]),
                    data[6],
                    float.Parse(data[7])
                );
            }
        }

        public bool validateTransportId(string transportId)
        {
            Regex regex = new Regex(@"^RTS[0-9]{3}[A-Z]$");

            if (!regex.IsMatch(transportId))
            {
                Console.WriteLine($"Transport id {transportId} is invalid");
                return false;
            }
            return true;
        }

        public string findObjectType(GoodsTransport goodsTransport)
        {
            if (goodsTransport is TimberTransport)
                return "TimberTransport";
            else
                return "BrickTransport";
        }
    }
}
