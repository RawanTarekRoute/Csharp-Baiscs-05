using Common;
using Route.CsharpBasics05.AccessModifiers;
namespace Route.Csharp05
{
    internal class Program
    {
       // ProgramClass => PascalCase
         static int AddTwoNumber(int a , int b) {
           int result =  a + b;
            return result;
            
        }

        static void MultiplyByTwo(int number)
        {
            number *= 2;
            Console.WriteLine(number);
        }
        static void MultiplyByTwo(ref int number)
        {
            number *= 2;
            Console.WriteLine(number);
        }

        //                        1A2B => [10, 20, 30, 40]
        static void ApplyDiscount(int[] prices)
        {
            if (prices is not null && prices.Length > 0)
            {
                for(int i = 0; i < prices.Length; i++)
                {
                    prices[i] -= 5;
                }
            }
        }

        static bool TryGetResult(int input, out int result)
        {
            if (input > 0)
            {
                result = input * 2;
                return true;
            }

            result = 0;
            return false;
        }

        static void ReplaceArray(int[] arr)
        {
            arr = [1, 2, 3];
        }
        static void ReplaceArray(ref int[] arr)
        {
            arr = [1, 2, 3];
        }

        static void ApplyDiscount(ref int[] prices)
        {
            if (prices is not null && prices.Length > 0)
            {
                for(int i = 0; i < prices.Length; i++)
                {
                    prices[i] -= 5;
                }
            }
        }

        static void SendMessage(int age, string from, string message = "Default Message")
        {
            Console.WriteLine($"Send {message} from {from} with age {age}");
        }

