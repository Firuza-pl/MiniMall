using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Yasamall.Models;

namespace Yasamall.ViewModel
{
    public class ProColors
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ad mütləq doldurulmalıdır."), StringLength(100, ErrorMessage ="Adın uzunluğu maksimum 100 simvol olmalıdır.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Haqqında qismi mütləq doldurulmalıdır.")]
        public string Info { get; set; }

        [Required(ErrorMessage ="Qiymət mütləq doldurulmalıdır.")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Hansı brandə aid olduğu mütləq doldurulmalıdır.")]
        public int BrandsId { get; set; }

        public  IEnumerable<int> ColorsId { get; set; }

        public IEnumerable<int> SizesId { get; set; }

        public virtual ICollection<ProductPhoto> Photos { get; set; }

        [NotMapped]
        public ICollection<IFormFile> AllPhotos { get; set; }
    }
}
