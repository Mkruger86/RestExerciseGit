﻿namespace RestExercise1.Models
{
    public class Books
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return Id + " " + Title + " " + Price;
        }
    }
}
