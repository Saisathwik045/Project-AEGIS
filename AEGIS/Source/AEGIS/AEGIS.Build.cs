// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class AEGIS : ModuleRules
{
	public AEGIS(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"AEGIS",
			"AEGIS/Variant_Platforming",
			"AEGIS/Variant_Platforming/Animation",
			"AEGIS/Variant_Combat",
			"AEGIS/Variant_Combat/AI",
			"AEGIS/Variant_Combat/Animation",
			"AEGIS/Variant_Combat/Gameplay",
			"AEGIS/Variant_Combat/Interfaces",
			"AEGIS/Variant_Combat/UI",
			"AEGIS/Variant_SideScrolling",
			"AEGIS/Variant_SideScrolling/AI",
			"AEGIS/Variant_SideScrolling/Gameplay",
			"AEGIS/Variant_SideScrolling/Interfaces",
			"AEGIS/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
