using MediatR;

namespace SimpleNetCoreVue.Application;

/// <summary>
/// 取得資料 Request
/// </summary>
public class GetTestDataRequest : IRequest<GetTestDataResponse>
{
}