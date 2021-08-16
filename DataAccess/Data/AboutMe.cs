using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class AboutMe
    {
        public int Id { get; set; }
        public string Descripton { get; set; }
        public string Skills { get; set; }
        public string EmailUrl { get; set; }
        public string LinkedInUrl { get; set; }
        public string PersonalUrl { get; set; }
        public string FacebookUrl { get; set; }
        public string InstagramUrl { get; set; }
        public string GithubUrl { get; set; }
        public string AboutImageUrl { get; set; }
    }
}
