using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Episode
    {
        [Key]
        public int EpisodeID { get; set; }
        public string EpisodeTitle { get; set; }
        public string EpisodeLink1 { get; set; }
        public string EpisodeLink2 { get; set; }
        public string EpisodeLink3 { get; set; }
        public string AnimeName { get; set; }
        public int AnimeID { get; set; }
    }
}
