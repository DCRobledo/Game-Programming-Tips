// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class Unreal_Engine_TipsTarget : TargetRules
{
	public Unreal_Engine_TipsTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		// DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.Add("Unreal_Engine_Tips");
	}
}
