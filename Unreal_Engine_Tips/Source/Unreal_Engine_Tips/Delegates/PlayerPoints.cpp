#include "Delegates/PlayerPoints.h"

#include "Enemy.h"
#include "Kismet/GameplayStatics.h"

UPlayerPoints::UPlayerPoints()
{
	PrimaryComponentTick.bCanEverTick = true;
}

void UPlayerPoints::BeginPlay()
{
	Super::BeginPlay();

	TArray<AActor*> enemyActors;
	UGameplayStatics::GetAllActorsOfClass(GetWorld(), AEnemy::StaticClass(), enemyActors);
	for (AActor* enemyActor : enemyActors)
	{
		AEnemy* enemy = Cast<AEnemy>(enemyActor);
		enemy->_onEnemyDeath.AddUObject(this, &UPlayerPoints::OnPointsModified);
	}
}

void UPlayerPoints::OnPointsModified(int modifier)
{
	_playerPoints += modifier;

	UE_LOG(LogTemp, Log, TEXT("Points Modified! Current score = %i"), _playerPoints);
}
