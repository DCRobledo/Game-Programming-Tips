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
	
private:
	void FailCompileResetAfterDelay(float delay);
	void FailExecuteResetAfterDelay(float delay);
	void ResetAfterDelay(float delay);
};
