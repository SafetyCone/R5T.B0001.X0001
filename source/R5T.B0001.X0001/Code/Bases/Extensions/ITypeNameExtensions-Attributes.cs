using System;

using R5T.B0001;
using R5T.B0001.X0001;


namespace System
{
    public static partial class ITypeNameExtensions
    {
        public static string ExtensionMethodBaseMarkerAttribute(this ITypeName _)
        {
            return TypeNames.ExtensionMethodBaseMarkerAttribute;
        }

        public static string ServiceDefinitionMarkerAttribute(this ITypeName _)
        {
            return TypeNames.ServiceDefinitionMarkerAttribute;
        }

        public static string ServiceImplementationConstructorMarkerAttribute(this ITypeName _)
        {
            return TypeNames.ServiceImplementationConstructorMarkerAttribute;
        }

        public static string ServiceImplementationMarkerAttribute(this ITypeName _)
        {
            return TypeNames.ServiceImplementationMarkerAttribute;
        }
    }
}
