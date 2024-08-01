namespace PatronesEstructurales._6.PROXY
{
    public class ProxyCache
    {
        /*using PatronesEstructurales._6.PROXY;

IZooService zooService = new ZooService();

IZooService proxyZooService = new ProxyZooService(zooService);

proxyZooService.GetAnimal(1);

proxyZooService.GetAnimal(2);

proxyZooService.GetAnimal(1);
*/
    }

    public interface IZooService
    {
        Animal GetAnimal(int id);
    }

    public class Animal
    {
        public int id;
        public string name;
    }

    public class ZooService : IZooService
    {
        public Animal GetAnimal(int id)
        {
            return new Animal { id = id, name = $"Animal nro: {id}" };
        }
    }

    public class ProxyZooService : IZooService
    {
        private readonly IZooService _zooService;
        public Dictionary<int, Animal> _Cache = new Dictionary<int, Animal>();

        public ProxyZooService(IZooService zooService)
        {
            this._zooService = zooService;
        }

        public Animal GetAnimal(int id)
        {
            if (_Cache.ContainsKey(id))
            {
                return _Cache[id];
            }

            Animal animal = _zooService.GetAnimal(id);
            _Cache.Add(id, animal);
            return animal;
        }
    }
}