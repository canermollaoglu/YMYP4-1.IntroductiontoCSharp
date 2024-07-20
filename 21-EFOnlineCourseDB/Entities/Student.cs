using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_EFOnlineCourseDB.Entities
{
    //Data Annotations:
    //Veri modellerini doğrulama, yapılandırma, görüntüleme ve ilişkileri tanımlamak için güçlü, esnek bir yöntem sağlar. Bu, geliştiricilerin daha güvenilir, tutarlı ve kullanıcı dostu geliştirmeler yapmalarına yardımcı olur.
    //Required, StringLength, Key, NotMapped, Range .. gibi Attritube'lar kullanılarak uygulanır.
    public class Student : BaseEntity
    {
        [Required(ErrorMessage = "Ad alanı boş geçilemez.")]
        [StringLength(80)]
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public DateOnly BirthDate { get; set; }

        [StringLength(11)]
        public string? TCNumber { get; set; }
        public string? FullName
        {
            get
            {
                return $"{Name} {Surname}";
            }
        }

        public string denemename => Name + " " + Surname;
        public ICollection<ExamResult>? ExamResults { get; set; }
        public ICollection<Registration>? Registrations { get; set; }
    }
}
