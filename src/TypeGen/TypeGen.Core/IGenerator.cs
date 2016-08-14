using System;
using System.Reflection;

namespace TypeGen.Core
{
    /// <summary>
    /// Interface for a TypeScript generator class
    /// </summary>
    public interface IGenerator
    {
        /// <summary>
        /// Generates TypeScript files for C# files in an assembly
        /// </summary>
        /// <param name="assembly"></param>
        void Generate(Assembly assembly);

        /// <summary>
        /// Generate TypeScript files for a given type
        /// </summary>
        /// <param name="type"></param>
        void Generate(Type type);
    }
}