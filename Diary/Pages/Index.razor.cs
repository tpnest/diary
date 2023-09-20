using BlazorComponent;
using Diary.Components;

namespace Diary.Pages;

public partial class Index : DiariesPageComponentBase
{
    private StringNumber tab = 0;

    private Task Search(string? searchText)
    {
        Console.WriteLine(searchText);
        return Task.CompletedTask;
    }
}