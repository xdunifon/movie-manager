﻿namespace MovieManager.Models.Database
{
    public class MoviePlaylist
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public int CreatorId { get; set; }
    }
}
