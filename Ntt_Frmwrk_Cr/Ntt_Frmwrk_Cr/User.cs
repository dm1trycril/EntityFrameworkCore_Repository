using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ntt_Frmwrk_Cr
{
    [Table("People")]
    public class User
    {
        public int Id { get; set; }
        //Аннотация
        [Required]
        public string Name { get; set; }
        public int Age { get; set; }
        //public string Position { get; set; }  
    }
}
