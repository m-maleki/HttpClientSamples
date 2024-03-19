using System.Net.WebSockets;
using HttpClientExtensions.Models;
using HttpClientExtensions.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HttpClientExtensions.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IPostService _postService;

        [BindProperty]
        public IEnumerable<Post> Posts { get; set; }
        public Post Post { get; set; }

        public IndexModel(IPostService postService)
        {
            _postService = postService;
        }

        public async Task OnGetAsync()
        {
            Posts = await _postService.GetAll(default);

            Post = await _postService.Get(10,default);


        }
    }
}
