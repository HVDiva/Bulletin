using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bulletin.Repository;

namespace Bulletin.Models
{
    public class User
    {
        BulletinContext _context;
        public User()
        {
            _context = new BulletinContext();
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string UserType { get; set; }
        public DateTime LastLoginDate { get; set; }
        public virtual ICollection<Board> Boards { get; set; }
        public virtual ICollection<Post> Posts { get; set; }

        public List<User> GetUsers()
        {
            List<User> _listOfUser = new List<User>();
            _listOfUser = _context.Users.ToList();
            return _listOfUser;
        }
        public User GetUser(int id)
        {
            return _context.Users.Find(id);
        }
        public bool UpdateUserBoard(Board board, int id)
        {
            User _user = GetUser(id);
            _user.Boards.Add(board);
            _context.SaveChanges();
            return true;
        }

        public bool UpdateUserPost(Post post, int id)
        {
            User _user = GetUser(id);
            _user.Posts.Add(post);
            _context.SaveChanges();
            return true;
        }


        public User UpdateUser(User user)
        {
            User _user = GetUser(user.ID);
            _user.Name = user.Name;
            _user.Password = user.Password;
            _user.UserType = user.UserType;
            _user.LastLoginDate = user.LastLoginDate;
            _user.Boards = user.Boards;
            _context.SaveChanges();
            return _context.Users.Find(user.ID);
        }
        public bool UpdatePassword(User user)
        {
            User _user = GetUser(user.ID);
            _user.Password = user.Password;
            _context.SaveChanges();
            return true;
        }
        public List<string> GetUsernames()
        {
            IQueryable<string> usernames = from _usernames
                                        in _context.Users
                                        select _usernames.Username;
            return usernames.ToList();
        }
        public User Login(string username, string password)
        {
            if (GetUsernames().Contains(username))
            {
                User user = GetUser(username);
                if (user == null)
                    return null;
                else if (user.Password == password)
                {
                    user.LastLoginDate = DateTime.Now;
                    UpdateUser(user);
                    return user;
                }
                else
                    return null;
            }
            else
                return null;
        }
        public bool Register(User user)
        {
            try
            {
                _context.Users.Add(user);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public List<Post> GetPosts()
        {
            List<Post> _listOfPost = new List<Post>();
            _listOfPost = _context.Posts.ToList();
            return _listOfPost;
        }
        public bool DeleteUser(User user)
        {
            try
            {
                _context.Users.Remove(user);

                List<Post> postList = GetPosts();
                user.Posts = postList;
                postList.Clear();
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public User GetUser (string username)
        {
            IQueryable<User> result = from _user
                                      in _context.Users
                                      where _user.Username == username
                                      select _user;
            return result.FirstOrDefault();
        }


        //public User GetUserByPost(Post post)
        //{
        //    IQueryable<User> result = from _user
        //                              in _context.Users
        //                              where _user.Posts.Contains(post)
        //                              select _user;
        //    return result.FirstOrDefault();
        //}

        //public User GetUserByPost(int postid)
        //{
        //    IQueryable<User> result = from _user
        //                              in _context.Users
        //                              where _user.Posts.Select<Post, int>(postid).Contains(postid)
        //                              select _user;
        //    return result.FirstOrDefault();
        //}

        public string GetUsername(Post post)
        {
            List<User> userList = GetUsers();
            int d = 0;
            User user = new User();
            string username = "Could not identify user";
            bool userFound = false;
            //while (userFound == false)
            //{
                for (int i = 0; i < userList.Count; i++)
                {

                    for (int j = 0; j < userList.ElementAt(i).Posts.Count; j++)
                    {
                        d = userList.ElementAt(i).Posts.ElementAt(j).ID;
                        if (userList.ElementAt(i).Posts.ElementAt(j).ID == post.ID)
                        {
                            user = userList.ElementAt(i);
                            userFound = true;
                            username = user.Username;
                        }
                    }

                }

            //}
            return username;
        }
    
        

    }
}