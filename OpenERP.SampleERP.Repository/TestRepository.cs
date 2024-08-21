using AbrPlus.Integration.OpenERP.SampleERP.Models;
using Microsoft.Extensions.Logging;
using SeptaKit.Repository.EFCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbrPlus.Integration.OpenERP.SampleERP.Repository
{
    public class TestRepository : BaseSampleErpRepository<Customer>, ICustomerRepository
    {
        public TestRepository(ISampleErpDbContext dbContext, ILoggerFactory loggerFactory) : base(dbContext, loggerFactory)
        {
        }
    }
}
