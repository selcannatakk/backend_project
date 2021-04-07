using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    // data + result /message
    public interface IDataResult<T>:IResult
    {
        T Data { get; }
    }
}
