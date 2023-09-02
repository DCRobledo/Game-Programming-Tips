// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class Unreal_Engine_TipsEditorTarget : TargetRules
{
	public Unreal_Engine_TipsEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		// DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.Add("Unreal_Engine_Tips");
	}
}
