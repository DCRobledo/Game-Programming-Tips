#pragma once

#include "CoreMinimal.h"
#include "GameFramework/Actor.h"
#include "BulletPool.generated.h"

class ABullet;

UCLASS()
class UNREAL_ENGINE_TIPS_API ABulletPool : public AActor
{
	GENERATED_BODY()
	
public:
	ABulletPool();
	
	virtual void BeginPlay() override;
	
#pragma region PoolProperties
	
private:
	UPROPERTY(EditDefaultsOnly, BlueprintReadOnly, Category=Pool, meta=(AllowPrivateAccess="true"))
	TSubclassOf<ABullet> _bulletClass;
	
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category=Pool, meta=(AllowPrivateAccess="true"))
	int32 _startSize = 10;
	
	TQueue<ABullet*> _bulletPool;
	
#pragma endregion 

#pragma region PoolManagement

public:
	UFUNCTION()
	ABullet* GetFromPool(FVector location, FRotator rotation);

	UFUNCTION()
	void ReturnToPool(ABullet* bullet);

private:
	void InitPool();
	
	bool IsPoolEmpty() const;

	ABullet* CreateBullet() const;
	
#pragma endregion 
	
};
