using Diary.IServices;
using Microsoft.AspNetCore.Components;

namespace Diary.Services;

public class NavigateService:INavigateService
{
    private string? CurrentUrl;
    private Dictionary<string, object?> CurrentCache = new();
    public event Action? Action;
    public event Func<Task>? BeforeNavBtn;
    public event Func<Task>? BeforeNavigate;
    public NavigationManager Navigation { get; set; }
    public async Task NavBtnClick(string url)
    {
        if (BeforeNavBtn is not null)
        {
            await BeforeNavBtn.Invoke();
        }

        // ClearCurrentUrl();
        // ClearCurrentCache();
        // HistoryUrl.Clear();
        // HistoryCache.Clear();

        Navigation.NavigateTo(url);
    }
}