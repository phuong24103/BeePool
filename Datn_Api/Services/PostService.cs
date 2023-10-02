using Datn_Api.Data;
using Datn_Api.IServices;
using Datn_Shared.Models;
using Datn_Shared.ViewModels.PostViewModels;
using Microsoft.EntityFrameworkCore;

namespace Datn_Api.Services
{
    public class PostService : IPostService
    {
        private readonly MyDbContext _context;

        public PostService(MyDbContext context)
        {
            _context = context;
        }

        public async Task<bool> CreatePost(CreatePost post)
        {
            Post p = new Post()
            {
                Id = Guid.NewGuid(),
                UserId = post.UserId,
                Content = post.Content,
                Title = post.Title,
                Image = post.Image,
                CreateDate = DateTime.Now,
                Description = post.Description,
                Status = post.Status,
            };
            try
            {
                await _context.Posts.AddAsync(p);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> DeletePost(Guid id)
        {
            var post = _context.Posts.Find(id);
            if (post == null) return false;
            post.Status = 2;
            try
            {
                _context.Posts.Update(post);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<List<Post>> GetAllPost()
        {
            List<Post> lstPostView = new List<Post>();
            lstPostView = await
                (from a in _context.Posts
                 join b in _context.Users on a.UserId equals b.Id
                 select new Post()
                 {
                     Id = a.Id,
                     UserId = a.UserId,
                     Content = a.Content,
                     Title = a.Title,
                     Image = a.Image,
                     CreateDate = a.CreateDate,
                     Description = a.Description,
                     Status = a.Status,
                     User = b
                 }).ToListAsync();
            return lstPostView;
        }

        public async Task<Post> GetPostById(Guid id)
        {
            Post lstPostView = new Post();
            lstPostView = await
                (from a in _context.Posts
                 join b in _context.Users on a.UserId equals b.Id
                 where a.Id == id
                 select new Post()
                 {
                     Id = a.Id,
                     UserId = a.UserId,
                     Content = a.Content,
                     Title = a.Title,
                     Image = a.Image,
                     CreateDate = a.CreateDate,
                     Description = a.Description,
                     Status = a.Status,
                     User = b
                 }).FirstAsync();
            return lstPostView;
        }

        public async Task<List<Post>> GetPostByTitle(string title)
        {
            List<Post> lstPostView = new List<Post>();
            lstPostView = await
                (from a in _context.Posts
                 join b in _context.Users on a.UserId equals b.Id
                 select new Post()
                 {
                     Id = a.Id,
                     UserId = a.UserId,
                     Content = a.Content,
                     Title = a.Title,
                     Image = a.Image,
                     CreateDate = a.CreateDate,
                     Description = a.Description,
                     Status = a.Status,
                     User = b
                 }).Where(p => p.Title.ToLower().Contains(title.ToLower())).ToListAsync();
            return lstPostView;
        }

        public async Task<bool> UpdatePost(Guid id, UpdatePost post)
        {
            var n = _context.Posts.Find(id);
            if (n == null) return false;
            n.UserId = post.UserId;
            n.Content = post.Content;
            n.Title = post.Title;
            n.Image = post.Image;
            n.Description = post.Description;
            n.Status = post.Status;
            try
            {
                _context.Posts.Update(n);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}