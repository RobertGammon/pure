namespace Pure.Core.Contracts.Domain
{
    /// <summary>
    /// An identifiable object
    /// </summary>
    public interface IPersistableEntity<TId>
    {
        /// <summary>
        /// The global identifier of the current <see cref="IPersistableEntity{TId}"/> object
        /// </summary>
        TId Id { get; }
        /// <summary>
        /// A string representation of the current <see cref="IPersistableEntity{TId}"/>'s type
        /// </summary>
        string IdentifiableTypeName { get; }
    }
}
