using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Bulletin.Repository;

namespace Bulletin.Models
{
    public class Board
    {
        BulletinContext _context;
        public Board()
        {
            _context = new BulletinContext();
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
        public virtual ICollection<Post> Posts { get; set; }

        
        public List<Board> GetBoards()
        {
            BulletinContext _context = new BulletinContext();
            List<Board> _listOfBoard = new List<Board>();
            _listOfBoard = _context.Boards.ToList();
            return _listOfBoard;
        }
        public Board GetBoard(int id)
        {
           
            return _context.Boards.Find(id);
        }
        public bool CreateBoard(Board board)
        {
            try
            {
                _context.Boards.Add(board);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateBoardPost(Post post, int id)
        {
            Board _board = GetBoard(id);
            _board.Posts.Add(post);
            _context.SaveChanges();
            return true;
        }

    }
}