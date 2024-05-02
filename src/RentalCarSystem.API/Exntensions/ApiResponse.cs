namespace RentalCarSystem.API.Exntensions;

public class ApiResponse<T>
{
    public List<string>? Messages { get; set; }
    public T? Data { get; set; }

    public ApiResponse() => Messages = [];

    public static ApiResponse<T> CreateResponse(T data) => new()
    {
        Data = data
    };

    public static ApiResponse<T> CreateResponse(List<string> messages) => new()
    {
        Messages = messages
    };

    public static ApiResponse<T> CreateResponse(Exception ex) => new()
    {
        Messages = [ex.Message]
    };
}