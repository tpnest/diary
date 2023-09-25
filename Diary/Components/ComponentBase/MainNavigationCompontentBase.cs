
using BlazorComponent;
using Diary.IServices;
using Diary.Models;
using Masa.Blazor;
using Microsoft.AspNetCore.Components;

namespace Diary.Components;

public class MainNavigationCompontentBase :ComponentBase,IDisposable
{
    [Inject] public MasaBlazor MasaBlazor { get; set; } = default!;

    [Inject] public II18nService I18n { get; set; } = default!;

    [Inject] public NavigationManager Navigation { get; set; } = default!;

    [Parameter] public StringNumber Value { get; set; } = 0;
    
    [Parameter]
    public EventCallback<StringNumber> ValueChanged { get; set; }

    [Parameter] public List<NavigationButton> Items { get; set; } = new();


    private void InvokeStateHasChanged(object? sender,BreakpointChangedEventArgs e)
    {
        InvokeAsync(StateHasChanged);
    }

    protected override Task OnInitializedAsync()
    {
        MasaBlazor.BreakpointChanged += InvokeStateHasChanged;
        return base.OnInitializedAsync();
    }

    public void Dispose()
    {
        MasaBlazor.BreakpointChanged -= InvokeStateHasChanged;
        GC.SuppressFinalize(this);
    }
}