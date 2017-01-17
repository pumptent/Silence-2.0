#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// UnityEngine.UI.Text
struct Text_t9039225;

#include "UnityEngine_UnityEngine_MonoBehaviour667441552.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Timer
struct  Timer_t80811813  : public MonoBehaviour_t667441552
{
public:
	// System.Single Timer::countDown
	float ___countDown_2;
	// UnityEngine.UI.Text Timer::testIndicator
	Text_t9039225 * ___testIndicator_3;

public:
	inline static int32_t get_offset_of_countDown_2() { return static_cast<int32_t>(offsetof(Timer_t80811813, ___countDown_2)); }
	inline float get_countDown_2() const { return ___countDown_2; }
	inline float* get_address_of_countDown_2() { return &___countDown_2; }
	inline void set_countDown_2(float value)
	{
		___countDown_2 = value;
	}

	inline static int32_t get_offset_of_testIndicator_3() { return static_cast<int32_t>(offsetof(Timer_t80811813, ___testIndicator_3)); }
	inline Text_t9039225 * get_testIndicator_3() const { return ___testIndicator_3; }
	inline Text_t9039225 ** get_address_of_testIndicator_3() { return &___testIndicator_3; }
	inline void set_testIndicator_3(Text_t9039225 * value)
	{
		___testIndicator_3 = value;
		Il2CppCodeGenWriteBarrier(&___testIndicator_3, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
