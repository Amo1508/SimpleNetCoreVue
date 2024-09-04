using Microsoft.AspNetCore.Mvc;
using SimpleNetCoreVue.Application;

namespace SimpleNetCoreVue.Controllers;

public class VueTestController : BaseApiController
{
    /// <summary>
    /// 取得資料
    /// </summary>
    [HttpPost]
    public Task<GetTestDataResponse> GetTestData() => Mediator!.Send(new GetTestDataRequest());

    /// <summary>
    /// 數字加數
    /// </summary>
    [HttpPost]
    public Task<NumberAddResponse> NumberAdd(NumberAddRequest request) => Mediator!.Send(request);
}
