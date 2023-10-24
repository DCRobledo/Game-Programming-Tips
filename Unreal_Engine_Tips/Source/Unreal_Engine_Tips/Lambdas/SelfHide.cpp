#include "SelfHide.h"

ASelfHide::ASelfHide() { }

void ASelfHide::BeginPlay()
{
	Super::BeginPlay();

	// FailCompileHideAfterDelay(2.0f);
	// AbrazasATuMadreConEsasManos(2.0f);
	HideAfterDelay(2.0f);
}

void ASelfHide::EndPlay(const EEndPlayReason::Type EndPlayReason)
{
	Super::EndPlay(EndPlayReason);

	_timerDelegate.Unbind();
}

void ASelfHide::FailCompileHideAfterDelay(float delay)
{
	// This doesn't compile because SetActorHiddenInGame doesn't have a void signature
	// GetWorld()->GetTimerManager().SetTimer(_timerHandler, this, &ASelfHide::SetActorHiddenInGame, delay, false);
}

void ASelfHide::AbrazasATuMadreConEsasManos(float delay)
{
	GetWorld()->GetTimerManager().SetTimer(_timerHandler, this, &ASelfHide::WrappedHide, delay, false);
}

void ASelfHide::WrappedHide()
{
	UE_LOG(LogTemp, Warning, TEXT("I hide!"));
	SetActorHiddenInGame(true);
}

void ASelfHide::HideAfterDelay(float delay)
{
	// We wrap the Reset function within a lambda expression
	_timerDelegate.BindLambda([this, delay]()
	{
		UE_LOG(LogTemp, Warning, TEXT("I hide after %f seconds!"), delay);
		SetActorHiddenInGame(true);
	});
	
	GetWorld()->GetTimerManager().SetTimer(_timerHandler, _timerDelegate, delay, false);
}