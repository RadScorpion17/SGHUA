using DataAccess;
using Common.Cache;

namespace Domain
{
    public class UserModel
    {
        UserDao userDao = new UserDao();

        public bool LoginUser(string username, string password)
        {
            return userDao.Login(username, password);
        }

        public bool eliminar(Usuario user)
        {
            return userDao.Eliminar(user);
        }

        public bool editar(Usuario user)
        {
            return userDao.Editar(user);    
        }

        public bool guardar(Usuario user) 
        {
            return userDao.Guardar(user);
        }

        public List<Usuario> mostrar()
        {
            return userDao.Listar();
        }
    }
}