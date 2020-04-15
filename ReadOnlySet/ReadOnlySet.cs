using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace AnamSoft.ReadOnlySet
{
    /// <summary>
    /// Generic read-only set. May be used as s read-only wrap on generic <see cref="HashSet{T}"/>.
    /// </summary>
    /// <typeparam name="T">The type of elements in the set.</typeparam>
    public class ReadOnlySet<T> : IReadOnlySet<T>
    {
        /// <summary>
        /// Returns the <see cref="ISet{T}"/> that the <see cref="ReadOnlySet{T}"/> wraps.
        /// </summary>
        /// <returns>The <see cref="ISet{T}"/> that the <see cref="ReadOnlySet{T}"/> wraps.</returns>
        protected readonly ISet<T> Items;

        /// <summary>
        /// Initializes new instance of <see cref="ReadOnlySet{T}"/>.
        /// </summary>
        /// <param name="items"></param>
        public ReadOnlySet(ISet<T> items)
        {
            Items = items ?? throw new ArgumentNullException(nameof(items));
        }

        /// <summary>
        /// Returns an enumerator that iterates through the collection.
        /// </summary>
        /// <returns>An enumerator that can be used to iterate through the set.</returns>
        public IEnumerator<T> GetEnumerator() => Items.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        /// <summary>
        /// Gets the number of elements contained in the <see cref="ReadOnlySet{T}"/>.
        /// </summary>
        /// <returns>The number of elements contained in the <see cref="ReadOnlySet{T}"/>.</returns>
        public int Count => Items.Count;

        /// <summary>
        /// Determines if the <see cref="ReadOnlySet{T}"/> is empty.
        /// </summary>
        /// <returns><see langword="true"/> if the <see cref="ReadOnlySet{T}"/> is empty; otherwise, <see langword="false"/>.</returns>
        public bool IsEmpty => Items.Count == 0;

        /// <summary>
        /// Determines whether the <see cref="ReadOnlySet{T}"/> contains a specific value.
        /// </summary>
        /// <param name="item">The object to locate in the <see cref="ReadOnlySet{T}"/>.</param>
        /// <returns><see langword="true"/> if <paramref name="item"/> is found in the <see cref="ReadOnlySet{T}"/>; otherwise, <see langword="false"/>.</returns>
        public bool Contains(T item) => Items.Contains(item);

        /// <summary>
        /// Determines whether the current set is a proper (strict) subset of a specified collection.
        /// </summary>
        /// <param name="other">The collection to compare to the current set.</param>
        /// <returns><see langword="true"/> if the current set is a proper subset of other; otherwise, <see langword="false"/>.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="other"/> is <see langword="null"/>.</exception>
        public bool IsProperSubsetOf(IEnumerable<T> other) => Items.IsProperSubsetOf(other);

        /// <summary>
        /// Determines whether a set is a subset of a specified collection.
        /// </summary>
        /// <param name="other">The collection to compare to the current set.</param>
        /// <returns><see langword="true"/> if the current set is a subset of other; otherwise, <see langword="false"/>.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="other"/> is <see langword="null"/>.</exception>
        public bool IsSubsetOf(IEnumerable<T> other) => Items.IsSubsetOf(other);

        /// <summary>
        /// Determines whether the current set is a superset of a specified collection.
        /// </summary>
        /// <param name="other">The collection to compare to the current set.</param>
        /// <returns><see langword="true"/> if the current set is a superset of other; otherwise, <see langword="false"/>.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="other"/> is <see langword="null"/>.</exception>
        public bool IsSupersetOf(IEnumerable<T> other) => Items.IsSupersetOf(other);

        /// <summary>
        /// Determines whether the current set is a proper (strict) superset of a specified collection.
        /// </summary>
        /// <param name="other">The collection to compare to the current set.</param>
        /// <returns><see langword="true"/> if the current set is a proper superset of other; otherwise, <see langword="false"/>.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="other"/> is <see langword="null"/>.</exception>
        public bool IsProperSupersetOf(IEnumerable<T> other) => Items.IsProperSupersetOf(other);

        /// <summary>
        /// Determines whether the current set overlaps with the specified collection.
        /// </summary>
        /// <param name="other">The collection to compare to the current set.</param>
        /// <returns><see langword="true"/> if the current set and other share at least one common element; otherwise, <see langword="false"/>.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="other"/> is <see langword="null"/>.</exception>
        public bool Overlaps(IEnumerable<T> other) => Items.Overlaps(other);

        /// <summary>
        /// Determines whether the current set and the specified collection contain the same elements.
        /// </summary>
        /// <param name="other">The collection to compare to the current set.</param>
        /// <returns><see langword="true"/> if the current set is equal to other; otherwise, <see langword="false"/>.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="other"/> is <see langword="null"/>.</exception>
        public bool SetEquals(IEnumerable<T> other) => Items.SetEquals(other);

        /// <summary>
        /// Returns an empty static instance of <see cref="ReadOnlySet{T}"/> class.
        /// </summary>
        /// <returns>An empty static instance of <see cref="ReadOnlySet{T}"/> class.</returns>
        public static readonly ReadOnlySet<T> Empty = new ReadOnlySet<T>(new HashSet<T>());
    }

    /// <summary>
    /// Provides extesions for <see cref="ReadOnlySet{T}"/> class.
    /// </summary>
    public static class ReadOnlySetExtensions
    {
        /// <summary>
        /// Returns a read-only <see cref="ReadOnlySet{T}"/> wrapper for the current set.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="set"></param>
        /// <returns>An object that acts as a read-only wrapper around the current System.Collections.Generic.List`1.</returns>
        public static ReadOnlySet<T> AsReadOnlySet<T>(this ISet<T> set) => new ReadOnlySet<T>(set);
    }
}
