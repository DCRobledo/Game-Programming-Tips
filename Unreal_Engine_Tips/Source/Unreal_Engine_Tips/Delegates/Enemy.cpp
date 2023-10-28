#include "Delegates/Enemy.h"

#include "PlayerPoints.h"

AEnemy::AEnemy()
{
	PrimaryActorTick.bCanEverTick = true;
}

void AEnemy::BeginPlay()
{
	Super::BeginPlay();

	OnActorBeginOverlap.AddDynamic(this, &AEnemy::OnBeginOverlap);
}

void AEnemy::OnBeginOverlap(AActor* overlappedActor, AActor* otherActor)
{
	if(otherActor->Tags.Contains(TEXT("Bullet")))
	{
		if(_onEnemyDeath.IsBound())
		{
			_onEnemyDeath.Broadcast(_points);
			_onEnemyDeath.Clear();

			UE_LOG(LogTemp, Log, TEXT("Enemy %s died for %i points!"), *GetName() , _points);

			Destroy();
		}
	}
}


