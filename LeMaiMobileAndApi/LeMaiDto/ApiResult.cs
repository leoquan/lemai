using System;
using System.Collections.Generic;

namespace LeMaiDto;

public class ApiResult
{
    public bool IsOk { get; set; }
    public ApiStatus Status { get; set; }
    public string TraceId { get; set; }

    public string DebugException { get; set; }

    /// <summary>
    /// Chổ này phải để chữ in thường để telerik phát sinh error handler
    /// </summary>
    public List<ApiError> Errors { get; set; }

    public ApiResult()
    {
        IsOk = true;
        Status = ApiStatus.Normal;
    }

    public ApiResult(in string error, in string traceId = "", in ApiStatus status = ApiStatus.UnhandleError)
    {
        IsOk = false;
        Status = status;
        Errors = new List<ApiError> { new ApiError("", error) };
        TraceId = traceId;
    }
    public ApiResult(in List<ApiError> listFieldError = null, in string traceId = "", in ApiStatus status = ApiStatus.UnhandleError)
    {
        IsOk = false;
        Status = status;
        Errors = listFieldError;
        TraceId = traceId;
    }
}

public class ApiResult<T> : ApiResult
{
    public bool IsOk { get; set; }
    public ApiStatus Status { get; set; }

    public T Data { get; set; }

    public ApiResult()
    {
        IsOk = true;
        Status = 0;
    }

    public ApiResult(T data)
    {
        IsOk = true;
        Status = 0;
        Data = data;
    }
}

public class ApiError
{
    public string Key { get; set; }
    public string Error { get; set; }

    public ApiError()
    {

    }

    public ApiError(string field, string error)
    {
        Key = field;
        Error = error;
    }

    public override string ToString()
    {
#if DEBUG
        return $"{Key} : {Error}";
#endif
        return $"{Error}";
    }
}
