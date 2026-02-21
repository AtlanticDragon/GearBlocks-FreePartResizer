using Il2CppInterop.Runtime;

using Il2CppSmashHammer.GearBlocks.Construction;

using MelonLoader;

using UnityEngine;
using static Il2CppSmashHammer.GearBlocks.Construction.PartDescriptorProcedural;

namespace FreePartResizer;

public class Mod : MelonMod
{

    private static readonly IReadOnlyList<Rule> _rules = new List<Rule>
    {
        new()
        {
            NameContains = new[] { "Resizable" },
            NameExcludes = new[] { "SliderRail","Checkpoint" },
            UnitStepDims = new Vector3(0.1f, 0.1f, 0.1f),
        },
        new()
        {
            NameContains = new[] { "Resizable", "Block" },
            CurrentDims  = new Vector3(4f, 4f, 4f),
            DefaultDims  = PartDescriptorProcedural.DefaultDims.Min,
            UnitMaxDims  = new Vector3(500f, 500f, 500f),
            UnitMinDims  = new Vector3(0.1f, 0.1f, 0.1f),
        },
        new()
        {
            NameContains = new[] { "Resizable", "Beam" },
            NameExcludes = new[] { "Sloped", "Rounded" },
            CurrentDims  = new Vector3(1f, 1f, 4f),
            DefaultDims  = PartDescriptorProcedural.DefaultDims.Min,
            UnitMaxDims  = new Vector3(1f, 1f, 500f),
            UnitMinDims  = new Vector3(1f, 1f, 0.1f),
        },
        new()
        {
            NameContains = new[] { "Resizable", "Beam", "Rounded" },
            NameExcludes = new[] { "Sloped" },
            CurrentDims  = new Vector3(1f, 1f, 4f),
            DefaultDims  = PartDescriptorProcedural.DefaultDims.Min,
            UnitMaxDims  = new Vector3(1f, 1f, 500f),
            UnitMinDims  = new Vector3(1f, 1f, 0.0f),
        },
        new()
        {
            NameContains = new[] { "Resizable", "Plate" },
            NameExcludes = new[] { "Sloped", "Wedge", "Axle", "Connector", "Circle" },
            CurrentDims  = new Vector3(5f, 0.5f, 5f),
            DefaultDims  = PartDescriptorProcedural.DefaultDims.Min,
            UnitMaxDims  = new Vector3(500f, 500f, 500f),
            UnitMinDims  = new Vector3(0.1f, 0.1f, 0.1f),
        },
        new()
        {
            NameContains = new[] { "Resizable", "Plate", "Circle" },
            CurrentDims  = new Vector3(0f, 0.5f, 2f),
            DefaultDims  = PartDescriptorProcedural.DefaultDims.Min,
            UnitMaxDims  = new Vector3(0f, 500f, 500f),
            UnitMinDims  = new Vector3(0f, 0.1f, 0.1f),
        },
        new()
        {
            NameContains = new[] { "Sloped Plate Resizable" },
            CurrentDims  = new Vector3(5f, 5f, 5f),
            DefaultDims  = PartDescriptorProcedural.DefaultDims.Min,
            UnitMaxDims  = new Vector3(500f, 500f, 500f),
            UnitMinDims  = new Vector3(1f, 1.1f, 0.1f),
        },
        new()
        {
            NameContains = new[] { "Sloped BeamPlate Resizable" },
            CurrentDims  = new Vector3(5f, 5f, 0.5f),
            DefaultDims  = PartDescriptorProcedural.DefaultDims.Min,
            UnitMaxDims  = new Vector3(500f, 500f, 0.5f),
            UnitMinDims  = new Vector3(1.1f, 1.1f, 0.5f),
        },
        new()
        {
            NameContains = new[] { "Sloped Beam Resizable" },
            CurrentDims  = new Vector3(5f, 5f, 1f),
            DefaultDims  = PartDescriptorProcedural.DefaultDims.Min,
            UnitMaxDims  = new Vector3(500f, 500f, 1f),
            UnitMinDims  = new Vector3(1.1f, 1.1f, 1f),
        },
        new()
        {
            NameContains = new[] { "Cylinder Resizable" },
            CurrentDims  = new Vector3(2f, 0f, 5f),
            DefaultDims  = PartDescriptorProcedural.DefaultDims.Min,
            UnitMaxDims  = new Vector3(500f, 0f, 500f),
            UnitMinDims  = new Vector3(0.5f, 0f, 0.1f),
        },
        new()
        {
            NameContains = new[] { "CheckpointBox Resizable" },
            CurrentDims  = new Vector3(50f, 50f, 50f),
            DefaultDims  = PartDescriptorProcedural.DefaultDims.Min,
            UnitMaxDims  = new Vector3(500f, 500f, 500f),
            UnitMinDims  = new Vector3(1f, 1f, 1f),
            UnitStepDims = new Vector3(1f, 1f, 1f),
        },
        new()
        {
            NameContains = new[] { "CheckpointCylinder Resizable" },
            CurrentDims  = new Vector3(0f, 50f, 50f),
            DefaultDims  = PartDescriptorProcedural.DefaultDims.Min,
            UnitMaxDims  = new Vector3(0f, 500f, 500f),
            UnitMinDims  = new Vector3(0f, 1f, 1f),
            UnitStepDims = new Vector3(1f, 1f, 1f),
        },
        new()
        {
            NameContains = new[] { "Sphere Resizable" },
            CurrentDims  = new Vector3(0f, 0f, 5f),
            DefaultDims  = PartDescriptorProcedural.DefaultDims.Min,
            UnitMaxDims  = new Vector3(0f, 0f, 500f),
            UnitMinDims  = new Vector3(0f, 0f, 0.1f),
        },
        new()
        {
            NameContains = new[] { "Wedge Plate Resizable" },
            CurrentDims  = new Vector3(5f, 5f, 0.5f),
            DefaultDims  = PartDescriptorProcedural.DefaultDims.Min,
            UnitMaxDims  = new Vector3(500f, 500f, 500f),
            UnitMinDims  = new Vector3(1f, 1f, 0.1f),
        },
        new()
        {
            NameContains = new[] { "Resizable", "Connector" },
            NameExcludes = new[] { "Plate Resizable", "Slider" },
            CurrentDims  = new Vector3(0.5f, 0f, 5f),
            DefaultDims  = PartDescriptorProcedural.DefaultDims.Min,
            UnitMaxDims  = new Vector3(0.5f, 0f, 500f),
            UnitMinDims  = new Vector3(0.5f, 0f, 0f),
        },
        new()
        {
            NameContains = new[] { "Plate Resizable", "Connector" },
            CurrentDims  = new Vector3(1f, 0.5f, 5f),
            DefaultDims  = PartDescriptorProcedural.DefaultDims.Min,
            UnitMaxDims  = new Vector3(1f, 0.5f, 500f),
            UnitMinDims  = new Vector3(1f, 0.5f, 0f),
        },
        new()
        {
            NameContains = new[] { "Axle Resizable" },
            NameExcludes = new[] { "Connector", "Engine" },
            CurrentDims  = new Vector3(0.5f, 0f, 7f),
            DefaultDims  = PartDescriptorProcedural.DefaultDims.Min,
            UnitMaxDims  = new Vector3(0.5f, 0f, 500f),
            UnitMinDims  = new Vector3(0.5f, 0f, 0.1f),
        },
        new()
        {
            NameContains = new[] { "Axle Resizable", "Engine" },
            CurrentDims  = new Vector3(0.5f, 0f, 1f),
            DefaultDims  = PartDescriptorProcedural.DefaultDims.Min,
            UnitMaxDims  = new Vector3(0.5f, 0f, 500f),
            UnitMinDims  = new Vector3(0.5f, 0f, 0.1f),
        },
        new()
        {
            NameContains = new[] { "Connector 2-Hole Axle Resizable" },
            CurrentDims  = new Vector3(0.5f, 0f, 5f),
            DefaultDims  = PartDescriptorProcedural.DefaultDims.Min,
            UnitMaxDims  = new Vector3(0.5f, 0f, 500f),
            UnitMinDims  = new Vector3(0.5f, 0f, -0.9f),
        },
        new()
        {
            NameContains = new[] { "Connector 2-Hole Axle Perp Resizable" },
            CurrentDims  = new Vector3(0.5f, 0f, 5f),
            DefaultDims  = PartDescriptorProcedural.DefaultDims.Min,
            UnitMaxDims  = new Vector3(0.5f, 0f, 500f),
            UnitMinDims  = new Vector3(0.5f, 0f, -1f),
        },
        new()
        {
            NameContains = new[] { "Pipe Straight Resizable" },
            CurrentDims  = new Vector3(5f, 0.75f, 0f),
            DefaultDims  = PartDescriptorProcedural.DefaultDims.Min,
            UnitMaxDims  = new Vector3(500f, 0.75f, 0f),
            UnitMinDims  = new Vector3(0.1f, 0.75f, 0f),
        },
        new()
        {
            NameContains = new[] { "SliderRail", "Connector" },
            CurrentDims  = new Vector3(1f, 0.5f, 5f),
            DefaultDims  = PartDescriptorProcedural.DefaultDims.Min,
            UnitMaxDims  = new Vector3(1f, 0.5f, 500f),
            UnitMinDims  = new Vector3(1f, 0.5f, 1f),
        },
        new()
        {
            NameContains = new[] { "SliderRail" },
            NameExcludes = new[] { "Connector" },
            CurrentDims  = new Vector3(1f, 0.5f, 7f),
            DefaultDims  = PartDescriptorProcedural.DefaultDims.Min,
            UnitMaxDims  = new Vector3(1f, 0.5f, 500f),
            UnitMinDims  = new Vector3(1f, 0.5f, 1f),
        },
    };

