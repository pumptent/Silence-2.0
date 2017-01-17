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

// newPartners
struct  newPartners_t2445748843  : public MonoBehaviour_t667441552
{
public:
	// UnityEngine.AudioSource newPartners::sound
	AudioSource_t1740077639 * ___sound_2;
	// UnityEngine.AudioSource newPartners::partnerSound
	AudioSource_t1740077639 * ___partnerSound_3;

public:
	inline static int32_t get_offset_of_sound_2() { return static_cast<int32_t>(offsetof(newPartners_t2445748843, ___sound_2)); }
	inline AudioSource_t1740077639 * get_sound_2() const { return ___sound_2; }
	inline AudioSource_t1740077639 ** get_address_of_sound_2() { return &___sound_2; }
	inline void set_sound_2(AudioSource_t1740077639 * value)
	{
		___sound_2 = value;
		Il2CppCodeGenWriteBarrier(&___sound_2, value);
	}

	inline static int32_t get_offset_of_partnerSound_3() { return static_cast<int32_t>(offsetof(newPartners_t2445748843, ___partnerSound_3)); }
	inline AudioSource_t1740077639 * get_partnerSound_3() const { return ___partnerSound_3; }
	inline AudioSource_t1740077639 ** get_address_of_partnerSound_3() { return &___partnerSound_3; }
	inline void set_partnerSound_3(AudioSource_t1740077639 * value)
	{
		___partnerSound_3 = value;
		Il2CppCodeGenWriteBarrier(&___partnerSound_3, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
