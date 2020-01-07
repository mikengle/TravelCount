using System;

namespace TravelCount.Logic.Entities
{
    /// <inheritdoc />
    /// <summary>
    /// Implements the properties and methods of identifiable model.
    /// </summary>

    [Serializable]

    internal abstract class IdentityObject : Contracts.IIdentifiyable

    {
        public int Id { get; set; }
    }
}
