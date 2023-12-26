#pragma once

#include "CoreMinimal.h"
#include "Components/SphereComponent.h"
#include "GameFramework/Actor.h"
#include "PlasmidActor.generated.h"

UCLASS()
class UNREAL_ENGINE_TIPS_API APlasmidActor : public AActor
{
	GENERATED_BODY()
	
public:	
	APlasmidActor();

	UPROPERTY(EditAnywhere, BlueprintReadWrite)
	USphereComponent* m_SphereCollision;

#pragma region PlasmidStatistics
	
public:
	FORCEINLINE float GetDamage() const{ return m_Damage; }
	FORCEINLINE float GetEveCost() const { return m_EveCost; }
	
protected:
	UPROPERTY(EditAnywhere, BlueprintReadWrite)
	float m_Damage = 10.f;

	UPROPERTY(EditAnywhere, BlueprintReadWrite)
	float m_EveCost = 25.f;

#pragma endregion 
};
