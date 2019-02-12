namespace EFGetStarted.AspNetCore.NewDb.Entities
{

    public enum CuisineType
    {
        french,
        italian,
        japanese,
        Belgian,

        Brazilian
    }
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public CuisineType Cuisine { get; set; }
    }
}