using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing.Imaging;
using System.Linq;
using System.Web;

namespace ComplexTypeIssue.Models
{
    [ComplexType]
    public class LocalizedString
    {
        public  string Fr { get; set; }
        public  string En { get; set; }
        public  string De { get; set; }
        public  string Nl { get; set; }
    }
}