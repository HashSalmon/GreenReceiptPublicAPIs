using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Domain.Objects;
using GreenReceiptRest.Models;

namespace GreenReceiptRest.Controllers
{
    /// <summary>
    /// This receipt controller interface providers an developer
    /// of retrieving all receipt data, retrieving a receipt by id,
    /// and creating a receipt, etc.
    /// </summary>
    public class ReceiptController : ApiController
    {
        
        // GET: api/Receipt
        /// <summary>
        /// Retrieve all receipts
        /// </summary>
        /// <returns>A list of receipts</returns>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Receipt/5
        /// <summary>
        /// Get a receipt by id
        /// </summary>
        /// <param name="id">The receipt Id</param>
        /// <returns>Return the specific receipt</returns>
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Receipt
        /// <summary>
        /// Create a new receipt
        /// </summary>
        /// <param name="model">The receipt model</param>
        public void Post(ReceiptBingingModel model)
        {

        }

        // PUT: api/Receipt/5
        /// <summary>
        /// Update a receipt by its Id
        /// </summary>
        /// <param name="id">The receipt Id</param>
        /// <param name="value">The new value to be updated</param>
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Receipt/5
        /// <summary>
        /// Delete a receipt by its Id
        /// </summary>
        /// <param name="id">The receipt Id</param>
        public void Delete(int id)
        {
        }
    }
}
