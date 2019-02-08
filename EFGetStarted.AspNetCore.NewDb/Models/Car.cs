namespace EFGetStarted.AspNetCore.NewDb.Models
{
    public class Car
    {
        public Car(int id, string brand)
        {
            this.Id = id;
            this.Brand = brand;
        }
        
        public int Id { get; set; }
        public string Brand { get; set; }
    }
}