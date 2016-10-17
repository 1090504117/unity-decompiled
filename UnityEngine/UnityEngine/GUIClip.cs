﻿// Decompiled with JetBrains decompiler
// Type: UnityEngine.GUIClip
// Assembly: UnityEngine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A8FF7A2C-E4EE-4232-AB17-3FCABEC16496
// Assembly location: C:\Users\Blake\sandbox\unity\test-project\Library\UnityAssemblies\UnityEngine.dll

using System.Runtime.CompilerServices;

namespace UnityEngine
{
  internal sealed class GUIClip
  {
    public static extern bool enabled { [WrapperlessIcall, MethodImpl(MethodImplOptions.InternalCall)] get; }

    public static Rect topmostRect
    {
      get
      {
        Rect rect;
        GUIClip.INTERNAL_get_topmostRect(out rect);
        return rect;
      }
    }

    public static Rect visibleRect
    {
      get
      {
        Rect rect;
        GUIClip.INTERNAL_get_visibleRect(out rect);
        return rect;
      }
    }

    public static Vector2 Unclip(Vector2 pos)
    {
      GUIClip.Unclip_Vector2(ref pos);
      return pos;
    }

    public static Rect Unclip(Rect rect)
    {
      GUIClip.Unclip_Rect(ref rect);
      return rect;
    }

    public static Vector2 Clip(Vector2 absolutePos)
    {
      GUIClip.Clip_Vector2(ref absolutePos);
      return absolutePos;
    }

    public static Rect Clip(Rect absoluteRect)
    {
      GUIClip.Internal_Clip_Rect(ref absoluteRect);
      return absoluteRect;
    }

    public static Vector2 GetAbsoluteMousePosition()
    {
      Vector2 output;
      GUIClip.Internal_GetAbsoluteMousePosition(out output);
      return output;
    }

    internal static void Push(Rect screenRect, Vector2 scrollOffset, Vector2 renderOffset, bool resetOffset)
    {
      GUIClip.INTERNAL_CALL_Push(ref screenRect, ref scrollOffset, ref renderOffset, resetOffset);
    }

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void INTERNAL_CALL_Push(ref Rect screenRect, ref Vector2 scrollOffset, ref Vector2 renderOffset, bool resetOffset);

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    internal static extern void Pop();

    internal static Rect GetTopRect()
    {
      Rect rect;
      GUIClip.INTERNAL_CALL_GetTopRect(out rect);
      return rect;
    }

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void INTERNAL_CALL_GetTopRect(out Rect value);

    private static void Unclip_Vector2(ref Vector2 pos)
    {
      GUIClip.INTERNAL_CALL_Unclip_Vector2(ref pos);
    }

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void INTERNAL_CALL_Unclip_Vector2(ref Vector2 pos);

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void INTERNAL_get_topmostRect(out Rect value);

    private static void Unclip_Rect(ref Rect rect)
    {
      GUIClip.INTERNAL_CALL_Unclip_Rect(ref rect);
    }

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void INTERNAL_CALL_Unclip_Rect(ref Rect rect);

    private static void Clip_Vector2(ref Vector2 absolutePos)
    {
      GUIClip.INTERNAL_CALL_Clip_Vector2(ref absolutePos);
    }

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void INTERNAL_CALL_Clip_Vector2(ref Vector2 absolutePos);

    private static void Internal_Clip_Rect(ref Rect absoluteRect)
    {
      GUIClip.INTERNAL_CALL_Internal_Clip_Rect(ref absoluteRect);
    }

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void INTERNAL_CALL_Internal_Clip_Rect(ref Rect absoluteRect);

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    internal static extern void Reapply();

    internal static Matrix4x4 GetMatrix()
    {
      Matrix4x4 matrix4x4;
      GUIClip.INTERNAL_CALL_GetMatrix(out matrix4x4);
      return matrix4x4;
    }

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void INTERNAL_CALL_GetMatrix(out Matrix4x4 value);

    internal static void SetMatrix(Matrix4x4 m)
    {
      GUIClip.INTERNAL_CALL_SetMatrix(ref m);
    }

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void INTERNAL_CALL_SetMatrix(ref Matrix4x4 m);

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void INTERNAL_get_visibleRect(out Rect value);

    [WrapperlessIcall]
    [MethodImpl(MethodImplOptions.InternalCall)]
    private static extern void Internal_GetAbsoluteMousePosition(out Vector2 output);
  }
}
