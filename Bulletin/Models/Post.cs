using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bulletin.Repository;

namespace Bulletin.Models
{
    public class Post
    {
        BulletinContext _context;
        public Post()
        {
            _context = new BulletinContext();
        }
        public int ID { get; set; }
        public string Text { get; set; }
        public DateTime DateCreated { get; set; }

        public List<Post> GetPosts()
        {
            BulletinContext _context = new BulletinContext();
            List<Post> _listOfPost = new List<Post>();
            _listOfPost = _context.Posts.ToList();
            return _listOfPost;
        }
        public bool CreatePost(Board board, User user, Post post)
        {
            try
            {
                Board _board = _context.Boards.Find(board.ID);
                _board.Posts.Add(item: post);
                User _user = _context.Users.Find(user.ID);
                _user.Posts.Add(item: post);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Post GetPost(int id)
        {
            IQueryable<Post> result = from _post
                                      in _context.Posts
                                      where _post.ID == id
                                      select _post;
            return result.FirstOrDefault();
        }

        public bool addPost(Board board, User user, Post post)
        {
            BulletinContext _context = new BulletinContext();
            Board _board = _context.Boards.Find(board.ID);
            _board.Posts.Add(item: post);
            User _user = _context.Users.Find(user.ID);
            _user.Posts.Add(item: post);
            _context.SaveChanges();
            _context.Posts.Find(post.ID);
            return true;
        }
       



    }
}