#pragma once

#include "CoreMinimal.h"
#include "GameFramework/Actor.h"
#include "Enemy.generated.h"

DECLARE_MULTICAST_DELEGATE_OneParam(FOnEnemyDeath, int);

UCLASS()
class UNREAL_ENGINE_TIPS_API AEnemy : public AActor
{
	GENERATED_BODY()
	
public:	
	AEnemy();

protected:
	virtual void BeginPlay() override;

public:
	int _points = 5;

	FOnEnemyDeath _onEnemyDeath;

	UFUNCTION()
	void OnBeginOverlap(AActor* overlappedActor, AActor* otherActor);

};
