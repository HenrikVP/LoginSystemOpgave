//using ...

namespace LoginSystemGP
{
    internal class StartUp
    {
        //Constructor
        public StartUp()
        {
            List<User> addedDataUserList = AddData();
            User inputUser = GetInput();
            CheckIfUserExists(addedDataUserList, inputUser);
        }

        private List<User> AddData()
        {            
            User user1 = new User() { Email="Hans@tec.dk", Password="Pass1234"};
            User user2 = new User() { Email= "Per@tec.dk", Password="Pass1234"};
            User user3 = new User() { Email= "Søren@tec.dk", Password="Pass1234"};
            List<User> userList = new List<User>() { user1, user2, user3 };
            return userList;
        }
        public User GetInput() 
        {
            Console.Write("Login\nEmail:");
            string inputEmail = Console.ReadLine();

            Console.Write("Password:");
            string inputPassword = Console.ReadLine();

            User bruger = new User();
            bruger.Email = inputEmail;
            bruger.Password = inputPassword;
            return bruger;
        }

        private void CheckIfUserExists(List<User> fullUserList, User checkingUser)
        {
            foreach (User user in fullUserList)
            {
                if (checkingUser.Email == user.Email)
                {
                    Console.WriteLine("yay! We found a user that matched!");

                    if (checkingUser.Password == user.Password)
                    {
                        Console.WriteLine("And he even put his correct password THE FIRST ATTEMPT!!!");
                    }
                    else Console.WriteLine("WRONG PASSWORD!!! DOES NOT COMPLY");
                } 
            }
        }
    }
    internal class User
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
