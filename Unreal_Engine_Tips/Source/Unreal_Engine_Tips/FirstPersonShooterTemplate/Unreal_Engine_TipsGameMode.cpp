// Copyright Epic Games, Inc. All Rights Reserved.

#include "Unreal_Engine_TipsGameMode.h"
#include "Unreal_Engine_TipsCharacter.h"
#include "UObject/ConstructorHelpers.h"

AUnreal_Engine_TipsGameMode::AUnreal_Engine_TipsGameMode()
	: Super()
{
	// set default pawn class to our Blueprinted character
	static ConstructorHelpers::FClassFinder<APawn> PlayerPawnClassFinder(TEXT("/Game/FirstPerson/Blueprints/BP_FirstPersonCharacter"));
	DefaultPawnClass = PlayerPawnClassFinder.Class;

}
