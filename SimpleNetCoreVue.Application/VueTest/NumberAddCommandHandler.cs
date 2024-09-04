using MediatR;

namespace SimpleNetCoreVue.Application;

/// <summary>
/// 數字加數 CommandHandler
/// </summary>
public class NumberAddCommandHandler : IRequestHandler<NumberAddRequest, NumberAddResponse>
{
    /// <summary>
    /// 建構子
    /// </summary>
    public NumberAddCommandHandler()
    {
    }

    public async Task<NumberAddResponse> Handle(NumberAddRequest request, CancellationToken cancellationToken)
    {
        if (request.UseNumber < 0 || request.UseNumber > 10000) request.UseNumber = 0;
        else request.UseNumber++;

        return new NumberAddResponse()
        {
            ProcessedNumber = request.UseNumber
        };
    }
}