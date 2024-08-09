using Nameless.RawgClient.Contracts.Common;
using Nameless.RawgClient.Contracts.Http.Creators.Requests;
using Nameless.RawgClient.Contracts.Objects;

namespace Nameless.RawgClient.Contracts.Http.Creators.Responses {
    public record GetCreatorsResponse : PaginableResponse<GetCreatorsRequest, Creator> {
    }
}