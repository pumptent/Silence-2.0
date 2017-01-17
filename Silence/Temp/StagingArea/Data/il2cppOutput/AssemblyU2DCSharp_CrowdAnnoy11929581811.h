#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// UnityEngine.GameObject
struct GameObject_t3674682005;
// UnityEngine.AudioSource
struct AudioSource_t1740077639;

#include "UnityEngine_UnityEngine_MonoBehaviour667441552.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// CrowdAnnoy1
struct  CrowdAnnoy1_t1929581811  : public MonoBehaviour_t667441552
{
public:
	// System.Int32 CrowdAnnoy1::N1
	int32_t ___N1_2;
	// System.Single CrowdAnnoy1::coolDown
	float ___coolDown_4;
	// UnityEngine.GameObject CrowdAnnoy1::Player
	GameObject_t3674682005 * ___Player_5;
	// UnityEngine.AudioSource CrowdAnnoy1::shush
	AudioSource_t1740077639 * ___shush_7;

public:
	inline static int32_t get_offset_of_N1_2() { return static_cast<int32_t>(offsetof(CrowdAnnoy1_t1929581811, ___N1_2)); }
	inline int32_t get_N1_2() const { return ___N1_2; }
	inline int32_t* get_address_of_N1_2() { return &___N1_2; }
	inline void set_N1_2(int32_t value)
	{
		___N1_2 = value;
	}

	inline static int32_t get_offset_of_coolDown_4() { return static_cast<int32_t>(offsetof(CrowdAnnoy1_t1929581811, ___coolDown_4)); }
	inline float get_coolDown_4() const { return ___coolDown_4; }
	inline float* get_address_of_coolDown_4() { return &___coolDown_4; }
	inline void set_coolDown_4(float value)
	{
		___coolDown_4 = value;
	}

	inline static int32_t get_offset_of_Player_5() { return static_cast<int32_t>(offsetof(CrowdAnnoy1_t1929581811, ___Player_5)); }
	inline GameObject_t3674682005 * get_Player_5() const { return ___Player_5; }
	inline GameObject_t3674682005 ** get_address_of_Player_5() { return &___Player_5; }
	inline void set_Player_5(GameObject_t3674682005 * value)
	{
		___Player_5 = value;
		Il2CppCodeGenWriteBarrier(&___Player_5, value);
	}

	inline static int32_t get_offset_of_shush_7() { return static_cast<int32_t>(offsetof(CrowdAnnoy1_t1929581811, ___shush_7)); }
	inline AudioSource_t1740077639 * get_shush_7() const { return ___shush_7; }
	inline AudioSource_t1740077639 ** get_address_of_shush_7() { return &___shush_7; }
	inline void set_shush_7(AudioSource_t1740077639 * value)
	{
		___shush_7 = value;
		Il2CppCodeGenWriteBarrier(&___shush_7, value);
	}
};

struct CrowdAnnoy1_t1929581811_StaticFields
{
public:
	// System.Single CrowdAnnoy1::N3
	float ___N3_3;
	// System.Int32 CrowdAnnoy1::Anger1
	int32_t ___Anger1_6;

public:
	inline static int32_t get_offset_of_N3_3() { return static_cast<int32_t>(offsetof(CrowdAnnoy1_t1929581811_StaticFields, ___N3_3)); }
	inline float get_N3_3() const { return ___N3_3; }
	inline float* get_address_of_N3_3() { return &___N3_3; }
	inline void set_N3_3(float value)
	{
		___N3_3 = value;
	}

	inline static int32_t get_offset_of_Anger1_6() { return static_cast<int32_t>(offsetof(CrowdAnnoy1_t1929581811_StaticFields, ___Anger1_6)); }
	inline int32_t get_Anger1_6() const { return ___Anger1_6; }
	inline int32_t* get_address_of_Anger1_6() { return &___Anger1_6; }
	inline void set_Anger1_6(int32_t value)
	{
		___Anger1_6 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
