﻿using Nameless.RawgClient.Contracts.Common;
using Newtonsoft.Json;

namespace Nameless.RawgClient.Contracts.Http.Platforms.Requests {
    /// <summary>
    /// Represents a request object for a list of parent platforms.
    /// </summary>
    /// <param name="Ordering">The ordering.</param>
    public sealed record GetParentPlatformsRequest([property: JsonProperty("ordering")] Ordering Ordering = default) : PaginableRequest {
        public override Dictionary<string, object[]> ToQueryParams() {
            var result = base.ToQueryParams();
            if (!Ordering.IsEmpty) {
                result[Ordering.OrderBy] = [((string)Ordering)];
            }
            return result;
        }
    }
}
