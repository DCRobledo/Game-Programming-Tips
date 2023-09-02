#pragma once

#include "CoreMinimal.h"
#include "GameFramework/Actor.h"
#include "Bullet.generated.h"

class USphereComponent;
class UProjectileMovementComponent;

class ABulletPool;

UCLASS()
class UNREAL_ENGINE_TIPS_API ABullet : public AActor
{
	GENERATED_BODY()
	
public:
	ABullet();

	virtual void Destroyed() override;

#pragma region IPoolObject
	
public:
	void OnActivate();
	void OnDeactivate();

private:
	UPROPERTY()
	ABulletPool* _bulletPool;
	
#pragma endregion 

#pragma region Components

private:
	UPROPERTY(VisibleDefaultsOnly, Category=Components)
	USphereComponent* _sphereComponent;
	
	UPROPERTY(VisibleAnywhere, BlueprintReadOnly, Category=Movement, meta=(AllowPrivateAccess="true"))
	UProjectileMovementComponent* _projectileMovement;

	UPROPERTY(EditAnywhere, Category=Movement, DisplayName="Bullet Speed", meta=(ClampMin=100.f, ClampMax=3000.f))
	float _speed;
	
#pragma endregion 

#pragma region Hit

private:
	UFUNCTION()
	void OnHit(UPrimitiveComponent* hitComp, AActor* otherActor, UPrimitiveComponent* otherComp, FVector normalImpulse, const FHitResult& hit);
	
#pragma endregion 
	
};
