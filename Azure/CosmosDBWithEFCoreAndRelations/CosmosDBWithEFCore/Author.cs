﻿using Microsoft.EntityFrameworkCore;
using System;

namespace CosmosDBWithEFCore
{
    [Owned]
    public class Author
    {
        public Author() {  }

        public Guid AuthorId { get; set; } = Guid.NewGuid();
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString() => $"{FirstName} {LastName}";
    }
}
