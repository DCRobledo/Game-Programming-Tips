#pragma once

#include "CoreMinimal.h"
#include "Components/ActorComponent.h"
#include "PlasmidComponent.generated.h"

DECLARE_MULTICAST_DELEGATE_TwoParams(FOnEVEModified, float, float);

IMPLEMENT_SIMPLE_AUTOMATION_TEST(FEVERegenerationTest, "PlasmidTests.EVETests.EVE Max Limit", EAutomationTestFlags::EditorContext | EAutomationTestFlags::EngineFilter)

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
	UFUNCTION()
	void RegenerateEVE();
	
	FORCEINLINE FOnEVEModified& OnEVEModified() { return m_OnEVEModified; }

	FORCEINLINE float GetCurrentEVE() const { return m_CurrentEVE; }
	FORCEINLINE float GetMaxEVE() const { return m_MaxEVE; }

	FORCEINLINE void SetEVERegeneratedPerSecond(float EVERegeneratedPerSecond) { m_EVERegeneratedPerSecond = EVERegeneratedPerSecond; }

protected:
	UPROPERTY(EditAnywhere, BlueprintReadWrite, Category="EVE", DisplayName="Max EVE", meta=(AllowPrivateAccess=true))
	float m_MaxEVE = 100.0f;
	UPROPERTY(VisibleAnywhere)
	float m_CurrentEVE = 0.0f;
	UPROPERTY(EditAnywhere, BlueprintReadWrite)
	float m_EVERegeneratedPerSecond = 10.f;
		
private:
	FOnEVEModified m_OnEVEModified;
	
	FTimerHandle m_EVERegenerationHandle;
	
	void NotifyEVEModified() const;
	
#pragma endregion

#pragma region HUD

	UPROPERTY(EditAnywhere)
	TSubclassOf<class UPlasmidHUD> m_PlasmidHUDClass;

	UPROPERTY()
	UPlasmidHUD* m_PlasmidHUD;
	
#pragma endregion 
		
};
