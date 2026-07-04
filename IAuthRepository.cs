using Demo_2_sun.Models;

namespace Demo_2_sun.Repositorys.Interfaces
{
    public interface IAuthRepository
    {
        User GetUserByEmail(string email);
        User UpdateUserPassword(User user);
        User updateUser(User user);
        User Register(User user);
        User Login(string email);
        RefreshToken SaveRefreshToken(RefreshToken refreshToken);

        RefreshToken GetRefreshToken(string token);

        void DeleteRefreshToken(RefreshToken refreshToken);

        void SaveChanges();

    }
}
