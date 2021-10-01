namespace Core.Entities.Procedures
{
    public class MostRated
    {
        public int MovieID { get; set; }
        public string Title { get; set; }
        public int NumberOfRatings { get; set; }
        public double AverageRating { get; set; }
    }
}
