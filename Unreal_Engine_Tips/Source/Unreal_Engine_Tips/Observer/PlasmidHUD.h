#pragma once

#include "CoreMinimal.h"
#include "EventManager.h"
#include "PlasmidComponent.h"
#include "TextBlock.h"
#include "Blueprint/UserWidget.h"
#include "PlasmidHUD.generated.h"

UCLASS(Abstract)
class UNREAL_ENGINE_TIPS_API UPlasmidHUD : public UUserWidget
{
	GENERATED_BODY()
	
public:
	void Init(UPlasmidComponent* plasmidComponent);
	
private:
	UPROPERTY(EditAnywhere, meta=(BindWidget))
	class UTextBlock* m_PointsText;
	UPROPERTY(EditAnywhere, meta=(BindWidget))
	class UProgressBar* m_EVEBar;

	void OnEnemyDeath(E_EventType eventType, const int32 intParam);
	
	UFUNCTION()
	void SetPoints(int32 currentPoints);
	UFUNCTION()
	void SetEVE(float currentEVE, float maxEVE);
};
