using MediatR;

namespace SimpleNetCoreVue.Application;

/// <summary>
/// 數字加數 Request
/// </summary>
public class NumberAddRequest : IRequest<NumberAddResponse>
{
    // 欲使用的數字
    public int UseNumber { get; set; }
}