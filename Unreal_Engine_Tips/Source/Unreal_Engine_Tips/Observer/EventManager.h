#pragma once

#include "CoreMinimal.h"
#include "Delegates/Delegate.h"

#include "EventManager.generated.h"

UENUM(BlueprintType)
enum class E_EventType : uint8
{
	EnemyDeath,
};

DECLARE_DELEGATE_TwoParams(FOnCallback, E_EventType, const int32);

struct Listener
{
	void* m_Class = nullptr;
	uint64 m_FunctionPointer = 0;
	FOnCallback m_OnCallback;

	friend bool operator ==(Listener a, Listener b)
	{
		return ((a.m_Class == b.m_Class) && (a.m_FunctionPointer == b.m_FunctionPointer));
	}

	Listener() {};
	
	Listener(void* NewClass, uint64 NewFuncPtr, const FOnCallback& NewCallback)
	: m_Class(NewClass)
	, m_FunctionPointer(NewFuncPtr)
	, m_OnCallback(NewCallback)
	{
	}
};

class UNREAL_ENGINE_TIPS_API EventManager
{
public:
	EventManager();
	
	template <typename UserClass, typename std::enable_if<std::is_base_of<UObject, UserClass>::value, void** >::type = nullptr>
	static void AddListener(E_EventType eventType, UserClass* listenerOwner, typename TMemFunPtrType<false, UserClass, void(E_EventType, const int32)>::Type listenerFunction)
	{
		FOnCallback onCallback;
		onCallback.BindUObject(listenerOwner, listenerFunction);

		const Listener listener(listenerOwner, *((uint64*)&listenerFunction), onCallback);
		AddListener(eventType, listener);
	}
	
	static void RemoveListener(E_EventType eventType, const Listener& listener);
	static void SendEvent(E_EventType eventType, const int32 intParam);

private:
	static void AddListener(E_EventType eventType, const Listener& listener);
};
