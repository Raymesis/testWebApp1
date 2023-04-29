using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Model;
using WebApplication1.Database;
using System.Data;
using System.Data.SqlClient;
namespace WebApplication1.Repository
{
    public class PostDaoImp : IPostDao
    {
        public void addPost(PostModel post)
        {
            throw new NotImplementedException();
        }

        public List<PostModel> getPosts()
        {
            List<PostModel> posts = new List<PostModel>();

            SqlCommand command;
            SqlDataReader dataReader;
            String sql = "";

            sql = "select name,title from post";

            Db.Instance.cnn.Open();

            command = new SqlCommand(sql, Db.Instance.cnn);

            dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                posts.Add(new PostModel(dataReader.GetString(0), dataReader.GetString(1)));
            }
            Db.Instance.cnn.Close();
            return posts;
        }
    }
}