using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefrizeratorApp3
{
    class Refrizerator
    {
        private double maxWeight;
        public double CurrentWeight { get; private set; }
        public double Remainingweight { get; private set; }
        private double noOfItems;
        private double wightPerunit;

        public double MaxWeight
        {
           private get { return maxWeight; }
            set { maxWeight = value; }
        }

        public double NoOfItems
        {
            get { return noOfItems; }
            set { noOfItems = value; }
        }

        public double WightPerunit
        {
            get { return wightPerunit; }
            set { wightPerunit = value; }
        }

        public Refrizerator(double maxWeight)
        {
            this.maxWeight = maxWeight;
        }

        public void addItem()
        {
            double weightToBeAdded = NoOfItems*WightPerunit;
            if (CurrentWeight + weightToBeAdded <= MaxWeight)
            {
                CurrentWeight += weightToBeAdded;
                Remainingweight = MaxWeight - CurrentWeight;
            }
            else
            {
                throw new Exception();
            }
        }
    }
}
