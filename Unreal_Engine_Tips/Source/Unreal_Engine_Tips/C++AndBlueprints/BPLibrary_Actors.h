#pragma once

#include "CoreMinimal.h"
#include "Kismet/BlueprintFunctionLibrary.h"
#include "BPLibrary_Actors.generated.h"

UCLASS()
class UNREAL_ENGINE_TIPS_API UBPLibrary_Actors : public UBlueprintFunctionLibrary
{
	GENERATED_BODY()

	UFUNCTION(BlueprintCallable)
	static bool AreActorsClose(AActor* firstActor, AActor* secondActor, float threshold);
};