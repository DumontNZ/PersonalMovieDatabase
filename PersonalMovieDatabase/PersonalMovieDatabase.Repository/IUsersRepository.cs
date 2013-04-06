namespace PersonalMovieDatabase.Repository
{
    public interface IUsersRepository
    {
        void GetAllUsers();
        void GetUser(int userId);
        void GetUser(string username);
        void DeleteUser(int userId);
        void Deleteuser(string username);
    }
}
