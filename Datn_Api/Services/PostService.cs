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
            try
            {
                Post p = new Post()
                {
                    Id = Guid.NewGuid(),
                    EmployeeId = post.EmployeeId,
                    Title = post.Title,
                    Content = post.Content,
                    Description = post.Description,
                    Image = post.Image,
                    CreatedDate = DateTime.Now,
                    Status = 0,
                };
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
            try
            {
                post.Status = 2;
                _context.Posts.Update(post);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<List<PostView>> GetAllPost()
        {
            List<PostView> postView = new List<PostView>();
            postView = await
                (from a in _context.Posts
                 join b in _context.Employees on a.EmployeeId equals b.Id
                 where a.Status != 2
                 select new PostView()
                 {
                     Id = a.Id,
                     EmployeeId = a.EmployeeId,
                     EmployeeName = b.FullName,
                     Title = a.Title,
                     Content = a.Content,
                     CreatedDate = a.CreatedDate,
                     UpdatedDate = a.UpdatedDate,
                     Description = a.Description,
                     Status = a.Status,
                     Image = a.Image
                 }).ToListAsync();
            return postView;
        }

        public async Task<PostView> GetPostById(Guid id)
        {
            PostView postView = new PostView();
            postView = await
                (from a in _context.Posts
                 join b in _context.Employees on a.EmployeeId equals b.Id
                 where a.Id == id && a.Status != 2
                 select new PostView()
                 {
                     Id = a.Id,
                     EmployeeId = a.EmployeeId,
                     EmployeeName = b.FullName,
                     Title = a.Title,
                     Content = a.Content,
                     CreatedDate = a.CreatedDate,
                     UpdatedDate = a.UpdatedDate,
                     Description = a.Description,
                     Status = a.Status,
                     Image = a.Image
                 }).FirstAsync();
            return postView;
        }

        public async Task<List<PostView>> GetPostByTitle(string title)
        {
            List<PostView> postView = new List<PostView>();
            postView = await
                (from a in _context.Posts
                 join b in _context.Employees on a.EmployeeId equals b.Id
                 where a.Status != 2
                 select new PostView()
                 {
                     Id = a.Id,
                     EmployeeId = a.EmployeeId,
                     EmployeeName = b.FullName,
                     Title = a.Title,
                     Content = a.Content,
                     CreatedDate = a.CreatedDate,
                     UpdatedDate = a.UpdatedDate,
                     Description = a.Description,
                     Status = a.Status,
                     Image = a.Image
                 }).Where(p => p.Title.ToLower().Contains(title.ToLower())).ToListAsync();
            return postView;
        }

        public async Task<bool> UpdatePost(Guid id, UpdatePost post)
        {
            try
            {
                var n = _context.Posts.Find(id);
                if (n == null) return false;
                n.EmployeeId = post.EmployeeId;
                n.Title = post.Title;
                n.Content = post.Content;
                n.Description = post.Description;
                n.UpdatedDate = DateTime.Now;
                n.Image = post.Image;
                n.Status = 1;
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
