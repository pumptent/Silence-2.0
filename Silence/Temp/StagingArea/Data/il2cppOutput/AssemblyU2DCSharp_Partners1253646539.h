#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// UnityEngine.AudioSource
struct AudioSource_t1740077639;

#include "UnityEngine_UnityEngine_MonoBehaviour667441552.h"
#include "UnityEngine_UnityEngine_Color4194546905.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// Partners
struct  Partners_t1253646539  : public MonoBehaviour_t667441552
{
public:
	// UnityEngine.AudioSource Partners::sound
	AudioSource_t1740077639 * ___sound_3;
	// UnityEngine.AudioSource Partners::partnerSound
	AudioSource_t1740077639 * ___partnerSound_4;
	// System.Int32 Partners::AssignNum
	int32_t ___AssignNum_5;
	// UnityEngine.Color Partners::originalColor
	Color_t4194546905  ___originalColor_6;

public:
	inline static int32_t get_offset_of_sound_3() { return static_cast<int32_t>(offsetof(Partners_t1253646539, ___sound_3)); }
	inline AudioSource_t1740077639 * get_sound_3() const { return ___sound_3; }
	inline AudioSource_t1740077639 ** get_address_of_sound_3() { return &___sound_3; }
	inline void set_sound_3(AudioSource_t1740077639 * value)
	{
		___sound_3 = value;
		Il2CppCodeGenWriteBarrier(&___sound_3, value);
	}

	inline static int32_t get_offset_of_partnerSound_4() { return static_cast<int32_t>(offsetof(Partners_t1253646539, ___partnerSound_4)); }
	inline AudioSource_t1740077639 * get_partnerSound_4() const { return ___partnerSound_4; }
	inline AudioSource_t1740077639 ** get_address_of_partnerSound_4() { return &___partnerSound_4; }
	inline void set_partnerSound_4(AudioSource_t1740077639 * value)
	{
		___partnerSound_4 = value;
		Il2CppCodeGenWriteBarrier(&___partnerSound_4, value);
	}

	inline static int32_t get_offset_of_AssignNum_5() { return static_cast<int32_t>(offsetof(Partners_t1253646539, ___AssignNum_5)); }
	inline int32_t get_AssignNum_5() const { return ___AssignNum_5; }
	inline int32_t* get_address_of_AssignNum_5() { return &___AssignNum_5; }
	inline void set_AssignNum_5(int32_t value)
	{
		___AssignNum_5 = value;
	}

	inline static int32_t get_offset_of_originalColor_6() { return static_cast<int32_t>(offsetof(Partners_t1253646539, ___originalColor_6)); }
	inline Color_t4194546905  get_originalColor_6() const { return ___originalColor_6; }
	inline Color_t4194546905 * get_address_of_originalColor_6() { return &___originalColor_6; }
	inline void set_originalColor_6(Color_t4194546905  value)
	{
		___originalColor_6 = value;
	}
};

struct Partners_t1253646539_StaticFields
{
public:
	// System.Int32 Partners::times
	int32_t ___times_2;

public:
	inline static int32_t get_offset_of_times_2() { return static_cast<int32_t>(offsetof(Partners_t1253646539_StaticFields, ___times_2)); }
	inline int32_t get_times_2() const { return ___times_2; }
	inline int32_t* get_address_of_times_2() { return &___times_2; }
	inline void set_times_2(int32_t value)
	{
		___times_2 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
