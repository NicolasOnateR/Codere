using Codere.Controllers.DB;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CodereTest
{
    public class Tests
    {
        public void AddShowToDatabase()
        {
            var options = new DbContextOptionsBuilder<TvMaze>()
                .UseSqlServer("CodereTest")
                .Options;

            using (var context = new Codere.Controllers.DB.TvMaze(options))
            {
                var dataJob = new Codere.Controllers.DB.DataJob(context);
                var api = new Codere.Controllers.API.TvMazeApi(dataJob);
                var inf = api.ExecuteJobAsync(new Codere.Models.Information(),1);

                // Assert
                Assert.IsInstanceOf<OkObjectResult>(inf);
            }
        }

        public void GetShows_ReturnsOkResultWithShows()
        {
            var options = new DbContextOptionsBuilder<TvMaze>()
                .UseSqlServer("CodereTest")
                .Options;
            using (var context = new Codere.Controllers.DB.TvMaze(options))
            {
                var dataJob = new Codere.Controllers.DB.DataJob(context);
                var api = new Codere.Controllers.API.TvMazeApi(dataJob);
                var result = api.GetShows();

                // Assert
                Assert.IsInstanceOf<Codere.Models.Information>(result);
                
                Assert.NotNull(result);
            }
        }
    }
}