﻿namespace BookHaven.Web.Core.Models
{
	public class BookCategory
	{
		//composit key
		public int BookId { get; set; }
		public Book? Book { get; set; }
		public int CategoryId { get; set; }
		public Category? Category { get; set; }

	}
}