        static void PrintNumbers(int size, params int[] numbers)
        {
            foreach(int number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        static void PrintNames(params string[] names)
        {
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
        }

        static void Main(string[] args)
        {
            #region Arrays

            /*
             * Array: a collection of elements of the same data type,
             * stored in contiguous memory, accessed using an index.
             * Fixed size — once created, size cannot be changed.
             * O(1) random access — index used to calculate memory address
             */

            #region 1D Array

            //int[] numbers;
            //numbers = new int[3];

            //numbers[0] = 100;
            //numbers[1] = 200;
            //numbers[2] = 300;
            ////numbers[3] = 400;
            ///


            //int[] numbers = new int[5] { 100, 200, 300, 400, 500 };
            //int[] numbers = new int[] { 100, 200, 300, 400, 500 };
            //int[] numbers = { 100, 200, 300, 400, 500 };
            //int[] numbers = [ 100, 200, 300, 400, 500 ]; // C# 12

            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}


            #endregion

            #region 2D Arrays

            /*
             * 2D Array: elements stored in a two-dimensional grid, accessed with two indices.
             * First index = row, Second index = column.
             * - Length       => total number of elements
             * - GetLength(0) => number of rows
             * - GetLength(1) => number of columns
             * - GetLength(N) => number of elements in the Nth dimension
             */

            // rows * columns => 2 * 3 = 6
            //int[,] matrix = new int[2, 3];

            //matrix[0, 0] = 100;
            //matrix[0, 1] = 200;
            //matrix[1, 0] = 400;

            // 100   200  300
            // 400   500  600

            //int[,] marks =
            //{
            //    {100, 200, 300 },
            //    {400, 500, 600 }
            //};

            //// 6
            //Console.WriteLine(marks.Length);

            //Console.WriteLine(marks.GetLength(0));
            //Console.WriteLine(marks.GetLength(1));

            ////for(int row = 0; row < marks.GetLength(0); row++)
            ////{
            ////    for (int col = 0; col < marks.GetLength(1); col++)
            ////    {
            ////        Console.Write($"{marks[row, col]} \t");
            ////    }

            ////    Console.WriteLine();
            ////}

            //foreach(int mark in marks)
            //{
            //    Console.WriteLine(mark);
            //}

            #endregion

            #endregion

            #region Functions 

            #region User-Defined Functions

            /*
             * Named block of code that performs a specific task and can be called from other parts of the program.
             * Can Take inputs (parameters) and return outputs (return value).
             * Can be defined inside a class or struct, and can be called from other classes or structs.
             * Can be written inside a method, use it if the logic of the inner function will be used by the outer function.
             * Can be static (class member function) or non-static (instance member method).
             *      - Benefits:
             *          - Improved code readability
             *          - Improved code reusability
             *          - Improved code maintainability
             *          - Improved code testability
             *      - Syntax:
             *          [return type] [method name] ([parameters])
             *          - return type: the type of value that the method returns, or void if it does not return a value.
             *          - method name: the name of the method, which should be a valid identifier and follow the naming conventions.
             *          - parameters: the list of input values that the method takes, which can be zero or more, and each parameter should have a type and a name.
             *      - Naming Convention
             *          - PascalCase: The first letter of each word is capitalized, and there are no underscores or spaces between words.
             *          - Verbs: The method name should be a verb that describes the action that the method performs, and it should be in the present tense.
             * [Signature Vs Prototype]
             *      - Function Signature
             *          - MehtodName 
             *          - Parameters
             *      - Function Prototype
             *          - Access Modifier
             *          - Return Type
             *          - Method Name
             *          - Parameters
             */

            //Console.WriteLine(AddTwoNumber(10, 5));

            #region Function Role

            // 5 lines => business logic 

            /*
             *  1. Withdraw
             *  if (accountBalance > amount){
             *      accountBalance -= amount; => accountBalance = accountBalance - amout
             *  }
             *  
             *  2. Transfer
             *  if (accountBalance > amount){
             *      accountBalance -= amount; => accountBalance = accountBalance - amout
             *  }
             *  
             *  3. Pay Bill
             *  if (accountBalance > amount){
             *      accountBalance -= amount; => accountBalance = accountBalance - amout
             *  }
             *  
             *  bool HasEnoughBalance(decimal balance, decimal amount){
             *  
             *      return balance > amount ? true : false;
             *  }
             *  
             *  
             *  1. Withdraw 
             *  
             *  if (HasEnoughBalance(accountBalance, amount)
             *      accountBalance-= amount;1. Withdraw 
             *   2. Trqansfer 
             *   
             *  if (HasEnoughBalance(accountBalance, amount)
             *      accountBalance-= amount;1. Withdraw 
             *      
             *  3. Pay bill
             *  if (HasEnoughBalance(accountBalance, amount)
             *      accountBalance-= amount;1. Withdraw 

             */


            #endregion

            #region Static Vs Non-Static

            #endregion



            #endregion

            #region Passing By Value — Value Type

            /*
             * Passing a copy of the value of the variable to the method not the original
             * Any changes made to the parameter inside the method will not affect the original variable outside the method.
             *
             */

            //int number = 5;
            //MultiplyByTwo(number);
            //Console.WriteLine(number);


            #endregion

            #region Passing By Value — Reference Type

            /*
             * Passing a copy of the reference of the variable to the method not the original
             * Any changes made to the parameter inside the method will affect the original variable outside the method.
             */

            // 1A2B  => [10, 20, 30, 40]
            // 1A2B
            //int[] prices = [10, 20, 30, 40];
            //ApplyDiscount(prices);

            //Console.WriteLine(prices[2]);


            #endregion

            #region Passing By ref — Value Type

            /*
             * Passing the original variable to the method, so any changes made to the parameter inside the method will affect the original variable outside the method.
             */

            int number = 10;
            MultiplyByTwo(ref number);
            Console.WriteLine(number);

            #endregion

            #region Passing By Ref — Reference Type

            /*
             * Passing the original variable to the method, so any changes made to the parameter inside the method will affect the original variable outside the method.
             * What is the difference between passing by value and passing by reference for reference types?
             * Try to change the reference itself
             *        - Passing by value: the reference is copied, so any changes made to the reference inside the method will not affect the original reference outside the method.
             *        - Passing by reference: the reference is passed, so any changes made to the reference inside the method will affect the original reference outside the method.
             */

            //int[] prices = [10, 20, 30, 40];
            //ApplyDiscount(prices);

            //Console.WriteLine(prices[2]);

            #endregion

            #region Passing Reference Type By Value And By Ref
            #region By Value 

            //int[] numbers = [1000, 2000, 3000];
            //ReplaceArray(numbers);
            //Console.WriteLine(numbers[0]);

            #endregion

            #region By Ref
            //int[] numbers = [1000, 2000, 3000];
            //ReplaceArray(ref numbers);
            //Console.WriteLine(numbers[0]);

            #endregion
            #endregion

            #endregion

            #region Passing By Out

            /*
             * Parameter passed by out is used to return multiple values from a method.
             * The variable should be assigned a value before the method returns.
             */

            //int input = 5;
            //bool isGet = TryGetResult(input, out int result);

            //Console.WriteLine(TryGetResult(input, out result));
            //Console.WriteLine(result);
            #endregion

            #region Passing By Name, Default parameters
            /*
             * Passing parameters by name (named arguments) allows you to specify the names of the parameters when calling a method If it will be not passed by order (positional arguments).
             * This makes the code more readable.
             *              
             */

            //// Paasing by function order => positional parameter
            ////SendMessage("Hello", "Rawan", 20);

            //SendMessage(from: "Rawan", message: "This is the message", age: 20);
            //SendMessage( age: 10, from: "Rawan");



            #endregion

            #region Params
            /*
             * params keyword allows you to pass a variable number of arguments to a method.
             * it will be treated in runtime as an array of the specified type.
             * [Constraints]:
             *      - The params parameter must be the last parameter in the method signature.
             *      - The params parameter can only be used once in a method signature.
             *      - The params parameter can be of any type, but it must be a single-dimensional array.
             */

            //PrintNumbers(1, null);
            //PrintNames("Ali", "Mai", "Mohamed");

            #endregion

            #region Class Library
            /*
             * - Type of .Net projects, like Console Application, Web Application, etc...
             * - Compiled into DLL File only, not EXE File.
             * - Used to create reusable components, libraries, that can be a resource for other projects.
             *      Advantages:
             *          - Can be used in multiple projects.
             *          - [Reusability]: One component, Multiple Projects usage.
             *          - [Organization]: Keeps code organized and separated.
             *          - [Collaboration]: Multiple developers can work on different components simultaneously.
             *          - [Maintainability]: One issue, One place to fix, multiple projects benefit from the fix.
             */
            FileHelper.ReadFile("filePath");


            #endregion

            #region Access Modifiers

            /** 
             * Access modifiers are keywords used to define the accessibility of classes, methods, and other members in C#.
             * - They control the visibility and accessibility of types and type members.
             * - Common access modifiers:
             *      - private: Accessible only within the containing class or struct.
             *      - private protected: Accessible within the containing class or derived classes in the same assembly.
             *      - protected: Accessible within the containing class and derived classes.
             *      - internal: Accessible only within the same assembly.
             *      - protected internal: Accessible within the same assembly or from derived classes.
             *      - public: Accessible from anywhere.
             */

            TypeA typeA = new TypeA();
            //typeA.x // Private can be accessed only in the class it was defined in
            //typeA.y // Internal Cannot be accessed from a class in a different project (assembly)
            //typeA.z // public can be acceessed from anywhere.



            #endregion

          

        }
    }
}
