#pragma once

#include "CoreMinimal.h"
#include "GameFramework/Actor.h"
#include "SelfHide.generated.h"

UCLASS()
class UNREAL_ENGINE_TIPS_API ASelfHide : public AActor
{
	GENERATED_BODY()
	
public:	
	ASelfHide();

	virtual void BeginPlay() override;
	virtual void EndPlay(const EEndPlayReason::Type EndPlayReason) override;
	
private:
	FTimerHandle _timerHandler;
	FTimerDelegate _timerDelegate;
	
	void FailCompileHideAfterDelay(float delay);
	
	void AbrazasATuMadreConEsasManos(float delay);
	void WrappedHide();

	void HideAfterDelay(float delay);
};
