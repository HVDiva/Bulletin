using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bulletin.Models;

namespace Bulletin.Repository
{
    public class BulletinInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<BulletinContext>
    {
        protected virtual void Seed(BulletinContext _context)
        {
            // Create a User object and set it's properties
            // Add the user object to the Users property of _context
            User user = new User();
            user.Name = "Steph";
            user.Username = "steph_libby";
            user.Password = "password";
            user.UserType = "ADMIN";
            user.LastLoginDate = DateTime.Parse("2019-06-01");
            _context.Users.Add(user);


            Board board = new Board();
            board.Name = "Introduce yourself";
            board.DateCreated = DateTime.Parse("2019-12-05");
            _context.Boards.Add(board);



            Post post = new Post();
            post.Text = "Hey!";
            post.DateCreated = DateTime.Parse("2019-12-05");
            _context.Posts.Add(post);





            // call the method of _context to commit
            _context.SaveChanges(); // Commit to database
        }
    }
}