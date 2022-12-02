using File_Upload_in_Dot_NET.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace File_Upload_in_Dot_NET.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UploadsController : ControllerBase
    {
        [HttpPost]
        public IActionResult Upload(SingleFileModel model)
        {

            string path = Path.Combine(Directory.GetCurrentDirectory(), "ImageFiles/SingleFiles");

            //create folder if not exist
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

            //get file extension
            FileInfo fileInfo = new FileInfo(model.File.FileName);
            string fileName = model.FileName + fileInfo.Extension;

            string fileNameWithPath = Path.Combine(path, fileName);

            using (var stream = new FileStream(fileNameWithPath, FileMode.Create))
            {
                model.File.CopyTo(stream);
            }
             
            

            return Ok("File Uploaded Successfully");
        }
    }
}
