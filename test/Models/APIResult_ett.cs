﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace test.Models
{
    public enum EnumErrCode
    {
        Error = -1,
        Fail = 0,
        Success = 1,
        Empty = 2,
        NotExistent = 3,
        InputEmpty = 4
    }

    public class APIResult_ett<T>
    {
        public EnumErrCode ErrCode { get; set; }
        public string ErrDesc { get; set; }
        public T Data { get; set; }
    }
}