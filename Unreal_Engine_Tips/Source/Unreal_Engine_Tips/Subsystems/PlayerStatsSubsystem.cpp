#include "PlayerStatsSubsystem.h"

void UPlayerStatsSubsystem::Initialize(FSubsystemCollectionBase& Collection)
{
	EventManager::AddListener(E_EventType::EnemyDeath, this, &UPlayerStatsSubsystem::OnEnemyDeath);
	
	Super::Initialize(Collection);
}

void UPlayerStatsSubsystem::Deinitialize()
{
	EventManager::RemoveListener(E_EventType::EnemyDeath, this, &UPlayerStatsSubsystem::OnEnemyDeath);

	Super::Deinitialize();
}

void UPlayerStatsSubsystem::OnEnemyDeath(E_EventType eventType, const int32 intParam)
{
	m_PlayerScore += intParam;

	if (GEngine)
	{
		const FString debugMessage = FString::Printf(TEXT("Current Player Score = %i"), m_PlayerScore);
		GEngine->AddOnScreenDebugMessage(1, 2.0f, FColor::Cyan, debugMessage);
	}
}