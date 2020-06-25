//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Fbx {

public class FbxStringSymbol : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FbxStringSymbol(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(FbxStringSymbol obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~FbxStringSymbol() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          FbxWrapperNativePINVOKE.delete_FbxStringSymbol(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public FbxStringSymbol() : this(FbxWrapperNativePINVOKE.new_FbxStringSymbol__SWIG_0(), true) {
  }

  public FbxStringSymbol(string pName) : this(FbxWrapperNativePINVOKE.new_FbxStringSymbol__SWIG_1(pName), true) {
  }

  public FbxStringSymbol(FbxStringSymbol pOther) : this(FbxWrapperNativePINVOKE.new_FbxStringSymbol__SWIG_2(FbxStringSymbol.getCPtr(pOther)), true) {
    if (FbxWrapperNativePINVOKE.SWIGPendingException.Pending) throw FbxWrapperNativePINVOKE.SWIGPendingException.Retrieve();
  }

  public string ToConstCharPtr() {
    string ret = FbxWrapperNativePINVOKE.FbxStringSymbol_ToConstCharPtr(swigCPtr);
    return ret;
  }

  public bool IsEmpty() {
    bool ret = FbxWrapperNativePINVOKE.FbxStringSymbol_IsEmpty(swigCPtr);
    return ret;
  }

  public static void AllocateGlobalStringSymbolMap() {
    FbxWrapperNativePINVOKE.FbxStringSymbol_AllocateGlobalStringSymbolMap();
  }

  public static void FreeGlobalStringSymbolMap() {
    FbxWrapperNativePINVOKE.FbxStringSymbol_FreeGlobalStringSymbolMap();
  }

  public FbxStringSymbol assign(string pName) {
    FbxStringSymbol ret = new FbxStringSymbol(FbxWrapperNativePINVOKE.FbxStringSymbol_assign(swigCPtr, pName), false);
    return ret;
  }

}

}