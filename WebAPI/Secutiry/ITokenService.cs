using Model.Entities;

namespace WebAPI.Secutiry
{
    public interface ITokenService
    {
        string GetToken(User usuario);
    }
}
