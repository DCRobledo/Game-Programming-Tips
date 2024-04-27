#include "Door.h"

ADoor::ADoor()
{
	PrimaryActorTick.bCanEverTick = true;
}

void ADoor::OnPlayerInteraction_Implementation()
{
	// Open
}