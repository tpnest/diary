using Diary.IServices;
using Diary.Services;

namespace Diary.Extensions;

public static partial class ServiceCollectionExtend
{
    public static IServiceCollection AddCustomIOC(this IServiceCollection service)
    {
        // 功能服务
        service.AddSingleton<INavigateService, NavigateService>();
        service.AddSingleton<II18nService, I18nService>();

        return service;
    }
}