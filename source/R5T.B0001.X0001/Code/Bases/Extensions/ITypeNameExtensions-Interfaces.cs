using System;

using R5T.B0001;
using R5T.B0001.X0001;


namespace System
{
    public static partial class ITypeNameExtensions
    {
        public static string IServiceAction(this ITypeName _)
        {
            return TypeNames.IServiceAction;
        }

        public static string IServiceDefinition(this ITypeName _)
        {
            return TypeNames.IServiceDefinition;
        }

        public static string IServiceImplementation(this ITypeName _)
        {
            return TypeNames.IServiceImplementation;
        }
    }
}
