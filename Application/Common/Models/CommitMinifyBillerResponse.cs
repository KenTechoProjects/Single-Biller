﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Common.Models
{
   public class CommitMinifyBillerResponse : ResponseModel
    {
        public string RequestId { get; set; }
        public string TransactionReference { get; set; }
    }
}
