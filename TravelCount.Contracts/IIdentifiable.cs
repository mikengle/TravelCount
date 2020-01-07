using System;
using System.Collections.Generic;
using System.Text;

namespace TravelCount.Contracts
{
    /// <summary>
    /// Defines the basic properties of identifiyable components
    /// </summary>
    public partial interface IIdentifiable
    {
        /// <summary>
        /// Gets the identity of the component.
        /// </summary>
        public int Id { get; }
    }
}
