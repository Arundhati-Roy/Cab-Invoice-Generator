using System;
using System.Collections.Generic;
using System.Text;

namespace Cab_Invoice_Generator
{
    public class InvoiceSummary
    {
        //Variables
        private int noOfRides;
        private double totalFare;
        private double avgFare;

        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceSummary"/> class.
        /// </summary>
        /// <param name="noOfRides">The no of rides.</param>
        /// <param name="totalFare">The total fare.</param>
        public InvoiceSummary(int noOfRides,double totalFare)
        {
            //Setting Data
            this.noOfRides = noOfRides;
            this.totalFare = totalFare;
            this.avgFare = this.totalFare / this.noOfRides;
        }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object" />, is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object" /> to compare with this instance.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (!(obj is InvoiceSummary))
                return false;
            InvoiceSummary inputObj=(InvoiceSummary)obj;
            return this.noOfRides == inputObj.noOfRides && this.totalFare == inputObj.totalFare && this.avgFare == inputObj.avgFare;
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. 
        /// </returns>
        public override int GetHashCode()
        {
            return this.noOfRides.GetHashCode() ^ this.totalFare.GetHashCode() ^ this.avgFare.GetHashCode();
        }
    }
}
