using System;
using System.Collections.Generic;
using System.Text;

namespace TravelCount.Contracts.Persistence
{
    public interface ITravel: IIdentifiyable,ICopyable<ITravel>
    {
        public string Designation { get; set; }
        public string Description { get; set; }
        public string  Currency { get; set; }
        public string Friends { get; set; }
        public string Category { get; set; }
    }
}
