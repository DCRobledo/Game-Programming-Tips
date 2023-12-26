#include "Observer/PlasmidHUD.h"

#include "ProgressBar.h"

void UPlasmidHUD::Init(UPlasmidComponent* plasmidComponent)
{
	plasmidComponent->OnEVEModified().AddUObject(this, &UPlasmidHUD::SetEVE);

	EventManager::AddListener(E_EventType::EnemyDeath, this, &UPlasmidHUD::OnEnemyDeath);
}

void UPlasmidHUD::OnEnemyDeath(E_EventType eventType, const int32 intParam)
{
	SetPoints(intParam);
}

void UPlasmidHUD::SetPoints(int32 currentPoints)
{
	m_PointsText->SetText(FText::FromString(FString::FromInt(currentPoints)));
}

void UPlasmidHUD::SetEVE(float currentEVE, float maxEVE)
{
	m_EVEBar->SetPercent(currentEVE / maxEVE);
}
