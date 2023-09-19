using Diary.IServices;
using Microsoft.AspNetCore.Components;

namespace Diary.Components;

public class MyComponentBase : ComponentBase
{
    [Inject]
    protected INavigateService NavigateService { get; set; }
    [Inject]
    protected II18nService Ii18NService { get; set; }

    protected NavigationManager Navigation => NavigateService.Navigation;
}