using System;
using System.Collections.Generic;

namespace TypeGen.Core.TypeModel.Csharp;

internal class CsClass : CsType
{
    public CsClass(string name) : base(name)
    {
    }
    
    public string FullName { get; }
    public IReadOnlyCollection<CsType> GenericTypes { get; }
    public IReadOnlyCollection<CsProperty> Fields { get; }
    public IReadOnlyCollection<CsField> Properties { get; }
    public IReadOnlyCollection<Attribute> Attributes { get; }
}