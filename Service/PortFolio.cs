using Octokit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class PortFolio
    {

        public string? Language { get; set; }
        public DateTime Commit { get; set; }
        public int Stars { get; set; }
        public int PullRequest { get; set; }
        public string Url { get; set; }

        public PortFolio(string? language, DateTime commit, int stars, int pullRequest, string url)
        {
            Language = language;
            Commit = commit;
            Stars = stars;
            PullRequest = pullRequest;
            Url = url;
        }
    }
}
