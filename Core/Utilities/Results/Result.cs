using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public Result(bool success, string message):this(success)
        {
            Message = message;
        }
        public Result(bool success)        //override = aşıra yükleme
        {
            Success = success;
        }

        //public bool Success => throw new NotImplementedException();   // sadece get return oldugu için 

        //public string Messqage { set => throw new NotImplementedException(); }
        public bool Success { get; }
        public string Message { get; }
    }
}
