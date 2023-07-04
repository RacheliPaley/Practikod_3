using Microsoft.Extensions.Caching.Memory;
using Octokit;
using Service;

namespace GitHubApi.CachedServices
{

    public class CachedGitHubService : IGitHubService
    {
        private readonly IGitHubService _gitHubService;
        private readonly IMemoryCache _memoryCache;

        private const string UserPortFolioKey = "UserPortfolioKey";
        public CachedGitHubService(IGitHubService gitHubService, IMemoryCache memoryCache)
        {
            _gitHubService = gitHubService;
            _memoryCache = memoryCache;
        }
        public async Task<List<PortFolio>> GetPortfolio()
        {
            if (_memoryCache.TryGetValue(UserPortFolioKey, out List<PortFolio> portFolio))
                return portFolio;

            var cacheOptions = new MemoryCacheEntryOptions();
            cacheOptions.SetAbsoluteExpiration(TimeSpan.FromSeconds(30));
            cacheOptions.SetSlidingExpiration(TimeSpan.FromSeconds(10));
            cacheOptions.SetSlidingExpiration(TimeSpan.FromSeconds(10));

            return await _gitHubService.GetPortfolio();
        }

        public Task<List<Repository>> SearchRepositories(string? repositoryName, string? language, string? userName)
        {
            return _gitHubService.SearchRepositories(repositoryName, language, userName);
        }
    }
}
