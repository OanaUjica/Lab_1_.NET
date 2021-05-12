using System;
using System.ComponentModel.DataAnnotations;

namespace Lab1_.NET.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Description is required.")]
        public string Description { get; set; }

        public ushort DurationInMinutes { get; set; }

        [Required(ErrorMessage = "Year of release is required.")]
        public byte YearOfRelease { get; set; }

        public string Director { get; set; }

        [Range(1, 10)]
        public float? Rating { get; set; }

        public bool Watched { get; set; }
    }

    public enum Genre
    {
        Action,
        Comedy,
        Horror,
        Thriller
    }
}
