#pragma once

#include "CoreMinimal.h"
#include "GameInstanceSubsystem.h"
#include "Observer/EventManager.h"
#include "PlayerStatsSubsystem.generated.h"

UCLASS()
class UNREAL_ENGINE_TIPS_API UPlayerStatsSubsystem : public UGameInstanceSubsystem
{
	GENERATED_BODY()
	
public:
	virtual void Initialize(FSubsystemCollectionBase& Collection) override;
	virtual void Deinitialize() override;
	
private:
	int32 m_PlayerScore = 0;
	
	void OnEnemyDeath(E_EventType eventType, const int32 intParam);
	
};