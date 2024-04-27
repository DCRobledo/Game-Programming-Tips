#pragma once

#include "CoreMinimal.h"
#include "Interface.h"
#include "Interactable.generated.h"

UINTERFACE()
class UInteractable : public UInterface
{
	GENERATED_BODY()
};

class UNREAL_ENGINE_TIPS_API IInteractable
{
	GENERATED_BODY()

public:
	UFUNCTION(BlueprintCallable, BlueprintNativeEvent)
	void OnPlayerInteraction();

	UFUNCTION(BlueprintCallable, BlueprintImplementableEvent)
	void OnEnemyInteraction();
	
};