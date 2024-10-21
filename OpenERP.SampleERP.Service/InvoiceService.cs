using AbrPlus.Integration.OpenERP.Api.DataContracts;
using AbrPlus.Integration.OpenERP.Enums;
using AbrPlus.Integration.OpenERP.SampleERP.Service.Helpers;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using Noyan.Repository2;
using Noyan.Repository2.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AbrPlus.Integration.OpenERP.SampleERP.Service
{
    public class InvoiceService : IInvoiceService
    {
        private readonly ITrackingRepository<Sefactor> _trackingRepository;
        private readonly NoyanDbContext _context;
        private readonly ILogger<InvoiceService> _logger;

        public InvoiceService(ITrackingRepository<Sefactor> trackingRepository,
                              NoyanDbContext context,
                              ILogger<InvoiceService> logger)
        {
            _trackingRepository = trackingRepository;
            _context = context;
            _logger = logger;
        }

        public string[] GetAllIds()
        {
            throw new NotImplementedException();
        }

        public InvoiceBundle GetBundle(string key)
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

        public bool Save(InvoiceBundle item)
        {
            throw new NotImplementedException();
        }

        public void SetTrackingStatus(bool enabled)
        {
            if(enabled)
                _trackingRepository.EnableTableTracking();
            else
                _trackingRepository.DisableTableTracking();
        }

        public bool SyncWithCrmObjectTypeCode()
        {
            return false;
        }

        public bool Validate(InvoiceBundle item)
        {
            throw new NotImplementedException();
        }
    }
}
