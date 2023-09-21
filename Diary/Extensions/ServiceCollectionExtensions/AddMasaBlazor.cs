using BlazorComponent;
using Masa.Blazor;
using Masa.Blazor.Presets;

namespace Diary.Extensions;

public static partial class ServiceCollectionExtend
{
    public static IServiceCollection AddMasaBlazorConfig(this IServiceCollection service)
    {
        service.AddMasaBlazor(opt =>
        {
            opt.Defaults = new Dictionary<string, IDictionary<string, object?>?>()
            {
                {
                    PopupComponents.SNACKBAR, new Dictionary<string, object?>()
                    {
                        { nameof(PEnqueuedSnackbars.Closeable), true },
                        { nameof(PEnqueuedSnackbars.Text), true },
                        { nameof(PEnqueuedSnackbars.Elevation), new StringNumber(2) },
                        { nameof(PEnqueuedSnackbars.Position), SnackPosition.BottomCenter }
                    }
                }   
            };
        });
        return service;
    }
}