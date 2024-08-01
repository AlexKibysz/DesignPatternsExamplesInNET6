namespace PatronesEstructurales._6.PROXY
{
    internal class ProxyLazyLoading
    {
    }

    // Interfaz para el repositorio de productos
    public interface IProductRepository
    {
        List<Product> GetProducts();
    }

    // Clase concreta para el repositorio de productos real
    public class ProductRepository : IProductRepository
    {
        public List<Product> GetProducts()
        {
            // Lógica para obtener los productos desde la base de datos
            // (simulación en este ejemplo)
            return new List<Product>
        {
            new Product { Id = 1, Name = "Producto A" },
            new Product { Id = 2, Name = "Producto B" }
            // ...
        };
        }
    }

    // Proxy para el repositorio de productos
    public class ProductRepositoryProxy : IProductRepository
    {
        private readonly Lazy<IProductRepository> _realRepository;

        public ProductRepositoryProxy(Func<IProductRepository> repositoryFactory)
        {
            _realRepository = new Lazy<IProductRepository>(repositoryFactory);
        }

        public List<Product> GetProducts()
        {
            // La inicialización diferida ocurre aquí
            return _realRepository.Value.GetProducts();
        }
    }

    // Modelo de producto
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    // Configuración en Startup.cs
    // Asegúrate de configurar la inyección de dependencias para que utilice ProductRepositoryProxy
    // en lugar de ProductRepository

    // Ejemplo de uso en una clase de servicio o controlador
    public class ProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public List<Product> GetProducts()
        {
            // Llamada al método GetProducts a través del proxy
            return _productRepository.GetProducts();
        }
    }
}