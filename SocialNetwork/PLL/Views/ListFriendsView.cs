using SocialNetwork.BLL.Models;
using SocialNetwork.DAL.Entities;
using SocialNetwork.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.PLL.Views
{
    public class ListFriendsView
    {
        public void Show(User user)
        {

            var friendEntity = new FriendEntity();
            friendEntity.user_id = user.Id;

            var friendRepository = new FriendRepository();
            var friends = friendRepository.FindAllByUserId(user.Id);

            if(friends.Count() == 0)
                Console.WriteLine("У вас нет друзей :(\n");

            Console.WriteLine("Ваши друзья: ");
            foreach (var friend in friends)
            {
                Console.WriteLine($"Айди друга:{friend.friend_id}");
            }
            Console.WriteLine();
        }
    }
}
