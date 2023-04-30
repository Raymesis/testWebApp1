using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Model
{
    public class PostModel
    {
    public string name;
    public double title;

    public PostModel(string name, double title)
    {
            this.name = name;
            this.title = title;
    }
       
    }
}