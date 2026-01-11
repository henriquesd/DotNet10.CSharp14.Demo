namespace DotNet10.CSharp14.Demo
{
    #region Extension methods example

    public static class StringExtensions
    {
        public static bool IsCapitalized(this string str)
            => !string.IsNullOrEmpty(str) && char.IsUpper(str[0]);
    }

    public static class OrderExtensionsMethods
    {
        public static void MarkAsProcessedExtensionMethodDemo(this Order order)
             => order.Status = "Shipped";

        public static void PrintStatusExtensionMethodDemo(this Order order)
            => Console.WriteLine($"Order Status: {order.Status}");
    }

    #endregion

    #region Extension members example

    public static class OrderExtensionMembers
    {
        extension (Order order)
        {
            public void MarkAsProcessedExtensionMemberDemo()
                => order.Status = "Shipped";

            public void PrintStatusExtensionMemberDemo()
                => Console.WriteLine($"Order Status: {order.Status}");

            // Adding a property, this was not possible before
            public string UppercaseStatus => order.Status?.ToUpper() ?? "UNKNOWN";
        }
    }

    #endregion
}