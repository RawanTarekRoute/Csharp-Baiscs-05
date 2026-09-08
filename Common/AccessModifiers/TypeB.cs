namespace Route.CsharpBasics05.AccessModifiers
{
    class TypeB
    {

        void TestAccess()
        {
            TypeA typeA = new TypeA();
            //Console.WriteLine(typeA.x);  // private cannot be accessed from different class
            Console.WriteLine(typeA.y); // Internal can be accesed from any class, and must be in the same project as the class it was defined in
            Console.WriteLine(typeA.z); // Public

        }
    }
}
