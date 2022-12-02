namespace File_Upload_in_Dot_NET.Models
{
    public class ResponseModel
    {
        public string Message { get; set; } = string.Empty;
        public bool IsSuccess { get; set; } = false;
        public bool IsResponse { get; set; } = false;
    }
}
