#pragma once

#include "CoreMinimal.h"
#include "Components/CapsuleComponent.h"
#include "GameFramework/Actor.h"
#include "EnemyActor.generated.h"

UCLASS()
class UNREAL_ENGINE_TIPS_API AEnemyActor : public AActor
{
	GENERATED_BODY()
	
public:	
	AEnemyActor();

	virtual void BeginPlay() override;
	virtual void EndPlay(const EEndPlayReason::Type EndPlayReason) override;

#pragma region Collision
		
protected:
	UPROPERTY(EditAnywhere, BlueprintReadWrite)
	UCapsuleComponent* m_CapsuleComponent;

	UFUNCTION()
	void OnBeginOverlap(UPrimitiveComponent* overlappedComponent, AActor* otherActor, UPrimitiveComponent* otherComp,
		int32 otherBodyIndex, bool fromSweep, const FHitResult& sweepResult);

#pragma endregion
	
#pragma region Health
	
protected:
	UPROPERTY(EditAnywhere, BlueprintReadWrite)
	float m_Health = 30.f;
	UPROPERTY(VisibleAnywhere, BlueprintReadWrite)
	int32 m_Points = 20;

	void TakeDamage(float damageToTake);
	
	void Die();
	
#pragma endregion

#pragma region Animation
	
protected:
	UPROPERTY(EditAnywhere, BlueprintReadWrite)
	bool m_IsDamaged = false;
	
	UPROPERTY(EditAnywhere, BlueprintReadWrite)
	float m_DamagedAnimationSeconds = 2.0f;

	UFUNCTION()
	void StopDamagedAnimation();
	
#pragma endregion 
};