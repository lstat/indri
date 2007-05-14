/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.31
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace Indri {

using System;
using System.Runtime.InteropServices;

public class ConfMap : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ConfMap(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(ConfMap obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~ConfMap() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if(swigCPtr.Handle != IntPtr.Zero && swigCMemOwn) {
        swigCMemOwn = false;
        indri_csharpPINVOKE.delete_ConfMap(swigCPtr);
      }
      swigCPtr = new HandleRef(null, IntPtr.Zero);
      GC.SuppressFinalize(this);
    }
  }

  public ConfMap() : this(indri_csharpPINVOKE.new_ConfMap__SWIG_0(), true) {
  }

  public ConfMap(ConfMap arg0) : this(indri_csharpPINVOKE.new_ConfMap__SWIG_1(ConfMap.getCPtr(arg0)), true) {
    if (indri_csharpPINVOKE.SWIGPendingException.Pending) throw indri_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public uint size() {
    uint ret = indri_csharpPINVOKE.ConfMap_size(swigCPtr);
    return ret;
  }

  public bool empty() {
    bool ret = indri_csharpPINVOKE.ConfMap_empty(swigCPtr);
    return ret;
  }

  public void clear() {
    indri_csharpPINVOKE.ConfMap_clear(swigCPtr);
  }

  public string get(ConflationPattern key) {
    string ret = indri_csharpPINVOKE.ConfMap_get(swigCPtr, ConflationPattern.getCPtr(key));
    if (indri_csharpPINVOKE.SWIGPendingException.Pending) throw indri_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void set(ConflationPattern key, string x) {
    indri_csharpPINVOKE.ConfMap_set(swigCPtr, ConflationPattern.getCPtr(key), x);
    if (indri_csharpPINVOKE.SWIGPendingException.Pending) throw indri_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void del(ConflationPattern key) {
    indri_csharpPINVOKE.ConfMap_del(swigCPtr, ConflationPattern.getCPtr(key));
    if (indri_csharpPINVOKE.SWIGPendingException.Pending) throw indri_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool has_key(ConflationPattern key) {
    bool ret = indri_csharpPINVOKE.ConfMap_has_key(swigCPtr, ConflationPattern.getCPtr(key));
    return ret;
  }

}

}
