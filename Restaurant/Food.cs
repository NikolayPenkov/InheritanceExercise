namespace Restaurant
{
    public class Food : Product
    {
        public Food(string name, decimal price, double grams) : base(name, price)
        {
            this.Grams = grams;
        }
        double Grams { get; set; }
    }
}
