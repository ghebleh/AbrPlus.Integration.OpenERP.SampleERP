using AbrPlus.Integration.OpenERP.Api.DataContracts;
using AbrPlus.Integration.OpenERP.Enums;
using Noyan.Repository2;
using System.Collections.Generic;
using System;
using System.Linq;

namespace AbrPlus.Integration.OpenERP.SampleERP.Service.Helpers;

public static class ChangeInfoHelpers
{
    public static ChangeInfo ConvertChangesToChangeInfo(List<ChangeTrackingRecord> localChanges)
    {
        if (localChanges is null || localChanges.Count == 0)
            return new ChangeInfo();

        var result = new ChangeInfo
        {
            LastTrackedVersion = localChanges.Max(c => c.ChangeVersion).ToString(),
        };
        var changeDetails = new List<ChangeDetail>();
        foreach (var change in localChanges)
        {
            changeDetails.Add(new ChangeDetail
            {
                Action = change.ChangeOperation switch
                {
                    "I" => ActionType.Insert,
                    "U" => ActionType.Update,
                    "D" => ActionType.Delete,
                    _ => throw new NotImplementedException()
                },
                Id = change.IdClt
            });
        }

        result.Changes = changeDetails.ToArray();
        return result;
    }
}
