namespace Dominio.Repository
{
    public interface IAuthenticationRepository
    {
        bool Authenticate(string email, string password);
    }

    public class AuthenticationRepository : IAuthenticationRepository
    {
       
        bool IAuthenticationRepository.Authenticate(string email, string password) => true;
         
    }
}
