#pragma once

#if UE_BUILD_DEVELOPMENT

class UNREAL_ENGINE_TIPS_API UDebugUtils
{

public:
	static void DebugMessageOnScreen(const FString message, const FColor color, const bool overridePreviousMessage = false);
	
}; // UDebugUtils

#endif