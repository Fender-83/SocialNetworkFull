using SocialNetwork.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.PLL.Views
{
    public class FriendsOfUserView
    {
        public void Show(IEnumerable<User> friends)
        {
            Console.WriteLine("Мои друзья");


            if (friends.Count() == 0)
            {
                Console.WriteLine("Нет друзей");
                return;
            }

            foreach (var f in friends)
            {
                Console.WriteLine("E-mail адрес друга: {0}. \nИмя друга: {1}. \nФамилия друга: {2}", f.Email, f.FirstName, f.LastName);
            }
        }
    }
}