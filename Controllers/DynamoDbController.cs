using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DynamoDb.Libs.DynamoDb;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace DynamoDb.Controllers
{
    [Produces("application/json")]
    [Route("api/DynamoDb")]
    public class DynamoDbController : Controller
    {

        private readonly IDynamoDbExamples _dynamoDbExample;

        public DynamoDbController(IDynamoDbExamples dynamoDbExamples)
        {
            _dynamoDbExample = dynamoDbExamples;
        }
       
        [Route("createtable")]
        public IActionResult CreateDynamoDbTable()
        {
            _dynamoDbExample.CreateDynamoDbTable();

            return Ok();
        }
    }
}