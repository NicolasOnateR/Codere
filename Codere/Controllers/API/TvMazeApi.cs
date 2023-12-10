using Codere.Controllers.DB;
using Codere.Models;
using Hangfire;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using static Codere.Controllers.API.ApiKeyAuthorize;

namespace Codere.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class TvMazeApi : ControllerBase
    {
        private readonly DataJob _dataJob;

        public TvMazeApi(DataJob dataJob)
        {
            _dataJob = dataJob;
        }

        [HttpPost("RequirementOne")]
        [ApiKeyAuthorize] //RequerimentTwo
        public async Task<IActionResult> ExecuteJobAsync([FromBody] Information show, int showId)
        {
            //Connexion with API tv and get JSON data
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync($"https://api.tvmaze.com/shows/{showId}");
            var content = await response.Content.ReadAsStringAsync();

            //Parsing data to obj
            Information inf = JsonConvert.DeserializeObject<Information>(content);

            //EF add to DB
            _dataJob.AddShow(inf);
            return Ok("Requeriment one completed");
        }

        //Requeriment Three
        [HttpGet]
        public IActionResult GetShows()
        {
            var shows = _dataJob.GetShows();
            return Ok(shows);
        }
    }
}
