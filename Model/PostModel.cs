using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Model
{
    public class PostModel
    {
    public string name;
    public string title;

    public PostModel(string name, string title)
    {
            this.name = name;
            this.title = title;
    }
       
    }
}