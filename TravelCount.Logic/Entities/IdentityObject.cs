using System;

namespace TravelCount.Logic.Entities
{
    /// <inheritdoc />
    /// <summary>
    /// Implements the properties and methods of identifiable model.
    /// </summary>

    [Serializable]

    internal abstract class IdentityObject : Contracts.IIdentifiable

    {
        public int Id { get; set; }
    }
}
