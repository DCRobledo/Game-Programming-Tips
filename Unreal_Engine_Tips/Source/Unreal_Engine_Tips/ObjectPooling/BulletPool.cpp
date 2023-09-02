#include "ObjectPooling/BulletPool.h"

#include "ObjectPooling/Bullet.h"

ABulletPool::ABulletPool()
{
	PrimaryActorTick.bCanEverTick = false;
}

void ABulletPool::BeginPlay()
{
	InitPool();
	
	Super::BeginPlay();
}

#pragma region PoolManagement

ABullet* ABulletPool::GetFromPool(FVector location = FVector::ZeroVector, FRotator rotation = FRotator::ZeroRotator)
{
	ABullet* bullet;

	if(IsPoolEmpty())
	{
		bullet = CreateBullet();
	}
	else
	{
		_bulletPool.Dequeue(bullet);
	}
	
	bullet->OnActivate();

	bullet->SetActorLocation(location);
	bullet->SetActorRotation(rotation);

	return bullet;
}

void ABulletPool::ReturnToPool(ABullet* bullet)
{
	_bulletPool.Enqueue(bullet);
	bullet->OnDeactivate();
}

void ABulletPool::InitPool()
{
	_bulletPool.Empty();

	for (int i = 0; i < _startSize; ++i)
	{
		ABullet* bullet = CreateBullet();
		bullet->OnDeactivate();
		_bulletPool.Enqueue(bullet);
	}
}

bool ABulletPool::IsPoolEmpty() const
{
	return _bulletPool.IsEmpty();
}

ABullet* ABulletPool::CreateBullet() const
{
	return GetWorld()->SpawnActor<ABullet>(_bulletClass, FVector::Zero(), FRotator::ZeroRotator);
}

#pragma endregion 

