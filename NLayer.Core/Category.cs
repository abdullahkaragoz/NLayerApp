namespace NLayer.Core
{
    public class Category : BaseEntity
    {
        public String Name { get; set; }

        //Navigation Property
        public ICollection<Product> Products { get; set; }
    }
}
