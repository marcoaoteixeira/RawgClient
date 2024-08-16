using System.Collections.ObjectModel;
using Nameless.RawgClient.Infrastructure;

namespace Nameless.RawgClient.Domains.Games.Objects {
    /// <summary>
    /// A <see cref="IReadOnlyCollection{T}"/> implementation for <see cref="TrailerOption"/>
    /// </summary>
    [JsonConverter(typeof(TrailerOptionCollectionJsonConverter))]
    public sealed class TrailerOptionCollection : ReadOnlyCollection<TrailerOption> {
        /// <summary>
        /// Initializes a new instance of <see cref="TrailerOptionCollection"/>
        /// </summary>
        public TrailerOptionCollection()
            : base([]) { }

        /// <summary>
        /// Initializes a new instance of <see cref="TrailerOptionCollection"/>
        /// </summary>
        /// <param name="list">The initial list.</param>
        public TrailerOptionCollection(IList<TrailerOption> list)
            : base(list) { }
    }
}
