using Codere.Models;
using Hangfire;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace Codere.Controllers.DB
{
    public class DataJob
    {
        private readonly TvMaze _dbContext;

        public DataJob(TvMaze dbContext)
        {
            _dbContext = dbContext;
        }

        //Add to DB
        public void AddShow(Information inf)
        {
            _dbContext.Information.Add(inf);
            _dbContext.SaveChanges();
        }

        // Get from DB
        public List<Information> GetShows()
        {
            return _dbContext.Information.ToList();
        }
    }
}
