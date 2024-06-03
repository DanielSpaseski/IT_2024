using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Album_Modified.Models
{
    public class StoreAlbumModel
    {
        public int storeId { get; set; }
        public int albumId { get; set; }
        public List<Album> albums { get; set;}
        public StoreAlbumModel() { 
            albums = new List<Album>();
        }
    }
}