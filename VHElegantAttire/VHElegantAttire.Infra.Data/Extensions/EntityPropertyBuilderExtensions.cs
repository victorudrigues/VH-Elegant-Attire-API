using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace VHElegantAttire.Infra.Data.Extensions
{
    public static class EntityPropertyBuilderExtensions
    {
        public static PropertyBuilder<TProperty> HasForeignKeyString<TProperty>(this PropertyBuilder<TProperty> property)
        {
            return property.HasMaxLength(36);
        }

        public static PropertyBuilder<TProperty> HasMaxLength255<TProperty>(this PropertyBuilder<TProperty> property)
        {
            return property.HasMaxLength(255);
        }

        public static PropertyBuilder<TProperty> HasMaxLength64<TProperty>(this PropertyBuilder<TProperty> property)
        {
            return property.HasMaxLength(64);
        }

        public static PropertyBuilder<TProperty> HasMaxLength16<TProperty>(this PropertyBuilder<TProperty> property)
        {
            return property.HasMaxLength(16);
        }
    }
}
