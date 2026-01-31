using System;

namespace FutureLogistics
{
    public class TimberTransport : GoodsTransport
    {
        private float timberLength;
        private float timberRadius;
        private string timberType;
        private float timberPrice;

        public float TimberLength
        {
            get { return timberLength; }
            set { timberLength = value; }
        }

        public float TimberRadius
        {
            get { return timberRadius; }
            set { timberRadius = value; }
        }

        public string TimberType
        {
            get { return timberType; }
            set { timberType = value; }
        }

        public float TimberPrice
        {
            get { return timberPrice; }
            set { timberPrice = value; }
        }

        public TimberTransport(string transportId, string transportDate, int transportRating,
                               float timberLength, float timberRadius,
                               string timberType, float timberPrice)
            : base(transportId, transportDate, transportRating)
        {
            this.timberLength = timberLength;
            this.timberRadius = timberRadius;
            this.timberType = timberType;
            this.timberPrice = timberPrice;
        }

        public override string vehicleSelection()
        {
            float area = 2 * 3.147f * timberRadius * timberLength;

            if (area < 250)
                return "Truck";
            else if (area <= 400)
                return "Lorry";
            else
                return "MonsterLorry";
        }

        public override float calculateTotalCharge()
        {
            float volume = 3.147f * timberRadius * timberRadius * timberLength;

            float rate = timberType.Equals("Premium", StringComparison.OrdinalIgnoreCase)
                         ? 0.25f
                         : 0.15f;

            float price = volume * timberPrice * rate;
            float tax = price * 0.3f;

            float discount = 0;
            if (transportRating == 5)
                discount = price * 0.20f;
            else if (transportRating == 3 || transportRating == 4)
                discount = price * 0.10f;

            float vehiclePrice;
            string vehicle = vehicleSelection().ToLower();

            if (vehicle == "truck")
                vehiclePrice = 1000;
            else if (vehicle == "lorry")
                vehiclePrice = 1700;
            else
                vehiclePrice = 3000;

            return (price + tax + vehiclePrice) - discount;
        }
    }
}
