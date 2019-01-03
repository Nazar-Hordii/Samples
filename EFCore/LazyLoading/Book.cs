﻿using System.Collections.Generic;

namespace LazyLoading
{
    public class Book
    {
        public Book(int bookId, string title) => (BookId, Title) = (bookId, title);

        public int BookId { get; set; }
        public string Title { get; set; }
        public virtual ICollection<Chapter> Chapters { get; } = new List<Chapter>();
        public virtual int? AuthorId { get; set; }
        public virtual int? ReviewerId { get; set; }
        public virtual int? EditorId { get; set; }

        public virtual User? Author { get; set; }
        public virtual User? Reviewer { get; set; }
        public virtual User? Editor { get; set; }
    }
}
