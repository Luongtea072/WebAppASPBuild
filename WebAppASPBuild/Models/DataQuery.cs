namespace aueProject.Models
{
	public class DataQuery
	{
		public string StartDate { get; set; }
		public string EndDate { get; set; }
		public string StartDateVerified => StartDate.Replace("T", " ");

		public string EndDateVerified => EndDate.Replace("T", " ");
		public string QueryStatement => 
		$"SELECT* FROM METTER_DATA WHERE TimeLog > '{StartDateVerified}' AND TimeLog< '{EndDateVerified}';";
	}
}