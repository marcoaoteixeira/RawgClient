namespace Nameless.RawgClient.Objects {
    public record AddedByStatus {
        [JsonProperty("yet")]
        public int Yet { get; init; }

        [JsonProperty("owned")]
        public int Owned { get; init; }

        [JsonProperty("beaten")]
        public int Beaten { get; init; }

        [JsonProperty("toplay")]
        public int ToPlay { get; init; }

        [JsonProperty("dropped")]
        public int Dropped { get; init; }

        [JsonProperty("playing")]
        public int Playing { get; init; }
    }
}
