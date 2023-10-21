#include "Lambdas/SelfReset.h"

ASelfReset::ASelfReset() { }

void ASelfReset::BeginPlay()
{
	Super::BeginPlay();

	// FailCompileResetAfterDelay(2.0f);
	// FailExecuteResetAfterDelay(2.0f);
	ResetAfterDelay(2.0f);
}

void ASelfReset::EndPlay(const EEndPlayReason::Type EndPlayReason)
{
	Super::EndPlay(EndPlayReason);

	_timerDelegate.Unbind();
}

void ASelfReset::FailCompileResetAfterDelay(float delay)
{
	// This doesn't compile because Reset is not an UFUNCTION
	// GetWorld()->GetTimerManager().SetTimer(_timerHandler, this, &ASelfReset::Reset, delay, false);
}

void ASelfReset::FailExecuteResetAfterDelay(float delay)
{
	// This doesn't execute because the compiler can't find a function named "Reset" within the delegate's scope
	_timerDelegate.BindUFunction(this, TEXT("Reset"));
	GetWorld()->GetTimerManager().SetTimer(_timerHandler, _timerDelegate, delay, false);
}

void ASelfReset::ResetAfterDelay(float delay)
{
	// We wrap the Reset function within a lambda expression
	_timerDelegate.BindLambda([this, delay]()
	{
		UE_LOG(LogTemp, Warning, TEXT("I reset after %f seconds!"), delay);
		Reset();
	});
	
	GetWorld()->GetTimerManager().SetTimer(_timerHandler, _timerDelegate, delay, false);
}

void ASelfReset::WrappedReset()
{
	UE_LOG(LogTemp, Warning, TEXT("I reset!"));
	Reset();
}

