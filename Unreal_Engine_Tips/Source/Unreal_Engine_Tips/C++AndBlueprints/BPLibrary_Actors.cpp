#include "BPLibrary_Actors.h"

/*static*/ bool UBPLibrary_Actors::AreActorsClose(AActor* firstActor, AActor* secondActor, float threshold)
{
	if (IsValid(firstActor) && IsValid(secondActor))
	{
		const float squaredDistance = FVector::DistSquared(firstActor->GetActorLocation(), secondActor->GetActorLocation());
		return squaredDistance <= FMath::Square(threshold);
	}

	return false;
}