    public override void OnSceneWasLoaded(int buildIndex, string sceneName)
    {
        var candidates = UnityEngine
            .Object
            .FindObjectsOfTypeAll(Il2CppType.Of<PartDescriptorProcedural>())
            .AsEnumerable()
            .Select(x => x.TryCast<PartDescriptorProcedural>()!)
            .Where(x => x is not null)
            .ToList();

        foreach (var descriptor in candidates)
        {
            ApplyRules(descriptor, _rules);
        }

        MelonLogger.Msg("Allowing free part resizing");
    }

    private static void ApplyRules(PartDescriptorProcedural descriptor, IReadOnlyList<Rule> rules)
    {
        foreach (var rule in rules)
        {
            var hasAllRequiredNames = rule.NameContains.All(descriptor.name.Contains);
            var hasNoExcludedNames = rule.NameExcludes.None(descriptor.name.Contains);
            if (!hasAllRequiredNames || !hasNoExcludedNames)
                continue;

            if (rule.CurrentDims.HasValue)
                descriptor.currentUnitDims = rule.CurrentDims.Value;

            if (rule.DefaultDims.HasValue)
                descriptor.defaultDims = rule.DefaultDims.Value;
            if (rule.UnitMinDims.HasValue)
                descriptor.unitMinDims = rule.UnitMinDims.Value;
            if (rule.UnitMaxDims.HasValue)
                descriptor.unitMaxDims = rule.UnitMaxDims.Value;
            if (rule.UnitStepDims.HasValue)
                descriptor.unitStepDims = rule.UnitStepDims.Value;
        }
    }
}
