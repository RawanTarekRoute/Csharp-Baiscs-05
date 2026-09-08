namespace Route.CsharpBasics05.AccessModifiers
{
    public class TypeA
    {
        private int x;
        internal int y;
        public int z;

        void TestAccess()
        {
            Console.WriteLine(x); // Private can be accessed in the same class
            Console.WriteLine(y); // INternal  can be accessed in the same class
            Console.WriteLine(z); // Public can be accessed in the same class

        }
    }
}
