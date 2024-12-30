namespace BookHaven.Web.Core.Models
{
	public class BaseModel
	{
		public bool IsDeleted { get; set; } //by defual false
		public DateTime CreatedOn { get; set; } = DateTime.Now;
		public DateTime? LastUpdatedOn { get; set; }
	}
}
