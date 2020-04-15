using System;
using System.Collections.Generic;

namespace AnamSoft.ReadOnlySet
{
    /// <summary>
    /// Interface for generic read-only set. May be used as s read-only wrap on generic <see cref="ISet{T}"/>.
    /// </summary>
    /// <typeparam name="T">The type of elements in the set.</typeparam>
    public interface IReadOnlySet<T> : IReadOnlyCollection<T>
    {
        /// <summary>
        /// Determines whether the <see cref="IReadOnlySet{T}"/> contains a specific value.
        /// </summary>
        /// <param name="item">The object to locate in the <see cref="IReadOnlySet{T}"/>.</param>
        /// <returns><see langword="true"/> if <paramref name="item"/> is found in the <see cref="IReadOnlySet{T}"/>; otherwise, <see langword="false"/>.</returns>
        bool Contains(T item);

        /// <summary>
        /// Determines whether the current set is a proper (strict) subset of a specified collection.
        /// </summary>
        /// <param name="other">The collection to compare to the current set.</param>
        /// <returns><see langword="true"/> if the current set is a proper subset of other; otherwise, <see langword="false"/>.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="other"/> is <see langword="null"/>.</exception>
        bool IsProperSubsetOf(IEnumerable<T> other);

        /// <summary>
        /// Determines whether the current set is a proper (strict) superset of a specified collection.
        /// </summary>
        /// <param name="other">The collection to compare to the current set.</param>
        /// <returns><see langword="true"/> if the current set is a proper superset of other; otherwise, <see langword="false"/>.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="other"/> is <see langword="null"/>.</exception>
        bool IsProperSupersetOf(IEnumerable<T> other);

        /// <summary>
        /// Determines whether a set is a subset of a specified collection.
        /// </summary>
        /// <param name="other">The collection to compare to the current set.</param>
        /// <returns><see langword="true"/> if the current set is a subset of other; otherwise, <see langword="false"/>.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="other"/> is <see langword="null"/>.</exception>
        bool IsSubsetOf(IEnumerable<T> other);

        /// <summary>
        /// Determines whether the current set is a superset of a specified collection.
        /// </summary>
        /// <param name="other">The collection to compare to the current set.</param>
        /// <returns><see langword="true"/> if the current set is a superset of other; otherwise, <see langword="false"/>.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="other"/> is <see langword="null"/>.</exception>
        bool IsSupersetOf(IEnumerable<T> other);

        /// <summary>
        /// Determines whether the current set overlaps with the specified collection.
        /// </summary>
        /// <param name="other">The collection to compare to the current set.</param>
        /// <returns><see langword="true"/> if the current set and other share at least one common element; otherwise, <see langword="false"/>.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="other"/> is <see langword="null"/>.</exception>
        bool Overlaps(IEnumerable<T> other);

        /// <summary>
        /// Determines whether the current set and the specified collection contain the same elements.
        /// </summary>
        /// <param name="other">The collection to compare to the current set.</param>
        /// <returns><see langword="true"/> if the current set is equal to other; otherwise, <see langword="false"/>.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="other"/> is <see langword="null"/>.</exception>
        bool SetEquals(IEnumerable<T> other);

        /// <summary>
        /// Determines if the <see cref="ReadOnlySet{T}"/> is empty.
        /// </summary>
        /// <returns><see langword="true"/> if the <see cref="ReadOnlySet{T}"/> is empty; otherwise, <see langword="false"/>.</returns>
        bool IsEmpty { get; }
    }
}