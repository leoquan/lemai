using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace LeMai.Efs
{
    public partial class LeMaiDbContext
    {
        public void TrackRowVersion<T>(in T entity, in string rowVersion) where T : class
        {
            Entry<T>(entity).Property("RowVersion").OriginalValue = Convert.FromBase64String(rowVersion);
        }
        public void TrackRowVersion<T>(in T entity, in byte[] rowVersion) where T : class
        {
            Entry<T>(entity).Property("RowVersion").OriginalValue = rowVersion;
        }
    }
}
