namespace asp_less3_ex1_calc.Model
{
    public class TreeProducts
    {
        public int Id { get; set; }
        public double Price { get; init; }
        public string Name { get; init; }
        public TreeProducts() { }
        public TreeProducts(int id, double price, string name)
        {
            Id = id;
            Price = price;
            Name = name;
        }
        public override string ToString()
        {
            return $"Id: {Id} - Name: {Name} - Price: {Price}";
        }
    }
}
