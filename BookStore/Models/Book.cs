namespace BookStore.Models
{
	public class Book
	{
		public string? Id { get; set; }

		public string? Title { get; set; }
		public string? Author { get; set; }
		public string? Publisher { get; set; }
		public string? ISBN { get; set; }
		public string? Genre { get; set; }
		public decimal Price { get; set; }

		public string? Description { get; set; }

		public string? ImageUrl { get; set; }

		public string? Language { get; set; }

		public int Pages { get; set; }

		public string? Format { get; set; }

		public string? Edition { get; set; }

		public DateTime PublishDate { get; set; }

		public string? Category { get; set; }

		
	}
}
