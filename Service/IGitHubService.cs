using Octokit;

namespace Service
{
    public interface IGitHubService
    {
        public Task<List<PortFolio>> GetPortfolio();
        public Task<List<Repository>> SearchRepositories(string? repositoryName, string? language, string? userName);
    }
}