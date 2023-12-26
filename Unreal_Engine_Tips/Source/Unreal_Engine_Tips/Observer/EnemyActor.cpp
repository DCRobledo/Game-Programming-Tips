#include "Observer/EnemyActor.h"

#include "EventManager.h"
#include "PlasmidActor.h"

AEnemyActor::AEnemyActor()
{
	PrimaryActorTick.bCanEverTick = true;

	Tags.Add(TEXT("Enemy"));

	m_CapsuleComponent = CreateDefaultSubobject<UCapsuleComponent>(TEXT("Capsule Collison"));
	m_CapsuleComponent->BodyInstance.SetCollisionProfileName("Pawn");
}

void AEnemyActor::BeginPlay()
{
	Super::BeginPlay();

	m_CapsuleComponent->OnComponentBeginOverlap.AddDynamic(this, &AEnemyActor::OnBeginOverlap);
}

void AEnemyActor::EndPlay(const EEndPlayReason::Type EndPlayReason)
{
	Super::EndPlay(EndPlayReason);
	
	m_CapsuleComponent->OnComponentBeginOverlap.RemoveDynamic(this, &AEnemyActor::OnBeginOverlap);
}

#pragma region Collision

void AEnemyActor::OnBeginOverlap(UPrimitiveComponent* overlappedComponent, AActor* otherActor,
	UPrimitiveComponent* otherComp, int32 otherBodyIndex, bool fromSweep, const FHitResult& sweepResult)
{
	if(otherActor != nullptr && otherActor != GetOwner())
	{
		if(otherActor->Tags.Contains(TEXT("Plasmid")))
		{
			TakeDamage(Cast<APlasmidActor>(otherActor)->GetDamage());
		}
	}
}

#pragma endregion

#pragma region Health

void AEnemyActor::TakeDamage(float damageToTake)
{
	if(!m_IsDamaged)
	{
		m_Health -= damageToTake;

		if(m_Health <= 0)
		{
			Die();
		}
		else
		{
			m_IsDamaged = true;
			
			FTimerDelegate timerDelegate;
			timerDelegate.BindWeakLambda(this, [=]
			{
				StopDamagedAnimation();
			});

			FTimerHandle timerHandle;
			GetWorld()->GetTimerManager().SetTimer(timerHandle, timerDelegate, m_DamagedAnimationSeconds, false);
		}
	}
}

void AEnemyActor::Die()
{
	EventManager::SendEvent(E_EventType::EnemyDeath, m_Points);
	
	Destroy();
}

#pragma endregion

#pragma region Animation

void AEnemyActor::StopDamagedAnimation()
{
	m_IsDamaged = false;
}

#pragma endregion
