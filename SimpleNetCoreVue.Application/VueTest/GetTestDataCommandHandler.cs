using MediatR;

namespace SimpleNetCoreVue.Application;

/// <summary>
/// 取得資料 CommandHandler
/// </summary>
public class GetTestDataCommandHandler : IRequestHandler<GetTestDataRequest, GetTestDataResponse>
{
    /// <summary>
    /// 建構子
    /// </summary>
    public GetTestDataCommandHandler()
    {
    }

    public async Task<GetTestDataResponse> Handle(GetTestDataRequest request, CancellationToken cancellationToken)
    {
        return new GetTestDataResponse()
        {
            TestWord = new string[] { "從後端", "來的字" }
        };
    }
}