#pragma once

#include "CoreMinimal.h"
#include "GameFramework/Actor.h"
#include "ModelViewerEntry.generated.h"

UCLASS()
class UNREAL_ENGINE_TIPS_API AModelViewerEntry : public AActor
{
	GENERATED_BODY()
	
public:
	UFUNCTION(BlueprintImplementableEvent)
	void PlaySpecialAnimation();

	UFUNCTION(BlueprintNativeEvent)
	void OnSelected();
	UFUNCTION(BlueprintNativeEvent)
	void OnUnSelected();
	
private:
	UPROPERTY(EditAnywhere, BlueprintReadWrite, DisplayName="Model Name", meta=(AllowPrivateAccess=true))
	FString m_ModelName = TEXT("");

	UFUNCTION(BlueprintCallable)
	void PlaySpecialBark();
	
};