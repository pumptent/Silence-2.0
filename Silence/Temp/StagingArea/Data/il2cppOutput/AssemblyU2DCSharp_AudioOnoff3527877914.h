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

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// AudioOnoff
struct  AudioOnoff_t3527877914  : public MonoBehaviour_t667441552
{
public:
	// UnityEngine.AudioSource AudioOnoff::sound
	AudioSource_t1740077639 * ___sound_3;

public:
	inline static int32_t get_offset_of_sound_3() { return static_cast<int32_t>(offsetof(AudioOnoff_t3527877914, ___sound_3)); }
	inline AudioSource_t1740077639 * get_sound_3() const { return ___sound_3; }
	inline AudioSource_t1740077639 ** get_address_of_sound_3() { return &___sound_3; }
	inline void set_sound_3(AudioSource_t1740077639 * value)
	{
		___sound_3 = value;
		Il2CppCodeGenWriteBarrier(&___sound_3, value);
	}
};

struct AudioOnoff_t3527877914_StaticFields
{
public:
	// System.Int32 AudioOnoff::times
	int32_t ___times_2;

public:
	inline static int32_t get_offset_of_times_2() { return static_cast<int32_t>(offsetof(AudioOnoff_t3527877914_StaticFields, ___times_2)); }
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
