using AbrPlus.Integration.OpenERP.Api.DataContracts;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using Noyan.Repository2.Models;
using Noyan.Repository2;
using AbrPlus.Integration.OpenERP.SampleERP.Service.Helpers;

namespace AbrPlus.Integration.OpenERP.SampleERP.Service
{
    public class CustomerService : ICustomerService
    {
        private readonly ITrackingRepository<Vwsehesab> _trackingRepository;
        private readonly NoyanDbContext _context;
        private readonly ILogger<CustomerService> _logger;

        public CustomerService(ITrackingRepository<Vwsehesab> trackingRepository,
                               NoyanDbContext context,
                               ILogger<CustomerService> logger)
        {
            _trackingRepository = trackingRepository;
            _context = context;
            _logger = logger;
        }
        public IdentityBundle GetBundle(string key)
        {
            throw new NotImplementedException();
        }
        public IdentityBundle GetBundleByCode(string key)
        {
            throw new NotImplementedException();
        }
        public ChangeInfo GetChanges(string lastTrackedVersionStamp)
        {
            //get changes from table
            var localChanges = _trackingRepository.GetTrackingChanges(long.Parse(lastTrackedVersionStamp));

            //cross check changes with view
            //_context.Vwsewsgetinvoices.Where(invoice => localChanges.Select(c => c.IdClt).ToList().Contains(invoice.)

            return ChangeInfoHelpers.ConvertChangesToChangeInfo(localChanges);
        }
        public bool Save(IdentityBundle item)
        {
            throw new NotImplementedException();
        }
        public bool Validate(IdentityBundle item)
        {
            throw new NotImplementedException();
        }
        public void SetTrackingStatus(bool enabled)
        {
            if (enabled)
                _trackingRepository.EnableTableTracking();
            else
                _trackingRepository.DisableTableTracking();
        }
        public string[] GetAllIds()
        {
            return new string[] { "A", "B" };
        }
        public decimal GetCustomerBalance(string customerCode)
        {
            throw new NotImplementedException();
        }
        public List<IdentityBalance> GetAllIdentityBalance(IdentityBalanceParams identityBalanceParams)
        {
            throw new NotImplementedException();
        }
    }
}
