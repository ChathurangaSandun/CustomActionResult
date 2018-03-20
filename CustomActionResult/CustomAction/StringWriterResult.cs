using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomActionResult.CustomAction
{
    public class StringWriterResult : IActionResult
    {
        private byte[] _stringAsByteArray;
        public StringWriterResult(string stringToWrite)
        {
            _stringAsByteArray = Encoding.ASCII.GetBytes(stringToWrite);
        }

        //depcrited ExecuteResult method
        //dot net core 2 use async method
        public Task ExecuteResultAsync(ActionContext context)
        {
            context.HttpContext.Response.StatusCode = 200;
            return context.HttpContext.Response.Body.WriteAsync(_stringAsByteArray, 0, _stringAsByteArray.Length);
        }
    }
}
