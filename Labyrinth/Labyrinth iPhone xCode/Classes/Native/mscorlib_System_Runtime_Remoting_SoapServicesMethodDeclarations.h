﻿#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>
#include <assert.h>
#include <exception>

// System.String
struct String_t;
// System.Reflection.MethodBase
struct MethodBase_t589;
// System.Type
struct Type_t;
// System.Reflection.Assembly
struct Assembly_t980;

#include "codegen/il2cpp-codegen.h"

// System.Void System.Runtime.Remoting.SoapServices::.cctor()
extern "C" void SoapServices__cctor_m8503 (Object_t * __this /* static, unused */, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.String System.Runtime.Remoting.SoapServices::get_XmlNsForClrTypeWithAssembly()
extern "C" String_t* SoapServices_get_XmlNsForClrTypeWithAssembly_m8504 (Object_t * __this /* static, unused */, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.String System.Runtime.Remoting.SoapServices::get_XmlNsForClrTypeWithNs()
extern "C" String_t* SoapServices_get_XmlNsForClrTypeWithNs_m8505 (Object_t * __this /* static, unused */, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.String System.Runtime.Remoting.SoapServices::get_XmlNsForClrTypeWithNsAndAssembly()
extern "C" String_t* SoapServices_get_XmlNsForClrTypeWithNsAndAssembly_m8506 (Object_t * __this /* static, unused */, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.String System.Runtime.Remoting.SoapServices::CodeXmlNamespaceForClrTypeNamespace(System.String,System.String)
extern "C" String_t* SoapServices_CodeXmlNamespaceForClrTypeNamespace_m8507 (Object_t * __this /* static, unused */, String_t* ___typeNamespace, String_t* ___assemblyName, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.String System.Runtime.Remoting.SoapServices::GetNameKey(System.String,System.String)
extern "C" String_t* SoapServices_GetNameKey_m8508 (Object_t * __this /* static, unused */, String_t* ___name, String_t* ___namspace, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.String System.Runtime.Remoting.SoapServices::GetAssemblyName(System.Reflection.MethodBase)
extern "C" String_t* SoapServices_GetAssemblyName_m8509 (Object_t * __this /* static, unused */, MethodBase_t589 * ___mb, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Boolean System.Runtime.Remoting.SoapServices::GetXmlElementForInteropType(System.Type,System.String&,System.String&)
extern "C" bool SoapServices_GetXmlElementForInteropType_m8510 (Object_t * __this /* static, unused */, Type_t * ___type, String_t** ___xmlElement, String_t** ___xmlNamespace, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.String System.Runtime.Remoting.SoapServices::GetXmlNamespaceForMethodCall(System.Reflection.MethodBase)
extern "C" String_t* SoapServices_GetXmlNamespaceForMethodCall_m8511 (Object_t * __this /* static, unused */, MethodBase_t589 * ___mb, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.String System.Runtime.Remoting.SoapServices::GetXmlNamespaceForMethodResponse(System.Reflection.MethodBase)
extern "C" String_t* SoapServices_GetXmlNamespaceForMethodResponse_m8512 (Object_t * __this /* static, unused */, MethodBase_t589 * ___mb, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Boolean System.Runtime.Remoting.SoapServices::GetXmlTypeForInteropType(System.Type,System.String&,System.String&)
extern "C" bool SoapServices_GetXmlTypeForInteropType_m8513 (Object_t * __this /* static, unused */, Type_t * ___type, String_t** ___xmlType, String_t** ___xmlTypeNamespace, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void System.Runtime.Remoting.SoapServices::PreLoad(System.Reflection.Assembly)
extern "C" void SoapServices_PreLoad_m8514 (Object_t * __this /* static, unused */, Assembly_t980 * ___assembly, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void System.Runtime.Remoting.SoapServices::PreLoad(System.Type)
extern "C" void SoapServices_PreLoad_m8515 (Object_t * __this /* static, unused */, Type_t * ___type, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void System.Runtime.Remoting.SoapServices::RegisterInteropXmlElement(System.String,System.String,System.Type)
extern "C" void SoapServices_RegisterInteropXmlElement_m8516 (Object_t * __this /* static, unused */, String_t* ___xmlElement, String_t* ___xmlNamespace, Type_t * ___type, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void System.Runtime.Remoting.SoapServices::RegisterInteropXmlType(System.String,System.String,System.Type)
extern "C" void SoapServices_RegisterInteropXmlType_m8517 (Object_t * __this /* static, unused */, String_t* ___xmlType, String_t* ___xmlTypeNamespace, Type_t * ___type, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.String System.Runtime.Remoting.SoapServices::EncodeNs(System.String)
extern "C" String_t* SoapServices_EncodeNs_m8518 (Object_t * __this /* static, unused */, String_t* ___ns, const MethodInfo* method) IL2CPP_METHOD_ATTR;
