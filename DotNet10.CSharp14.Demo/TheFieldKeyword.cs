namespace DotNet10.CSharp14.Demo
{
    #region In previous C# versions
    public class ProductAutoImplementedProperty
    {
        // Auto-implemented property.
        public string Code { get; set; }
    }

    public class ProductPreviousVersion
    {
        // Manual backing field.
        private string _code;

        public string Code
        {
            get => _code;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Invalid product code.", nameof(value));

                _code = value.Trim().ToUpperInvariant();
            }
        }
    }
    #endregion

    #region C# 14 - The field keyword
    public class Product
    {
        public string Code
        {
            get;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Invalid product code.", nameof(value));

                field = value.Trim().ToUpperInvariant();
            }
        }
    }
    #endregion
}