using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DemoApp.Data
{
   public class UserAlbum
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Rowid { get; set; }
        public int id { get; set; }
        public int userId { get; set; }
        public string title { get; set; }
    }
}
