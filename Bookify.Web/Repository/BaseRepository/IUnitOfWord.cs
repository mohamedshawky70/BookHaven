namespace BookHaven.Web.Repository.BaseRepository
{
	public interface IUnitOfWord
	{
		public IBaseRepo<Category> Categories { get; }
		public IBaseRepo<Author> Authors { get; }
		public IBaseRepo<Book> Books { get; }
		public IBaseRepo<BookCategory> BookCategories { get; }
		public IBaseRepo<CopyBook> CopiesBook { get; }
		public IBaseRepo<Subscriper> Subscriper { get; } 
		public IBaseRepo<Area> Area { get; } 
		public IBaseRepo<Governorate> Governorate { get; }
		public IBaseRepo<Rental> Rental { get; }
		public int Commit();
	}
}