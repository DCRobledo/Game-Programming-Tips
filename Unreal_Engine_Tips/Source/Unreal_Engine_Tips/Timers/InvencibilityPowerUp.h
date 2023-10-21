#pragma once

#include "CoreMinimal.h"
#include "Components/SphereComponent.h"
#include "GameFramework/Actor.h"
#include "InvencibilityPowerUp.generated.h"

UCLASS()
class UNREAL_ENGINE_TIPS_API AInvencibilityPowerUp : public AActor
{
	GENERATED_BODY()

	UPROPERTY(VisibleDefaultsOnly, Category=PowerUp)
	USphereComponent* _sphereComponent;
	
public:
	AInvencibilityPowerUp();

	USphereComponent* GetCollisionComp() const { return _sphereComponent; }

private:
	UPROPERTY(EditAnywhere, BlueprintReadWrite, meta=(AllowPrivateAccess=true))
	float _invencibilityTime = 3.0f;
	
	UFUNCTION()
	void OnBeginOverlap(UPrimitiveComponent* OverlappedComponent, AActor* OtherActor,
		UPrimitiveComponent* OtherComp, int32 OtherBodyIndex, bool bFromSweep, const FHitResult &SweepResult);

	void StartInvencibilityTimer(const float invencibilityTime);
	UFUNCTION()
	void StopInvencibilityTimer();
};
