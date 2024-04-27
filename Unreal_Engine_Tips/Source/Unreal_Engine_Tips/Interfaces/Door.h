#pragma once

#include "CoreMinimal.h"
#include "Interactable.h"
#include "GameFramework/Actor.h"
#include "Door.generated.h"

UCLASS()
class UNREAL_ENGINE_TIPS_API ADoor : public AActor, public IInteractable
{
	GENERATED_BODY()

public:
	ADoor();

	virtual void OnPlayerInteraction_Implementation() override;
};
