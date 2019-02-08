namespace EFGetStarted.AspNetCore.NewDb.Models
{
    public class Shop
    {
        public Shop(int id, string shopName)
        {
            this.Id = id;
            this.ShopName = shopName;

        }

        public int Id { get; set; }
        public string ShopName { get; set; }
    }
}