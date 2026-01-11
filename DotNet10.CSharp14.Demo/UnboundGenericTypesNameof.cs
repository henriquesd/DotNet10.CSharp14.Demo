namespace DotNet10.CSharp14.Demo
{
    public class UnboundGenericTypesNameof
    {
        public void DemoBeforeCSharp14()
        {
            // It was necessary to provide a type like <string>, <User>, etc,
            // even if we only wanted the name of the class.
            Console.WriteLine(nameof(Logger<string>));
            Console.WriteLine(nameof(Logger<User>));
        }

        public void DemoCSharp14()
        {
            // Use the unbound syntax <> for one parameter.
            Console.WriteLine(nameof(Logger<>));

            // Use the comma <,> for two parameters.
            Console.WriteLine(nameof(DataMapper<,>));
        }
    }

    public class Logger<T> { }

    public class User { }

    public class DataMapper<TSource, TDestination> { }
}
