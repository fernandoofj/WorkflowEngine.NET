﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WF.Sample.Business.Models
{
    public class WorkflowInbox
    {
        public string Id{ get; set; }
        public Guid ProcessId;
        public string IdentityId;
    }
}
