using Microsoft.AspNetCore.Mvc;

namespace BestPractise.API.Model;

public class ServiceResult
{
    public int Status { get; set; }
    public ProblemDetails? ProblemDetails { get; set; }
}
public class ServiceResult<T> : ServiceResult
{
    public T? Data { get; set; }

    public static ServiceResult<T> Success(T data, int status = 200)
    {
        return new ServiceResult<T>
        {
            Data = data,
            Status = status
        };
    }

    public static ServiceResult<T> Failure(string message, int status = 400)
    {
        return new ServiceResult<T>
        {
            Status = status,
            ProblemDetails = new ProblemDetails
            {
                Detail = message,
                Status = status
            }
        };
    }
}