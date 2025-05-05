namespace App.Core.Result
{
    public class ServiceResult
    {
        public bool isSuccess { get; set; }
        public string Message { get; set; } = string.Empty;
        public object? Data { get; set; }

        public static ServiceResult SuccessResult(string message = "", object? data = null)
        {
            return new ServiceResult { isSuccess = true, Message = message, Data = data };
        }

        public static ServiceResult FailResult(string message)
        {
            return new ServiceResult { isSuccess = false, Message = message };
        }
    }
}
