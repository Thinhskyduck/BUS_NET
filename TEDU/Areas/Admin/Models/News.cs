using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TEDU.Areas.Admin.Models
{
    public class News
    {
        public int NewsId { get; set; } // Mã tin tức
        public int STT { get; set; }
        public string Img { get; set; }
        public string Title { get; set; } // Tiêu đề bài viết
        public string Meta { get; set; }
        public string Content { get; set; } // Nội dung bài viết
        public Boolean hide { get; set; }
        public DateTime PublishedDate { get; set; } // Ngày đăng
    }

}