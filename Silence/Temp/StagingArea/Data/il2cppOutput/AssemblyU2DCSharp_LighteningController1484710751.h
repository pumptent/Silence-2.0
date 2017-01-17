#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// UnityEngine.Light
struct Light_t4202674828;

#include "UnityEngine_UnityEngine_MonoBehaviour667441552.h"
#include "UnityEngine_UnityEngine_Color4194546905.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// LighteningController
struct  LighteningController_t1484710751  : public MonoBehaviour_t667441552
{
public:
	// UnityEngine.Color LighteningController::lightColor
	Color_t4194546905  ___lightColor_2;
	// System.Single LighteningController::nextLightening
	float ___nextLightening_3;
	// System.Boolean LighteningController::isLightening
	bool ___isLightening_4;
	// System.Single LighteningController::lighteningWave
	float ___lighteningWave_5;
	// UnityEngine.Light LighteningController::myLight
	Light_t4202674828 * ___myLight_6;

public:
	inline static int32_t get_offset_of_lightColor_2() { return static_cast<int32_t>(offsetof(LighteningController_t1484710751, ___lightColor_2)); }
	inline Color_t4194546905  get_lightColor_2() const { return ___lightColor_2; }
	inline Color_t4194546905 * get_address_of_lightColor_2() { return &___lightColor_2; }
	inline void set_lightColor_2(Color_t4194546905  value)
	{
		___lightColor_2 = value;
	}

	inline static int32_t get_offset_of_nextLightening_3() { return static_cast<int32_t>(offsetof(LighteningController_t1484710751, ___nextLightening_3)); }
	inline float get_nextLightening_3() const { return ___nextLightening_3; }
	inline float* get_address_of_nextLightening_3() { return &___nextLightening_3; }
	inline void set_nextLightening_3(float value)
	{
		___nextLightening_3 = value;
	}

	inline static int32_t get_offset_of_isLightening_4() { return static_cast<int32_t>(offsetof(LighteningController_t1484710751, ___isLightening_4)); }
	inline bool get_isLightening_4() const { return ___isLightening_4; }
	inline bool* get_address_of_isLightening_4() { return &___isLightening_4; }
	inline void set_isLightening_4(bool value)
	{
		___isLightening_4 = value;
	}

	inline static int32_t get_offset_of_lighteningWave_5() { return static_cast<int32_t>(offsetof(LighteningController_t1484710751, ___lighteningWave_5)); }
	inline float get_lighteningWave_5() const { return ___lighteningWave_5; }
	inline float* get_address_of_lighteningWave_5() { return &___lighteningWave_5; }
	inline void set_lighteningWave_5(float value)
	{
		___lighteningWave_5 = value;
	}

	inline static int32_t get_offset_of_myLight_6() { return static_cast<int32_t>(offsetof(LighteningController_t1484710751, ___myLight_6)); }
	inline Light_t4202674828 * get_myLight_6() const { return ___myLight_6; }
	inline Light_t4202674828 ** get_address_of_myLight_6() { return &___myLight_6; }
	inline void set_myLight_6(Light_t4202674828 * value)
	{
		___myLight_6 = value;
		Il2CppCodeGenWriteBarrier(&___myLight_6, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
