﻿using Lunson.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace Lunson.Domain.Mapping
{
    public class FeedTypeMap : EntityTypeConfiguration<FeedType>
    {
        public FeedTypeMap()
        {
            this.ToTable("FeedTypes");
            HasOptional(t => t.Annex).WithMany().HasForeignKey(t => t.SwfID);
        }
    }
}
