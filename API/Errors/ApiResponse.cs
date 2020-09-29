namespace API.Errors
{
    public class ApiResponse
    {
        public ApiResponse(int statusCode, string message = null)
        {
            StatusCode = statusCode;
            Message = message ?? GetDefaulfMessageForStatusCode(statusCode);
        }

        private string GetDefaulfMessageForStatusCode(int statusCode)
        {
            return statusCode switch
            {
                400 => "A dab request, you have made",
                401 => "Autorized, you are not",
                404 => "Resource found, it was not",
                500 => "Errors are the path to the dark side. Error lead to anger. Anger leads to hate. Hate leads to career change",
                _ => null
            };
        }

        public int StatusCode { get; set; }
        public string Message { get; set; }
    }
}