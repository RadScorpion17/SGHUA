using DataAccess;

namespace Domain
{
    public class UserModel
    {
        UserDao userDao = new UserDao();

        public bool LoginUser(string username, string password)
        {
            return userDao.Login(username, password);
        }
    }
}