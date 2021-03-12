namespace CloudBar.Common.Models
{
    public class Error
    {
        public string Code { get; set; }
        public string Message { get; set; }
        public string Language { get; set; }

        public Error GetCopy()
        {
            return new Error { Code = Code, Language = Language, Message = Message };
        }
    }
}
