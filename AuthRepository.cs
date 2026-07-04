using Demo_2_sun.Data;
using Demo_2_sun.Models;
using Demo_2_sun.Repositorys.Interfaces;

namespace Demo_2_sun.Repositorys.CLASSES
{
    public class AuthRepository : IAuthRepository
    {
        private readonly ApplicationDbContext _context;

        public AuthRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public User Register(User user)
        {
            _context.users.Add(user);
            return user;
        }

        public User Login(string email)
        {
            return _context.users.FirstOrDefault(x => x.Email == email);
        }

        public User GetUserByEmail(string email)
        {
            return _context.users.FirstOrDefault(x => x.Email == email);
        }

        public User GetUserById(int id)
        {
            return _context.users.Find(id);
        }

        public User UpdateUser(User user)
        {
            _context.users.Update(user);
            return user;
        }

        public User UpdatePassword(User user)
        {
            _context.users.Update(user);
            return user;
        }

        public RefreshToken SaveRefreshToken(RefreshToken refreshToken)
        {
            _context.refreshTokens.Add(refreshToken);
            return refreshToken;
        }

        public RefreshToken GetRefreshToken(string token)
        {
            return _context.refreshTokens.FirstOrDefault(x => x.Token == token);
        }

        public void DeleteRefreshToken(RefreshToken refreshToken)
        {
            _context.refreshTokens.Remove(refreshToken);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}