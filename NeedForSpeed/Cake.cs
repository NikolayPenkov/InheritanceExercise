namespace Restaurant
{
    public class Cake : Dessert
    {
        const double CakeGrams = 250;
        const double CakeCalories = 1000;
        const decimal CakePrice = 5m;
        public Cake(string name) : base(name, CakePrice, CakeGrams, CakeCalories)
        {
        }
    }
}
