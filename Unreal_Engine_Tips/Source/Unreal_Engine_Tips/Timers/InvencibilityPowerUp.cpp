#include "Timers/InvencibilityPowerUp.h"

AInvencibilityPowerUp::AInvencibilityPowerUp()
{
 	_sphereComponent = CreateDefaultSubobject<USphereComponent>("Sphere Component");
	_sphereComponent->InitSphereRadius(10.f);
	_sphereComponent->OnComponentBeginOverlap.AddDynamic(this, &AInvencibilityPowerUp::OnBeginOverlap);
}

void AInvencibilityPowerUp::OnBeginOverlap(UPrimitiveComponent* OverlappedComponent, AActor* OtherActor,
	UPrimitiveComponent* OtherComp, int32 OtherBodyIndex, bool bFromSweep, const FHitResult &SweepResult)
{
	if(OtherActor->Tags.Contains("Player"))
	{
		StartInvencibilityTimer(_invencibilityTime);

		SetActorHiddenInGame(true);
		_sphereComponent->SetCollisionEnabled(ECollisionEnabled::NoCollision);
	}
}

void AInvencibilityPowerUp::StartInvencibilityTimer(const float invencibilityTime)
{
	UE_LOG(LogTemp, Warning, TEXT("Invencibility ON!"))
	
	FTimerDelegate timerDelegate;
	timerDelegate.BindUFunction(this, "StopInvencibilityTimer");

	FTimerHandle timerHandler;
	GetWorld()->GetTimerManager().SetTimer(timerHandler, timerDelegate, invencibilityTime, false);
}

void AInvencibilityPowerUp::StopInvencibilityTimer()
{
	UE_LOG(LogTemp, Warning, TEXT("Invencibility OFF!"))

	Destroy();
}
