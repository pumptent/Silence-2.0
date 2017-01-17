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

// PlayerMeter
struct  PlayerMeter_t2207935752  : public MonoBehaviour_t667441552
{
public:
	// System.Single PlayerMeter::meter
	float ___meter_2;
	// UnityEngine.UI.Text PlayerMeter::testIndicator
	Text_t9039225 * ___testIndicator_3;

public:
	inline static int32_t get_offset_of_meter_2() { return static_cast<int32_t>(offsetof(PlayerMeter_t2207935752, ___meter_2)); }
	inline float get_meter_2() const { return ___meter_2; }
	inline float* get_address_of_meter_2() { return &___meter_2; }
	inline void set_meter_2(float value)
	{
		___meter_2 = value;
	}

	inline static int32_t get_offset_of_testIndicator_3() { return static_cast<int32_t>(offsetof(PlayerMeter_t2207935752, ___testIndicator_3)); }
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
