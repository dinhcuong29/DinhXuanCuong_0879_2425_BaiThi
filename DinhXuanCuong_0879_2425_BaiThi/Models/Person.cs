using System.ComponentModel.DataAnnotations;

namespace DinhXuanCuong_0879_2425_BaiThi.Models
{
    public class Person 
    {
        [Key]
        public string PersonID { get; set; }
        public string FullName{ get; set; }
        public string Address { get; set; }
    }
}