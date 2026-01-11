namespace DotNet10.CSharp14.Demo
{
    public class NullConditionalAssignment
    {
        #region Before C# 14 example
        public void DemoBeforeCSharp14()
        {
            Order? order = GetOrder();

            if (order is not null)
            {
                order.Status = "Processed";
                order.UpdatedAt = DateTime.UtcNow;
            }

            Console.WriteLine(@"Safe check completed, using ""if"".");
        }
        #endregion

        #region C# 14 Null-conditional assignment example
        public void DemoCSharp14()
        {
            Order? order = GetOrder();

            // If order is null, the assignment is skipped and no NullReferenceException is thrown.
            order?.Status = "Processed";
            order?.UpdatedAt = DateTime.UtcNow;

            Console.WriteLine(@"Safe assignment completed, using ""?."".");
        }
        #endregion

        private Order? GetOrder() => null;
    }
}