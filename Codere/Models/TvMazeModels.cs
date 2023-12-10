using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace Codere.Models
{   
    public class Information
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Language { get; set; }
        public string Status { get; set; }
        public int Runtime { get; set; }
        public int AverageRuntime { get; set; }
        public DateTime Premiered { get; set; }
        public DateTime? Ended { get; set; }
        public string? OfficialSite { get; set; }
        public int Weight { get; set; }
        public string? WebChannel { get; set; }
        public string? DvdCountry { get; set; }
        public string Summary { get; set; }
        public int Updated { get; set; }
    }
}
