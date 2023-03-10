﻿using Newtonsoft.Json;

namespace Sales.Shared.Responses
{
    public class CategoryResponse
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("iso2")]
        public string? Iso2 { get; set; }
    }
}