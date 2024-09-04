namespace SimpleNetCoreVue.Application;

/// <summary>
/// 取得資料 Response
/// </summary>
public class GetTestDataResponse
{
    /// <summary>
    /// 測試文字
    /// </summary>
    public string[] TestWord { get; set; } = null!;
}