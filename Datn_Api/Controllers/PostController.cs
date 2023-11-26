using Datn_Api.IServices;
using Datn_Api.Services;
using Datn_Shared.Models;
using Datn_Shared.ViewModels.CategoryViewModels;
using Datn_Shared.ViewModels.PostViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace Datn_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostService _postService;

        public PostController(IPostService postService)
        {
            _postService = postService;
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAllPost()
        {
            var posts = await _postService.GetAllPost();
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                PreserveReferencesHandling = PreserveReferencesHandling.Objects
            };
            string json = JsonConvert.SerializeObject(posts, settings);
            JToken parsedJson = JToken.Parse(json);
            string formattedJson = parsedJson.ToString(Newtonsoft.Json.Formatting.Indented);
            return Ok(formattedJson);
        }

        [HttpGet]
        [Route("GetById/{id:Guid}")]
        public async Task<IActionResult> GetPostById([FromRoute] Guid id)
        {
            var post = await _postService.GetPostById(id);
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                PreserveReferencesHandling = PreserveReferencesHandling.Objects
            };
            string json = JsonConvert.SerializeObject(post, settings);
            JToken parsedJson = JToken.Parse(json);
            string formattedJson = parsedJson.ToString(Newtonsoft.Json.Formatting.Indented);
            return Ok(formattedJson);
        }

        [HttpGet]
        [Route("GetByName/{name}")]
        public async Task<IActionResult> GetPostByTitle([FromRoute] string name)
        {
            var posts = await _postService.GetPostByTitle(name);
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                PreserveReferencesHandling = PreserveReferencesHandling.Objects
            };
            string json = JsonConvert.SerializeObject(posts, settings);
            JToken parsedJson = JToken.Parse(json);
            string formattedJson = parsedJson.ToString(Newtonsoft.Json.Formatting.Indented);
            return Ok(formattedJson);
        }

        [HttpPost]
        [Route("Create")]
        public async Task<ActionResult<CreatePost>> CreateCategory(CreatePost post)
        {
            await _postService.CreatePost(post);
            return Ok(post);
        }

        [HttpPut]
        [Route("Update/{id:Guid}")]
        public async Task<ActionResult<UpdatePost>> UpdateCategory([FromRoute] Guid id, [FromBody] UpdatePost post)
        {
            await _postService.UpdatePost(id, post);
            return Ok(post);
        }

        [HttpDelete]
        [Route("Delete/{id:Guid}")]
        public async Task<ActionResult<Post>> DeleteCategory([FromRoute] Guid id)
        {
            await _postService.DeletePost(id);
            return Ok();
        }
    }
}
