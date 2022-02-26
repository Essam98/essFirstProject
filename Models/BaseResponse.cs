namespace dotnetWithMosh.Models
{
    public class BaseResponse<T>
    {
        public T Data { get; set; }
        public int ErrorCode { get; set; } = 0;
        public string Message { get; set; } = "operation accomplished successfully";
        public bool Success { get; set; } = true;
    }
}