#if UE_BUILD_DEVELOPMENT

#include "DebugUtils.h"

void UDebugUtils::DebugMessageOnScreen(const FString message, const FColor color, const bool overridePreviousMessage)
{
	if (GEngine)
	{
		GEngine->AddOnScreenDebugMessage(overridePreviousMessage ? -2 : -1, 10, color, message);
	}


} // DebugMessageOnScreen

#endif