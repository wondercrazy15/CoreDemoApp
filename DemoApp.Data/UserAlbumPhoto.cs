using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DemoApp.Data
{
    public class UserAlbumPhoto
    {
       [Key]
       [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Rowid { get; set; }
        public int id { get; set; }
       public int albumId { get; set; }
       public string title { get; set; }
       public string url { get; set; }
       public string thumbnailUrl { get; set; }
    }
}
