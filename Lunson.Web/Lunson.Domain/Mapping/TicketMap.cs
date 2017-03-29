﻿using Lunson.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace Lunson.Domain.Mapping
{
    public class TicketMap : EntityTypeConfiguration<Ticket>
    {
        public TicketMap()
        {
            this.ToTable("Tickets");
            HasOptional(ur => ur.Annex).WithMany().HasForeignKey(u => u.MainImgID);
        }
    }
}