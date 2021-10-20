using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEntityFramework.Models
{
    //エンティティクラス
    public class Book
    {
        //主キー(Idとすると主キー)
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [MaxLength(16)]
        public string Publisher { get; set; }
        public int? PublishedYear { get; set; }  //?をつけることでNULL許容型になる
        public virtual Author Author { get; set; }
    }
}
