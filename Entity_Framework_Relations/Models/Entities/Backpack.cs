﻿using System.Text.Json.Serialization;

namespace Entity_Framework_Relations.Models.Entities
{
    public class Backpack
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int CharacterId { get; set; }
        [JsonIgnore]
        public Character Character { get; set; }
    }
}
