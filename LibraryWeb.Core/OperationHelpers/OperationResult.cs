using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryWeb.Core.OperationHelpers
{
    public class OperationResult
    {
        OperationResultType OperationResultType { get; set; }
        public string ErrorMessage { get; set; }
    }
}
