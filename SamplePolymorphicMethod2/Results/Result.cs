using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Results
{
    class Result : IResult
    {
        public List<string> Strings { get; set; }
        public Result()
        {
            Strings = new List<string>();
        }
    }
}
