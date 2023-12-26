#pragma once

#include "CoreMinimal.h"
#include "Components/ActorComponent.h"
#include "Components/BoxComponent.h"
#include "PlasmidComponent.generated.h"

DECLARE_MULTICAST_DELEGATE_TwoParams(FOnEVEModified, float, float);

UCLASS(Blueprintable, BlueprintType, ClassGroup=(Custom), meta=(BlueprintSpawnableComponent) )
class UNREAL_ENGINE_TIPS_API UPlasmidComponent : public UActorComponent
{
	GENERATED_BODY()

public:	
	UPlasmidComponent();

	virtual void BeginPlay() override;
	virtual void EndPlay(const EEndPlayReason::Type EndPlayReason) override;
	
private:
	UPROPERTY()
	AActor* m_Owner;
	
#pragma region PlasmidFiring
	
public:
	void Fire();

protected:
	UPROPERTY(EditAnywhere, BlueprintReadWrite)
	TSubclassOf<class APlasmidActor> m_PlasmidActorClass;

	UPROPERTY(EditAnywhere, BlueprintReadWrite)
	float m_CooldownInSeconds = 1.5f;
	
	bool m_IsOnCooldown;

	UFUNCTION()
	void OnCooldownEnds();

#pragma endregion

#pragma region EVEManagement

public:
	FORCEINLINE FOnEVEModified& OnEVEModified() { return m_OnEVEModified; }

protected:
	UPROPERTY(EditAnywhere, BlueprintReadWrite)
	float m_MaxEVE = 100.f;
	UPROPERTY(VisibleAnywhere)
	float m_CurrentEVE = 0.0f;
	UPROPERTY(EditAnywhere, BlueprintReadWrite)
	float m_EVERegeneratedPerSecond = 5.f;
		
private:
	FOnEVEModified m_OnEVEModified;
	
	FTimerHandle m_EVERegenerationHandle;
	
	UFUNCTION()
	void RegenerateEVE();
	
	void NotifyEVEModified() const;
	
#pragma endregion

#pragma region HUD

	UPROPERTY(EditAnywhere)
	TSubclassOf<class UPlasmidHUD> m_PlasmidHUDClass;

	UPROPERTY()
	class UPlasmidHUD* m_PlasmidHUD;
	
#pragma endregion 
		
};
