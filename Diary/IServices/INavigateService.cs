using Microsoft.AspNetCore.Components;

namespace Diary.IServices;

public interface INavigateService
{
    NavigationManager Navigation { get; protected set; }
}