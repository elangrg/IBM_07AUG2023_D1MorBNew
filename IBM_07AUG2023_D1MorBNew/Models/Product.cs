namespace IBM_07AUG2023_D1MorBNew.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int Qty { get; set; }
    }

    public interface IProductLocalContext
    {
        void AddNewProduct(Product product);
        void DeleteProduct(int prdid, Product product);
        IEnumerable<Product> GetAllProducts();
        Product GetProductByID(int prdID);
        void UpdateProduct(int prdid, Product product);
    }

    public class ProductLocalContext : IProductLocalContext
    {
        static List<Product> Products;

        static ProductLocalContext()
        {
            Products = new List<Product> { new Product { ProductID = 1000, ProductName = "BMW", Qty = 10 } };
        }


        public Product GetProductByID(int prdID)
        {
            return Products.SingleOrDefault(p => p.ProductID == prdID);
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return Products;
        }


        public void AddNewProduct(Product product)
        {
            product.ProductID = Products.Max(p => p.ProductID) + 1;
            Products.Add(product);
        }


        public void UpdateProduct(int prdid, Product product)
        {
            if (prdid != product.ProductID) return;

            Product prd = Products.SingleOrDefault(p => p.ProductID == prdid);
            int idx = Products.IndexOf(prd);
            Products.Remove(prd);
            Products.Insert(idx, product);
        }

        public void DeleteProduct(int prdid, Product product)
        {
            if (prdid != product.ProductID) return;

            Product prd = Products.SingleOrDefault(p => p.ProductID == prdid);
            int idx = Products.IndexOf(prd);
            Products.Remove(prd);
            Products.Insert(idx, product);
        }




    }


}
