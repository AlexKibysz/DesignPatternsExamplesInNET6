namespace PatronesEstructurales._6.PROXY
{
    internal class ProxyAuth
    {
    }

    // Interfaz para el servicio de autenticación
    public interface IAuthenticationService
    {
        bool AuthenticateUser(string username, string password);

        // Otros métodos de autenticación...
    }

    // Implementación real del servicio de autenticación
    public class AuthenticationService : IAuthenticationService
    {
        public bool AuthenticateUser(string username, string password)
        {
            // Lógica real de autenticación
            // Verificar credenciales, generar tokens, etc.
            return true;
        }
    }

    // Proxy para el servicio de autenticación
    public class AuthenticationServiceProxy : IAuthenticationService
    {
        private readonly IAuthenticationService _realService;

        public AuthenticationServiceProxy(IAuthenticationService realService)
        {
            _realService = realService;
        }

        public bool AuthenticateUser(string username, string password)
        {
            // Simulación de autenticación
            if (username == "admin" && password == "secret")
            {
                // Agregar lógica adicional aquí (por ejemplo, auditoría)
                return _realService.AuthenticateUser(username, password);
            }
            return false;
        }
    }
}