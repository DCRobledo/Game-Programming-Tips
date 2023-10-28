#pragma once

#include "CoreMinimal.h"
#include "Components/ActorComponent.h"
#include "PlayerPoints.generated.h"


UCLASS( ClassGroup=(Custom), meta=(BlueprintSpawnableComponent) )
class UNREAL_ENGINE_TIPS_API UPlayerPoints : public UActorComponent
{
	GENERATED_BODY()

public:	
	UPlayerPoints();

protected:
	virtual void BeginPlay() override;
	
public:
	int _playerPoints;

	UFUNCTION()
	void OnPointsModified(int modifier);
		
};
