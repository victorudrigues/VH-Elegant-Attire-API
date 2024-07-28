using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VHElegantAttire.Infra.Data.Constants;

namespace VHElegantAttire.Infra.Data.Auditing
{
    public static class EntityTypeBuilderExtensions
    {
        public static EntityTypeBuilder<T> AddAuditProperties<T>(this EntityTypeBuilder<T> modelBuilder)
            where T : Entity
        {
            modelBuilder.Property<string>(Columns.CREATED_USER_ID).HasMaxLength(36);
            modelBuilder.Property<DateTimeOffset>(Columns.CREATED_DATE);

            modelBuilder.Property<string>(Columns.LAST_UPDATED_USER_ID).HasMaxLength(36);
            modelBuilder.Property<DateTimeOffset?>(Columns.LAST_UPDATED_DATE).IsRequired(false);

            return modelBuilder;
        }

        public static EntityTypeBuilder<T> AddDeleteAuditProperties<T>(this EntityTypeBuilder<T> modelBuilder)
            where T : Entity
        {
            modelBuilder.Property<string>(Columns.DELETED_USER_ID).HasMaxLength(36);
            modelBuilder.Property<DateTimeOffset?>(Columns.DELETED_DATE).IsRequired(false);

            return modelBuilder;
        }

        public static EntityTypeBuilder<T> AddSoftDeleteProperties<T>(this EntityTypeBuilder<T> modelBuilder)
            where T : Entity
        {
            modelBuilder.Property<bool>(Columns.IS_DELETED).HasDefaultValue(false);

            return modelBuilder;
        }
    }
}
