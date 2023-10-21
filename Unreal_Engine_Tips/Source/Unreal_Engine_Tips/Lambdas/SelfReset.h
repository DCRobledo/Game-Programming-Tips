#pragma once

#include "CoreMinimal.h"
#include "GameFramework/Actor.h"
#include "SelfReset.generated.h"

UCLASS()
class UNREAL_ENGINE_TIPS_API ASelfReset : public AActor
{
	GENERATED_BODY()
	
public:	
	ASelfReset();

	virtual void BeginPlay() override;
	virtual void EndPlay(const EEndPlayReason::Type EndPlayReason) override;
	
private:
	FTimerHandle _timerHandler;
	FTimerDelegate _timerDelegate;
	
	void FailCompileResetAfterDelay(float delay);
	void FailExecuteResetAfterDelay(float delay);
	void ResetAfterDelay(float delay);
	void WrappedReset();
};
