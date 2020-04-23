using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ComplexTypeIssue.Models
{
    public class TestContext:DbContext
    {
        public TestContext():base("name=TestContext")
        {
            
        }

        public DbSet<TestModel> TestModels { get; set; }
    }
}