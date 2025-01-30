namespace Business
{
    public class Animal
    {
        // Public field - accessible from anywhere
        public string Name;

        // Private field - only accessible within this class
        private int age;

        // Protected field - accessible within this class and derived classes
        protected string species;

        // Internal field - accessible within the same assembly
        internal bool isWild;

        // Protected internal - accessible within the same assembly and derived classes
        protected internal string habitat;

        // Private protected - accessible within the same assembly in derived classes
        private protected int weight;

        // Public constructor
        public Animal(string name, int age, string species)
        {
            Name = name;
            this.age = age;
            this.species = species;
            isWild = true;
            habitat = "Unknown";
            weight = 0;
        }

        // Public method - accessible from anywhere
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Species: {species}");
        }

        // Private method - only accessible within this class
        private void UpdateAge()
        {
            age++;
        }

        // Protected method - accessible within this class and derived classes
        protected void ChangeHabitat(string newHabitat)
        {
            habitat = newHabitat;
        }

        // Internal method - accessible within the same assembly
        internal void SetWildStatus(bool wild)
        {
            isWild = wild;
        }

        // Protected internal method - accessible within the same assembly and derived classes
        protected internal void UpdateWeight(int newWeight)
        {
            weight = newWeight;
        }
    }
} 