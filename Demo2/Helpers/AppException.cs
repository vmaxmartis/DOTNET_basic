namespace Demo2.Helpers;

using System.Globalization;
//khai báo các phupowng thức để dùng chung hỗ trợ  các  lớp khác
// custom exception class for throwing application specific exceptions (e.g. for validation) 
// that can be caught and handled within the application
public class AppException : Exception
{
    public AppException() : base() { }

    public AppException(string message) : base(message) { }

    public AppException(string message, params object[] args)
        : base(String.Format(CultureInfo.CurrentCulture, message, args))
    {
    }
}