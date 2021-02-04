// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class push_out : ModuleRules
{
	public push_out(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore" });
	}
}
