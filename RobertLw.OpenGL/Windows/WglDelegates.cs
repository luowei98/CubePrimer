using System;
using System.Runtime.InteropServices;
using System.Security;

// ReSharper disable MemberHidesStaticFromOuterClass
// ReSharper disable InconsistentNaming

namespace RobertLw.OpenGL.Windows
{
#pragma warning disable 0649

    partial class Wgl
    {
        internal static class Delegates
        {
            [SuppressUnmanagedCodeSecurity]
            internal delegate IntPtr CreateContext(IntPtr hDc);
            internal static CreateContext wglCreateContext;
            [SuppressUnmanagedCodeSecurity]
            internal delegate Boolean DeleteContext(IntPtr oldContext);
            internal static DeleteContext wglDeleteContext;
            [SuppressUnmanagedCodeSecurity]
            internal delegate IntPtr GetCurrentContext();
            internal static GetCurrentContext wglGetCurrentContext;
            [SuppressUnmanagedCodeSecurity]
            internal delegate Boolean MakeCurrent(IntPtr hDc, IntPtr newContext);
            internal static MakeCurrent wglMakeCurrent;
            [SuppressUnmanagedCodeSecurity]
            internal delegate Boolean CopyContext(IntPtr hglrcSrc, IntPtr hglrcDst, UInt32 mask);
            internal static CopyContext wglCopyContext;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate int ChoosePixelFormat(IntPtr hDc, Gdi.PixelFormatDescriptor* pPfd);
            internal static ChoosePixelFormat wglChoosePixelFormat;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate int DescribePixelFormat(IntPtr hdc, int ipfd, UInt32 cjpfd, Gdi.PixelFormatDescriptor* ppfd);
            internal static DescribePixelFormat wglDescribePixelFormat;
            [SuppressUnmanagedCodeSecurity]
            internal delegate IntPtr GetCurrentDC();
            internal static GetCurrentDC wglGetCurrentDC;
            [SuppressUnmanagedCodeSecurity]
            internal delegate IntPtr GetDefaultProcAddress(String lpszProc);
            internal static GetDefaultProcAddress wglGetDefaultProcAddress;
            [SuppressUnmanagedCodeSecurity]
            internal delegate IntPtr GetProcAddress(String lpszProc);
            internal static GetProcAddress wglGetProcAddress;
            [SuppressUnmanagedCodeSecurity]
            internal delegate int GetPixelFormat(IntPtr hdc);
            internal static GetPixelFormat wglGetPixelFormat;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate Boolean SetPixelFormat(IntPtr hdc, int ipfd, Gdi.PixelFormatDescriptor* ppfd);
            internal static SetPixelFormat wglSetPixelFormat;
            [SuppressUnmanagedCodeSecurity]
            internal delegate Boolean SwapBuffers(IntPtr hdc);
            internal static SwapBuffers wglSwapBuffers;
            [SuppressUnmanagedCodeSecurity]
            internal delegate Boolean ShareLists(IntPtr hrcSrvShare, IntPtr hrcSrvSource);
            internal static ShareLists wglShareLists;
            [SuppressUnmanagedCodeSecurity]
            internal delegate IntPtr CreateLayerContext(IntPtr hDc, int level);
            internal static CreateLayerContext wglCreateLayerContext;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate Boolean DescribeLayerPlane(IntPtr hDc, int pixelFormat, int layerPlane, UInt32 nBytes, Gdi.LayerPlaneDescriptor* plpd);
            internal static DescribeLayerPlane wglDescribeLayerPlane;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate int SetLayerPaletteEntries(IntPtr hdc, int iLayerPlane, int iStart, int cEntries, Int32* pcr);
            internal static SetLayerPaletteEntries wglSetLayerPaletteEntries;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate int GetLayerPaletteEntries(IntPtr hdc, int iLayerPlane, int iStart, int cEntries, Int32* pcr);
            internal static GetLayerPaletteEntries wglGetLayerPaletteEntries;
            [SuppressUnmanagedCodeSecurity]
            internal delegate Boolean RealizeLayerPalette(IntPtr hdc, int iLayerPlane, Boolean bRealize);
            internal static RealizeLayerPalette wglRealizeLayerPalette;
            [SuppressUnmanagedCodeSecurity]
            internal delegate Boolean SwapLayerBuffers(IntPtr hdc, UInt32 fuFlags);
            internal static SwapLayerBuffers wglSwapLayerBuffers;
            [SuppressUnmanagedCodeSecurity]
            internal delegate Boolean UseFontBitmapsA(IntPtr hDC, Int32 first, Int32 count, Int32 listBase);
            internal static UseFontBitmapsA wglUseFontBitmapsA;
            [SuppressUnmanagedCodeSecurity]
            internal delegate Boolean UseFontBitmapsW(IntPtr hDC, Int32 first, Int32 count, Int32 listBase);
            internal static UseFontBitmapsW wglUseFontBitmapsW;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate Boolean UseFontOutlinesA(IntPtr hDC, Int32 first, Int32 count, Int32 listBase, float thickness, float deviation, Int32 fontMode, Gdi.GlyphMetricsFloat* glyphMetrics);
            internal static UseFontOutlinesA wglUseFontOutlinesA;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate Boolean UseFontOutlinesW(IntPtr hDC, Int32 first, Int32 count, Int32 listBase, float thickness, float deviation, Int32 fontMode, Gdi.GlyphMetricsFloat* glyphMetrics);
            internal static UseFontOutlinesW wglUseFontOutlinesW;
            [SuppressUnmanagedCodeSecurity]
            internal delegate IntPtr CreateBufferRegionARB(IntPtr hDC, int iLayerPlane, UInt32 uType);
            internal static CreateBufferRegionARB wglCreateBufferRegionARB;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DeleteBufferRegionARB(IntPtr hRegion);
            internal static DeleteBufferRegionARB wglDeleteBufferRegionARB;
            [SuppressUnmanagedCodeSecurity]
            internal delegate Boolean SaveBufferRegionARB(IntPtr hRegion, int x, int y, int width, int height);
            internal static SaveBufferRegionARB wglSaveBufferRegionARB;
            [SuppressUnmanagedCodeSecurity]
            internal delegate Boolean RestoreBufferRegionARB(IntPtr hRegion, int x, int y, int width, int height, int xSrc, int ySrc);
            internal static RestoreBufferRegionARB wglRestoreBufferRegionARB;
            [SuppressUnmanagedCodeSecurity]
            internal delegate IntPtr GetExtensionsStringARB(IntPtr hdc);
            internal static GetExtensionsStringARB wglGetExtensionsStringARB;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate Boolean GetPixelFormatAttribivARB(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, int* piAttributes, [Out] int* piValues);
            internal static GetPixelFormatAttribivARB wglGetPixelFormatAttribivARB;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate Boolean GetPixelFormatAttribfvARB(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, int* piAttributes, [Out] Single* pfValues);
            internal static GetPixelFormatAttribfvARB wglGetPixelFormatAttribfvARB;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate Boolean ChoosePixelFormatARB(IntPtr hdc, int* piAttribIList, Single* pfAttribFList, UInt32 nMaxFormats, [Out] int* piFormats, [Out] UInt32* nNumFormats);
            internal static ChoosePixelFormatARB wglChoosePixelFormatARB;
            [SuppressUnmanagedCodeSecurity]
            internal delegate Boolean MakeContextCurrentARB(IntPtr hDrawDC, IntPtr hReadDC, IntPtr hglrc);
            internal static MakeContextCurrentARB wglMakeContextCurrentARB;
            [SuppressUnmanagedCodeSecurity]
            internal delegate IntPtr GetCurrentReadDCARB();
            internal static GetCurrentReadDCARB wglGetCurrentReadDCARB;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate IntPtr CreatePbufferARB(IntPtr hDC, int iPixelFormat, int iWidth, int iHeight, int* piAttribList);
            internal static CreatePbufferARB wglCreatePbufferARB;
            [SuppressUnmanagedCodeSecurity]
            internal delegate IntPtr GetPbufferDCARB(IntPtr hPbuffer);
            internal static GetPbufferDCARB wglGetPbufferDCARB;
            [SuppressUnmanagedCodeSecurity]
            internal delegate int ReleasePbufferDCARB(IntPtr hPbuffer, IntPtr hDC);
            internal static ReleasePbufferDCARB wglReleasePbufferDCARB;
            [SuppressUnmanagedCodeSecurity]
            internal delegate Boolean DestroyPbufferARB(IntPtr hPbuffer);
            internal static DestroyPbufferARB wglDestroyPbufferARB;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate Boolean QueryPbufferARB(IntPtr hPbuffer, int iAttribute, [Out] int* piValue);
            internal static QueryPbufferARB wglQueryPbufferARB;
            [SuppressUnmanagedCodeSecurity]
            internal delegate Boolean BindTexImageARB(IntPtr hPbuffer, int iBuffer);
            internal static BindTexImageARB wglBindTexImageARB;
            [SuppressUnmanagedCodeSecurity]
            internal delegate Boolean ReleaseTexImageARB(IntPtr hPbuffer, int iBuffer);
            internal static ReleaseTexImageARB wglReleaseTexImageARB;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate Boolean SetPbufferAttribARB(IntPtr hPbuffer, int* piAttribList);
            internal static SetPbufferAttribARB wglSetPbufferAttribARB;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool CreateDisplayColorTableEXT(UInt16 id);
            internal static CreateDisplayColorTableEXT wglCreateDisplayColorTableEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate bool LoadDisplayColorTableEXT(UInt16* table, UInt32 length);
            internal static LoadDisplayColorTableEXT wglLoadDisplayColorTableEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate bool BindDisplayColorTableEXT(UInt16 id);
            internal static BindDisplayColorTableEXT wglBindDisplayColorTableEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate void DestroyDisplayColorTableEXT(UInt16 id);
            internal static DestroyDisplayColorTableEXT wglDestroyDisplayColorTableEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate IntPtr GetExtensionsStringEXT();
            internal static GetExtensionsStringEXT wglGetExtensionsStringEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate Boolean MakeContextCurrentEXT(IntPtr hDrawDC, IntPtr hReadDC, IntPtr hglrc);
            internal static MakeContextCurrentEXT wglMakeContextCurrentEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate IntPtr GetCurrentReadDCEXT();
            internal static GetCurrentReadDCEXT wglGetCurrentReadDCEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate IntPtr CreatePbufferEXT(IntPtr hDC, int iPixelFormat, int iWidth, int iHeight, int* piAttribList);
            internal static CreatePbufferEXT wglCreatePbufferEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate IntPtr GetPbufferDCEXT(IntPtr hPbuffer);
            internal static GetPbufferDCEXT wglGetPbufferDCEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate int ReleasePbufferDCEXT(IntPtr hPbuffer, IntPtr hDC);
            internal static ReleasePbufferDCEXT wglReleasePbufferDCEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate Boolean DestroyPbufferEXT(IntPtr hPbuffer);
            internal static DestroyPbufferEXT wglDestroyPbufferEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate Boolean QueryPbufferEXT(IntPtr hPbuffer, int iAttribute, [Out] int* piValue);
            internal static QueryPbufferEXT wglQueryPbufferEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate Boolean GetPixelFormatAttribivEXT(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, [Out] int* piAttributes, [Out] int* piValues);
            internal static GetPixelFormatAttribivEXT wglGetPixelFormatAttribivEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate Boolean GetPixelFormatAttribfvEXT(IntPtr hdc, int iPixelFormat, int iLayerPlane, UInt32 nAttributes, [Out] int* piAttributes, [Out] Single* pfValues);
            internal static GetPixelFormatAttribfvEXT wglGetPixelFormatAttribfvEXT;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate Boolean ChoosePixelFormatEXT(IntPtr hdc, int* piAttribIList, Single* pfAttribFList, UInt32 nMaxFormats, [Out] int* piFormats, [Out] UInt32* nNumFormats);
            internal static ChoosePixelFormatEXT wglChoosePixelFormatEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate Boolean SwapIntervalEXT(int interval);
            internal static SwapIntervalEXT wglSwapIntervalEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate int GetSwapIntervalEXT();
            internal static GetSwapIntervalEXT wglGetSwapIntervalEXT;
            [SuppressUnmanagedCodeSecurity]
            internal delegate IntPtr AllocateMemoryNV(Int32 size, Single readfreq, Single writefreq, Single priority);
            internal static AllocateMemoryNV wglAllocateMemoryNV;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate void FreeMemoryNV([Out] IntPtr* pointer);
            internal static FreeMemoryNV wglFreeMemoryNV;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate Boolean GetSyncValuesOML(IntPtr hdc, [Out] Int64* ust, [Out] Int64* msc, [Out] Int64* sbc);
            internal static GetSyncValuesOML wglGetSyncValuesOML;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate Boolean GetMscRateOML(IntPtr hdc, [Out] Int32* numerator, [Out] Int32* denominator);
            internal static GetMscRateOML wglGetMscRateOML;
            [SuppressUnmanagedCodeSecurity]
            internal delegate Int64 SwapBuffersMscOML(IntPtr hdc, Int64 target_msc, Int64 divisor, Int64 remainder);
            internal static SwapBuffersMscOML wglSwapBuffersMscOML;
            [SuppressUnmanagedCodeSecurity]
            internal delegate Int64 SwapLayerBuffersMscOML(IntPtr hdc, int fuPlanes, Int64 target_msc, Int64 divisor, Int64 remainder);
            internal static SwapLayerBuffersMscOML wglSwapLayerBuffersMscOML;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate Boolean WaitForMscOML(IntPtr hdc, Int64 target_msc, Int64 divisor, Int64 remainder, [Out] Int64* ust, [Out] Int64* msc, [Out] Int64* sbc);
            internal static WaitForMscOML wglWaitForMscOML;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate Boolean WaitForSbcOML(IntPtr hdc, Int64 target_sbc, [Out] Int64* ust, [Out] Int64* msc, [Out] Int64* sbc);
            internal static WaitForSbcOML wglWaitForSbcOML;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate Boolean GetDigitalVideoParametersI3D(IntPtr hDC, int iAttribute, [Out] int* piValue);
            internal static GetDigitalVideoParametersI3D wglGetDigitalVideoParametersI3D;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate Boolean SetDigitalVideoParametersI3D(IntPtr hDC, int iAttribute, int* piValue);
            internal static SetDigitalVideoParametersI3D wglSetDigitalVideoParametersI3D;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate Boolean GetGammaTableParametersI3D(IntPtr hDC, int iAttribute, [Out] int* piValue);
            internal static GetGammaTableParametersI3D wglGetGammaTableParametersI3D;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate Boolean SetGammaTableParametersI3D(IntPtr hDC, int iAttribute, int* piValue);
            internal static SetGammaTableParametersI3D wglSetGammaTableParametersI3D;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate Boolean GetGammaTableI3D(IntPtr hDC, int iEntries, [Out] UInt16* puRed, [Out] UInt16* puGreen, [Out] UInt16* puBlue);
            internal static GetGammaTableI3D wglGetGammaTableI3D;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate Boolean SetGammaTableI3D(IntPtr hDC, int iEntries, UInt16* puRed, UInt16* puGreen, UInt16* puBlue);
            internal static SetGammaTableI3D wglSetGammaTableI3D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate Boolean EnableGenlockI3D(IntPtr hDC);
            internal static EnableGenlockI3D wglEnableGenlockI3D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate Boolean DisableGenlockI3D(IntPtr hDC);
            internal static DisableGenlockI3D wglDisableGenlockI3D;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate Boolean IsEnabledGenlockI3D(IntPtr hDC, [Out] Boolean* pFlag);
            internal static IsEnabledGenlockI3D wglIsEnabledGenlockI3D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate Boolean GenlockSourceI3D(IntPtr hDC, UInt32 uSource);
            internal static GenlockSourceI3D wglGenlockSourceI3D;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate Boolean GetGenlockSourceI3D(IntPtr hDC, [Out] UInt32* uSource);
            internal static GetGenlockSourceI3D wglGetGenlockSourceI3D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate Boolean GenlockSourceEdgeI3D(IntPtr hDC, UInt32 uEdge);
            internal static GenlockSourceEdgeI3D wglGenlockSourceEdgeI3D;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate Boolean GetGenlockSourceEdgeI3D(IntPtr hDC, [Out] UInt32* uEdge);
            internal static GetGenlockSourceEdgeI3D wglGetGenlockSourceEdgeI3D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate Boolean GenlockSampleRateI3D(IntPtr hDC, UInt32 uRate);
            internal static GenlockSampleRateI3D wglGenlockSampleRateI3D;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate Boolean GetGenlockSampleRateI3D(IntPtr hDC, [Out] UInt32* uRate);
            internal static GetGenlockSampleRateI3D wglGetGenlockSampleRateI3D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate Boolean GenlockSourceDelayI3D(IntPtr hDC, UInt32 uDelay);
            internal static GenlockSourceDelayI3D wglGenlockSourceDelayI3D;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate Boolean GetGenlockSourceDelayI3D(IntPtr hDC, [Out] UInt32* uDelay);
            internal static GetGenlockSourceDelayI3D wglGetGenlockSourceDelayI3D;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate Boolean QueryGenlockMaxSourceDelayI3D(IntPtr hDC, [Out] UInt32* uMaxLineDelay, [Out] UInt32* uMaxPixelDelay);
            internal static QueryGenlockMaxSourceDelayI3D wglQueryGenlockMaxSourceDelayI3D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate IntPtr CreateImageBufferI3D(IntPtr hDC, Int32 dwSize, UInt32 uFlags);
            internal static CreateImageBufferI3D wglCreateImageBufferI3D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate Boolean DestroyImageBufferI3D(IntPtr hDC, IntPtr pAddress);
            internal static DestroyImageBufferI3D wglDestroyImageBufferI3D;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate Boolean AssociateImageBufferEventsI3D(IntPtr hDC, IntPtr* pEvent, IntPtr pAddress, Int32* pSize, UInt32 count);
            internal static AssociateImageBufferEventsI3D wglAssociateImageBufferEventsI3D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate Boolean ReleaseImageBufferEventsI3D(IntPtr hDC, IntPtr pAddress, UInt32 count);
            internal static ReleaseImageBufferEventsI3D wglReleaseImageBufferEventsI3D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate Boolean EnableFrameLockI3D();
            internal static EnableFrameLockI3D wglEnableFrameLockI3D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate Boolean DisableFrameLockI3D();
            internal static DisableFrameLockI3D wglDisableFrameLockI3D;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate Boolean IsEnabledFrameLockI3D([Out] Boolean* pFlag);
            internal static IsEnabledFrameLockI3D wglIsEnabledFrameLockI3D;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate Boolean QueryFrameLockMasterI3D([Out] Boolean* pFlag);
            internal static QueryFrameLockMasterI3D wglQueryFrameLockMasterI3D;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate Boolean GetFrameUsageI3D([Out] float* pUsage);
            internal static GetFrameUsageI3D wglGetFrameUsageI3D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate Boolean BeginFrameTrackingI3D();
            internal static BeginFrameTrackingI3D wglBeginFrameTrackingI3D;
            [SuppressUnmanagedCodeSecurity]
            internal delegate Boolean EndFrameTrackingI3D();
            internal static EndFrameTrackingI3D wglEndFrameTrackingI3D;
            [SuppressUnmanagedCodeSecurity]
            internal unsafe delegate Boolean QueryFrameTrackingI3D([Out] Int32* pFrameCount, [Out] Int32* pMissedFrames, [Out] float* pLastMissedUsage);
            internal static QueryFrameTrackingI3D wglQueryFrameTrackingI3D;
        }
    }
    #pragma warning restore 0649
}
