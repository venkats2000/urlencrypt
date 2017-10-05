using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace FEfinal.Models
{
    public class FileEnc
    {
        [Key]
        public int ID { get; set; }
        [Display(Name = "File URL")]
        public String FileLocation { get; set; }
        [Display(Name = "Expiry date")]
        [DataType(DataType.Date)]
        public DateTime ExpiryDate { get; set; }
        public string FileType { get; set; }
        public string Enc_String { get; set; }
    }
}

 