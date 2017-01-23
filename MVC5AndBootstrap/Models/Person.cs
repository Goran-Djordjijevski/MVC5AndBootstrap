using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC5AndBootstrap.Models
{
    public class Person
    {
        public Person()
        {

        }

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        [UIHint("BooleanButtonLabel")]
        public bool LikesMusic { get; set; }

        public IList<string> Skills { get; set; }
    }
}