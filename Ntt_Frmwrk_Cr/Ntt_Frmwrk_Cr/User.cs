using System.ComponentModel.DataAnnotations;

namespace Ntt_Frmwrk_Cr
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
