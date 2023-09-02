#include "ObjectPooling/Bullet.h"

#include "GameFramework/ProjectileMovementComponent.h"
#include "Components/SphereComponent.h"
#include "Kismet/GameplayStatics.h"
#include "ObjectPooling/BulletPool.h"

ABullet::ABullet()
{
 	_sphereComponent = CreateDefaultSubobject<USphereComponent>(TEXT("SphereCollision"));
	_sphereComponent->InitSphereRadius(5.0f);
	_sphereComponent->BodyInstance.SetCollisionProfileName("Projectile");
	_sphereComponent->OnComponentHit.AddDynamic(this, &ABullet::OnHit);
	
	_projectileMovement = CreateDefaultSubobject<UProjectileMovementComponent>(TEXT("ProjectileMovement"));
	_projectileMovement->UpdatedComponent = _sphereComponent;
	_projectileMovement->InitialSpeed = 0.f;
	_projectileMovement->ProjectileGravityScale = 0.f;
	_projectileMovement->bRotationFollowsVelocity = true;
	
	RootComponent = _sphereComponent;

	_bulletPool = Cast<ABulletPool>(UGameplayStatics::GetActorOfClass(GetWorld(), ABulletPool::StaticClass()));
}

void ABullet::Destroyed()
{
	_sphereComponent->OnComponentHit.RemoveDynamic(this, &ABullet::OnHit);
	
	Super::Destroyed();
}

#pragma region IPoolObject

void ABullet::OnActivate()
{
	SetActorHiddenInGame(false);

	_projectileMovement->Velocity = GetActorForwardVector() * _speed;
	_projectileMovement->Activate();
}

void ABullet::OnDeactivate()
{
	SetActorHiddenInGame(true);

	SetActorLocation(FVector::ZeroVector);
	SetActorRotation(FRotator::ZeroRotator);

	_projectileMovement->Deactivate();
}

#pragma endregion

#pragma region Hit

void ABullet::OnHit(UPrimitiveComponent* hitComp, AActor* otherActor, UPrimitiveComponent* otherComp,
	FVector normalImpulse, const FHitResult& hit)
{
	if(otherActor == this)
	{
		return;
	}
	
	_bulletPool->ReturnToPool(this);
}

#pragma endregion 
