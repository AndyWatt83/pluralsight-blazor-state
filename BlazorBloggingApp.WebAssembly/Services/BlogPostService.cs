using BlazorBloggingApp.WebAssembly.Models;
using static BlazorBloggingApp.WebAssembly.Layout.BlogList;

namespace BlazorBloggingApp.WebAssembly.Services;

public interface IBlogPostService
{
    BlogPost? GetPostById(int id);
    List<BlogPost> GetBlogPosts();
    Task<BlogPost?> GetPostByIdAsync(int id);
    Task<bool> UpdateBlogPostAsync(int id, string title, string content);
}

public class BlogPostService : IBlogPostService
{
    private List<BlogPost> blogPosts = new()
    {
        new BlogPost { Id = 1, Title = "Introduction to Blazor", Content = "Lorum Ipsum Sit etc" },
        new BlogPost { Id = 2, Title = "State Management in Blazor", Content = "Lorum Ipsum Sit etc" },
        new BlogPost { Id = 3, Title = "Building a Blog with Blazor", Content = "Lorum Ipsum Sit etc" }
        // Additional posts
    };

    public BlogPost? GetPostById(int id) => blogPosts.FirstOrDefault(p => p.Id == id);

    public async Task<BlogPost?> GetPostByIdAsync(int id) => await Task.Run(() => blogPosts.FirstOrDefault(p => p.Id == id));

    public List<BlogPost> GetBlogPosts() => blogPosts;

    public async Task<bool> UpdateBlogPostAsync(int id, string title, string content)
    {
        var post = blogPosts.FirstOrDefault(p => p.Id == id);
        if (post != null)
        {
            // Update properties
            post.Title = title;
            post.Content = content;

            return await Task.FromResult(true); // Return true to indicate success
        }
        return await Task.FromResult(false); // Return false if the post was not found
    }
}