using Microsoft.AspNetCore.Mvc;
using Octokit;
using Service;

namespace GitHubApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class userController : ControllerBase
    {
        private readonly IGitHubService _githubService;
        public userController(IGitHubService githubService)
        {
            _githubService = githubService;
        }
   
        [HttpGet("/portFolio")]
        public async Task<List<PortFolio>> GetPortFolio()
        {
            return await _githubService.GetPortfolio();
        }
        [HttpGet("/SearchRepositiry")]
        public async Task<List<Repository>> SearchRepositories(string? language, string? RepositoryName, string? userName)
        {
            return await _githubService.SearchRepositories(RepositoryName, language, userName);
        }
    }


}
