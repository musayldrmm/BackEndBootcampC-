using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using YemekTarifiWebApi.Model;

namespace YemekTarifiWebApi.Dto
{
    [Index(nameof(UserDto.Email), IsUnique = true)]

    public class UserDto
    {

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
        public DateTime BirthDate { get; set; }

        public string Gender { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
        [DefaultValue(false)]
        public bool IsDeleted { get; set; }
    }
}
