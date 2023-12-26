#include "Observer/PlasmidActor.h"

APlasmidActor::APlasmidActor()
{
	PrimaryActorTick.bCanEverTick = true;

	Tags.Add(TEXT("Plasmid"));

	m_SphereCollision = CreateDefaultSubobject<USphereComponent>(TEXT("Sphere Collison"));
	m_SphereCollision->InitSphereRadius(150.0f);
	m_SphereCollision->BodyInstance.SetCollisionProfileName("Projectile");
	m_SphereCollision->SetWalkableSlopeOverride(FWalkableSlopeOverride(WalkableSlope_Unwalkable, 0.f));
	m_SphereCollision->CanCharacterStepUpOn = ECB_No;

	m_SphereCollision->SetCollisionResponseToAllChannels(ECR_Overlap);
	
	RootComponent = m_SphereCollision;

	InitialLifeSpan = 2.0f;
}