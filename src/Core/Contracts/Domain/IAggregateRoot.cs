namespace Pure.Core.Contracts.Domain
{
    /// <summary>
    /// An aggregate root entity.
    /// </summary>
    /// <typeparam name="TId"></typeparam>
    /// <remarks>
    /// An aggregate root entity is one that may be itself persisted. <see cref="IPersistableEntity{TId}"/>
    /// entities that do not implement <see cref="IAggregateRoot{TId}"/> are not themselves indended to be
    /// individually persisted, but may be persisted by code handling persistence of their
    /// <see cref="IAggregateRoot{TId}"/>.
    /// </remarks>
    public interface IAggregateRoot<TId> : IPersistableEntity<TId> { }
}
