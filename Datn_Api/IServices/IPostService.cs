using Datn_Shared.Models;
using Datn_Shared.ViewModels.PostViewModels;

namespace Datn_Api.IServices
{
    public interface IPostService
    {
        public Task<bool> CreatePost(CreatePost post);
        public Task<bool> UpdatePost(Guid id, UpdatePost post);
        public Task<bool> DeletePost(Guid id);
        public Task<Post> GetPostById(Guid id);
        public Task<List<Post>> GetPostByTitle(string title);
        public Task<List<Post>> GetAllPost();
    }
}