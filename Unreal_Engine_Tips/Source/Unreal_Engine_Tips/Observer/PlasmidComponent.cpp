#include "Observer/PlasmidComponent.h"

#include "PlasmidActor.h"
#include "PlasmidHUD.h"
#include "UserWidget.h"
#include "Kismet/GameplayStatics.h"
#include "Misc/AutomationTest.h"
#include "Tests/AutomationEditorCommon.h"

UPlasmidComponent::UPlasmidComponent()
{
	PrimaryComponentTick.bCanEverTick = true;
}

void UPlasmidComponent::BeginPlay()
{
	Super::BeginPlay();

	m_Owner = GetOwner();
	
	m_CurrentEVE = 100.f;
	GetWorld()->GetTimerManager().SetTimer(m_EVERegenerationHandle, this, &UPlasmidComponent::RegenerateEVE, 1.0f, true);

	m_PlasmidHUD = CreateWidget<UPlasmidHUD>(UGameplayStatics::GetPlayerController(GetWorld(), 0), m_PlasmidHUDClass);
	m_PlasmidHUD->AddToPlayerScreen();
	m_PlasmidHUD->Init(this);
}

void UPlasmidComponent::EndPlay(const EEndPlayReason::Type EndPlayReason)
{
	Super::EndPlay(EndPlayReason);

	m_OnEVEModified.Clear();

	m_PlasmidHUD->RemoveFromParent();
	m_PlasmidHUD = nullptr;
}

#pragma region PlasmidFiring

void UPlasmidComponent::Fire()
{
	if (!m_IsOnCooldown)
	{
		const float EVECost = m_PlasmidActorClass.GetDefaultObject()->GetEveCost();
		if(m_CurrentEVE >= EVECost)
		{
			const FVector plasmidLocation = m_Owner->GetActorLocation() + FVector(150.f) * m_Owner->GetActorForwardVector();
			GetWorld()->SpawnActor<APlasmidActor>(m_PlasmidActorClass, plasmidLocation, FRotator::ZeroRotator);

			m_CurrentEVE -= EVECost;
			NotifyEVEModified();

			GetWorld()->GetTimerManager().UnPauseTimer(m_EVERegenerationHandle);
		}

		m_IsOnCooldown = true;
		
		FTimerDelegate cooldownDelegate;
		cooldownDelegate.BindWeakLambda(this, [=]
		{
			OnCooldownEnds();
		});
		
		FTimerHandle cooldownHandle;
		GetWorld()->GetTimerManager().SetTimer(cooldownHandle, cooldownDelegate, m_CooldownInSeconds, false);
	}
}

void UPlasmidComponent::OnCooldownEnds()
{
	m_IsOnCooldown = false;
	
}

#pragma endregion

#pragma region EVEManagement

void UPlasmidComponent::RegenerateEVE()
{
	const float newEVE = m_CurrentEVE += m_EVERegeneratedPerSecond;
	
	if(newEVE <= m_MaxEVE)
	{
		m_CurrentEVE = newEVE;
	}
	else
	{
		m_CurrentEVE = m_MaxEVE;

		GetWorld()->GetTimerManager().PauseTimer(m_EVERegenerationHandle);
	}

	NotifyEVEModified();
}

void UPlasmidComponent::NotifyEVEModified() const
{
	if (m_OnEVEModified.IsBound())
	{
		m_OnEVEModified.Broadcast(m_CurrentEVE, m_MaxEVE);
	}
}

bool FEVERegenerationTest::RunTest(const FString& Parameters)
{
	// // Create humble plasmid component
	// UWorld* humbleWorld = FAutomationEditorCommonUtils::CreateNewMap();
	// AActor* humbleActor = humbleWorld->SpawnActor(AActor::StaticClass());
	// UPlasmidComponent* humblePlasmidComponent = humbleActor->CreateDefaultSubobject<UPlasmidComponent>(TEXT("Plasmid Component"));
	//
	// // Set a great EVE regeneration
	// humblePlasmidComponent->SetEVERegeneratedPerSecond(BIG_NUMBER);
	// humblePlasmidComponent->RegenerateEVE();
	//
	// // Destroy humble world
	// humbleWorld->DestroyWorld(false);
	//
	// // Check that the currentEVE didn't surpass the maximum
	// const float currentEVE = humblePlasmidComponent->GetCurrentEVE();
	// const float maxEVE = humblePlasmidComponent->GetMaxEVE();
	//
	// return currentEVE <= maxEVE;
	
	return false;
}

#pragma endregion
