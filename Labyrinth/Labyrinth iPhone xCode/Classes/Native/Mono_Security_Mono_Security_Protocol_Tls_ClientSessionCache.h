﻿#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// System.Collections.Hashtable
struct Hashtable_t705;
// System.Object
struct Object_t;

#include "mscorlib_System_Object.h"

// Mono.Security.Protocol.Tls.ClientSessionCache
struct  ClientSessionCache_t704  : public Object_t
{
};
struct ClientSessionCache_t704_StaticFields{
	// System.Collections.Hashtable Mono.Security.Protocol.Tls.ClientSessionCache::cache
	Hashtable_t705 * ___cache_0;
	// System.Object Mono.Security.Protocol.Tls.ClientSessionCache::locker
	Object_t * ___locker_1;
};