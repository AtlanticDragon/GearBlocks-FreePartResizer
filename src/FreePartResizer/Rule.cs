using UnityEngine;

using static Il2CppSmashHammer.GearBlocks.Construction.PartDescriptorProcedural;

namespace FreePartResizer;

public sealed record Rule
{

    public IReadOnlyList<string> NameContains { get; init; } = new List<string>();
    public IReadOnlyList<string> NameExcludes { get; init; } = new List<string>();

    public Vector3? UnitMaxDims { get; init; }
    public Vector3? UnitMinDims { get; init; }
    public Vector3? UnitStepDims { get; init; }

    public DefaultDims? DefaultDims { get; init; }
    public Vector3? CurrentDims { get; init; }

}
