﻿using System.Collections.ObjectModel;

namespace Nameless.RawgClient.Objects {
    /// <summary>
    /// A <see cref="IReadOnlyCollection{T}"/> implementation for <see cref="Reaction"/>
    /// </summary>
    public sealed class ReactionCollection : ReadOnlyCollection<Reaction> {
        /// <summary>
        /// Initializes a new instance of <see cref="ReactionCollection"/>
        /// </summary>
        public ReactionCollection()
            : base([]) { }

        /// <summary>
        /// Initializes a new instance of <see cref="ReactionCollection"/>
        /// </summary>
        /// <param name="list">The initial list.</param>
        public ReactionCollection(IList<Reaction> list)
            : base(list) { }
    }
}
