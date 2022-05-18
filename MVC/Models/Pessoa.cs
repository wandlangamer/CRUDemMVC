using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class Pessoa
    {
        [Key]
        public int Id { set; get; }
        public String Nome { set; get; }
        public String Email { set; get; }
    }
}