﻿using CoreForIdentity.Model.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreForIdentity.Model.Concrete.TypeConfiguration.Abstract
{
    public abstract class BaseMap<T> : IEntityTypeConfiguration<T> where T : BaseModel
    {
        // Bu sınıf diğer sınıflara kalıtım vereceğinden dolayı CONFIGURE metodu diğer sınıflarda ihtiyaca göre kullanılabilsin diye virtual olarak tanımlandı
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasKey(a => a.ID);
            builder.Property(a => a.CreatedDate).IsRequired(true);
            builder.Property(a => a.DeletedDate).IsRequired(false);
            builder.Property(a => a.UpdatedDate).IsRequired(false);
        }
    }
}
