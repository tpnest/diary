using Diary.IServices;
using Microsoft.AspNetCore.Components;

namespace Diary.Services;

public class NavigateService:INavigateService
{
    public NavigationManager Navigation { get; set; }
}