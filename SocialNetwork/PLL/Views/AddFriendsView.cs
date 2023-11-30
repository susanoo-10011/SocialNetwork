using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.DAL.Entities;
using SocialNetwork.DAL.Repositories;
using SocialNetwork.Pll.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.PLL.Views
{
    public class AddFriendsView
    {

        public void Show(User user)
        {
            try
            {
                var userRopository = new UserRepository();
                var userAddFriendData = new AddFriendData();
                var friendRepository = new FriendRepository();

                var userService = new UserService();

                Console.WriteLine("Введите почтовый адрес пользователя, которого хотите добавить в друзья: ");
                userAddFriendData.FriendEmail = Console.ReadLine();
                userAddFriendData.UserId = user.Id;

                userService.AddFriend(userAddFriendData);

                Console.WriteLine($"Пользователь добавлен в друзья.");

            }
            catch (UserNotFoundException)
            {
                AlertMessage.Show("Пользователь с данным почтовым адресом не найден.");
            }
            catch(Exception)
            {
                AlertMessage.Show("Произошла неизвестная ошибка при добавлении пользователя в друзья.");
            }
        }
    }
}
