using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordPressPCL;

namespace WordpressPostRevisionsAnalyzer
{
    internal class RestClient
    {
        internal  static void UseRestClient()
        {
            // Initialize
            var client = new WordPressClient("https://www.superinformati.com/wp-json/");

            // Posts
            //var posts = client.Posts.GetAll();
            //var postbyid =  client.Posts.GetById(id);

            //// Comments
            //var comments =  client.Comments.GetAll();
            //var commentbyid =  client.Comments.GetById(id);
            //var commentsbypost =  client.Comments.GetCommentsForPost(postid, true, false);

            //// Users
            //// JWT authentication
            //var client = new WordPressClient(ApiCredentials.WordPressUri);
            //client.AuthMethod = AuthMethod.JWT;
            //await client.RequestJWToken(ApiCredentials.Username, ApiCredentials.Password);

            //// check if authentication has been successful
            //var isValidToken = await client.IsValidJWToken();

            //// now you can send requests that require authentication
            //var response = client.Posts.Delete(postid);
        }
    }
}
