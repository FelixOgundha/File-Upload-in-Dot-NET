using System.ComponentModel.DataAnnotations;

namespace File_Upload_in_Dot_NET.Models
{
    public class SingleFileModel 
    {
        [Required(ErrorMessage = "Please enter file name")]
        public string FileName { get; set; } = String.Empty;

        [Required(ErrorMessage = "Please select file")]
        public IFormFile File { get; set; } 
    }
}
