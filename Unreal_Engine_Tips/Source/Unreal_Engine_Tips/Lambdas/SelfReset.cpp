#include "Lambdas/SelfReset.h"

ASelfReset::ASelfReset() { }

void ASelfReset::BeginPlay()
{
	Super::BeginPlay();

	// FailCompileResetAfterDelay(2.0f);
	// FailExecuteResetAfterDelay(2.0f);
	ResetAfterDelay(2.0f);
}

void ASelfReset::FailCompileResetAfterDelay(float delay)
{
	// This doesn't compile because Reset is not an UFUNCTION
	FTimerHandle timerHandler;
	// GetWorld()->GetTimerManager().SetTimer(timerHandler, this, &ASelfReset::Reset, delay, false);
}

void ASelfReset::FailExecuteResetAfterDelay(float delay)
{
	// This doesn't execute because the compiler can't find a function named "Reset" withing the delegate's scope
	FTimerDelegate timerDelegate;
	timerDelegate.BindUFunction(this, TEXT("Reset"));

	FTimerHandle timerHandler;
	GetWorld()->GetTimerManager().SetTimer(timerHandler, timerDelegate, delay, false);
}

void ASelfReset::ResetAfterDelay(float delay)
{
	// We wrap the Reset function within a lambda expression
	FTimerDelegate timerDelegate;
	timerDelegate.BindLambda([this, delay]()
	{
		UE_LOG(LogTemp, Warning, TEXT("I reset after %f seconds!"), delay);
		Reset();
	});

	FTimerHandle timerHandler;
	GetWorld()->GetTimerManager().SetTimer(timerHandler, timerDelegate, delay, false);
}

