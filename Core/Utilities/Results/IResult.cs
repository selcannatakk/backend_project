using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    // temel voidler için baslangıc işlem sonucları
    // get = oku set = yaz
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }
    }
}
