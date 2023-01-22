namespace Animal_Sims_Up
{
    public abstract class Animal
    {
        public string Name = "";
        public int Age;
        public string FoodName = "";
        public int FoodAmount;
        public int Slot;
        protected double food = 100;
        protected double drink = 100;
        protected double sleep = 100;
        protected double health = 100;
        public abstract void Drink();
        public abstract void Eat();
        public abstract void Sleep();
        public abstract void Speak();
        public abstract void Logic();
    }
}
