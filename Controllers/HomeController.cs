using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FootballBlogApi.Models;
using FootballBlogApi.Interfaces;
using FootballBlogApi.Mappers;
using System.Text.Json;

namespace FootballBlogApi.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IPostRepository _postRepository;

    public HomeController(ILogger<HomeController> logger, IPostRepository postRepository)
    {
        _logger = logger;
        _postRepository = postRepository;
    }

    public async Task<IActionResult> Index()
    {
        var posts = await _postRepository.GetAllPostAsync();

        var postDtos = posts.Select(p => p.ToPostDto()).ToList();

        return View(postDtos);
    }

    public async Task<IActionResult> Detail(int id)
    {
        var post = await _postRepository.GetPostByIdAsync(id);

        if (post == null)
        {
            return NotFound();
        }

        var postDto = post.ToPostDto();

        return View(postDto);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
