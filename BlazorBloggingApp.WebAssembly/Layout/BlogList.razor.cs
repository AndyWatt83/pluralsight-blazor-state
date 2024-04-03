using BlazorBloggingApp.WebAssembly.Models;
using BlazorBloggingApp.WebAssembly.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorBloggingApp.WebAssembly.Layout;
public partial class BlogList : ComponentBase
{
    [Inject]
    public IBlogPostService BlogPostService { get; set; } = default!;

    private List<BlogPost> blogPosts = new();

    protected override void OnInitialized()
    {
        blogPosts = BlogPostService.GetBlogPosts();
    }

    private bool isCollapsed = false; // False shows the list, true hides it

    public void ToggleCollapse() {
        isCollapsed = !isCollapsed;
        Console.WriteLine($"isCollapsed: {isCollapsed}");
    } 
}