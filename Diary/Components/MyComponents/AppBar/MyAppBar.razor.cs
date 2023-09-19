using BlazorComponent.Web;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components.Web;

namespace Diary.Components;

public partial class MyAppBar : IDisposable
{
    [Inject] private NavigationManager NavigationManager { get; set; } = default!;
    [Parameter] public string? Title { get; set; }
    [Parameter] public EventCallback<MouseEventArgs> OnClick { get; set; }
    [Parameter] public RenderFragment? ChildContent { get; set; }

    public void Dispose()
    {
        NavigationManager.LocationChanged -= NavigationManagerOnLocationChanged;
        //GC的时候不让调用析构函数，防止资源重复释放引发异常。
        GC.SuppressFinalize(this);
    }

    protected override Task OnInitializedAsync()
    {
        NavigationManager.LocationChanged += NavigationManagerOnLocationChanged;
        return base.OnInitializedAsync();
    }

    private void NavigationManagerOnLocationChanged(object? sender, LocationChangedEventArgs e)
    {
        InvokeAsync(StateHasChanged);
    }
}