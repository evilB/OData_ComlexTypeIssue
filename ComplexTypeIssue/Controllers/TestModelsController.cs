using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using ComplexTypeIssue.Models;
using Microsoft.AspNet.OData;

namespace ComplexTypeIssue.Controllers
{
    public class TestModelsController : ODataController
    {
        TestContext db = new TestContext();
        private bool ProductExists(int key)
        {
            return db.TestModels.Any(p => p.Id == key);
        }

        [EnableQuery]
        public IQueryable<TestModel> Get()
        {
            return db.TestModels;
        }
        [EnableQuery]
        public SingleResult<TestModel> Get([FromODataUri] int key)
        {
            IQueryable<TestModel> result = db.TestModels.Where(p => p.Id == key);
            return SingleResult.Create(result);
        }

        public async Task<IHttpActionResult> Post(TestModel tm)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            db.TestModels.Add(tm);
            await db.SaveChangesAsync();
            return Created(tm);
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }


    }
}
