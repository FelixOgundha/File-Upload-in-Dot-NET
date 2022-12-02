using System.ComponentModel.DataAnnotations;

namespace File_Upload_in_Dot_NET.Models
{
    public class MultipleFilesModel 
    {
        [Required(ErrorMessage = "Please select files")]
        public List<IFormFile> Files { get; set; }
    }
}
