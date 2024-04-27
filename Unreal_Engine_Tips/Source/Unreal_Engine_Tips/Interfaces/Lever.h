#pragma once

#include "CoreMinimal.h"
#include "Interactable.h"
#include "GameFramework/Actor.h"
#include "Lever.generated.h"

UCLASS()
class UNREAL_ENGINE_TIPS_API ALever : public AActor, public IInteractable
{
	GENERATED_BODY()

public:
	ALever();

	virtual void OnPlayerInteraction_Implementation() override;
};