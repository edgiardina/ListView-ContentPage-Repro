using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ListView_ContentPage_Repro.Models
{

    public class TournamentResult
    {
        [JsonPropertyName("player_id")]
        public int? PlayerId { get; set; }

        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }

        [JsonPropertyName("last_name")]
        public string LastName { get; set; }

        [JsonPropertyName("country_name")]
        public string CountryName { get; set; }

        [JsonPropertyName("country_code")]
        public string CountryCode { get; set; }

        [JsonPropertyName("position")]
        public int Position { get; set; }

        [JsonPropertyName("points")]
        public double Points { get; set; }

        [JsonPropertyName("wppr_rank")]
        public int WpprRank { get; set; }

        [JsonPropertyName("ratings_value")]
        public double? RatingsValue { get; set; }

        [JsonPropertyName("excluded_flag")]
        public string ExcludedFlag { get; set; }

        [JsonPropertyName("player_tournament_count")]
        public int PlayerTournamentCount { get; set; }
    }

}
