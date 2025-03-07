using FastEndpoints;
using Mapster;
using VerticalSliceArchitecture.Database;

namespace VerticalSliceArchitecture.Features;
[HttpGet("reporting/flatList")]
public class FlatListHandler : EndpointWithoutRequest<List<GetCaseFlatListDto>>
{
    public DataContext _context { get; set; } = default!;

    public override async Task HandleAsync(CancellationToken ct)
    {
        GetCaseFlatListDto cases = null;
        await SendAsync(cases.Adapt<List<GetCaseFlatListDto>>());
    }
}