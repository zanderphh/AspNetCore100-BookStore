﻿namespace Tokiota.BookStore.Entities
{
    using Core;
    using System;
    public class Book : EntityCore<Guid>
    {
        public Book()
        {
        }

        public string Name { get; set; }
        public int Published { get; set; }
        public string Genre { get; set; }
        public string Photo { get; set; }

        public Guid AuthorId { get; set; }
        public Author Author { get; set; }
        public Guid? SerieId { get; set; }
        public Serie Serie { get; set; }

    }
}
