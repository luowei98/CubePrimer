// ReSharper disable InconsistentNaming

using System;
using System.Runtime.InteropServices;

namespace RobertLw.OpenGL.Windows
{
    public static partial class Wgl
    {
        public static
            IntPtr wglCreateContext(IntPtr hDc)
        {
            return Delegates.wglCreateContext(hDc);
        }

        public static
            bool wglDeleteContext(IntPtr oldContext)
        {
            return Delegates.wglDeleteContext(oldContext);
        }

        public static
            IntPtr wglGetCurrentContext()
        {
            return Delegates.wglGetCurrentContext();
        }

        public static
            bool wglMakeCurrent(IntPtr hDc, IntPtr newContext)
        {
            return Delegates.wglMakeCurrent(hDc, newContext);
        }

        [CLSCompliant(false)]
        public static
        bool wglCopyContext(IntPtr hglrcSrc, IntPtr hglrcDst, uint mask)
        {
            return Delegates.wglCopyContext(hglrcSrc, hglrcDst, mask);
        }

        public static
            bool wglCopyContext(IntPtr hglrcSrc, IntPtr hglrcDst, int mask)
        {
            return Delegates.wglCopyContext(hglrcSrc, hglrcDst, (uint) mask);
        }

        public static
            int wglChoosePixelFormat(IntPtr hDc, Gdi.PixelFormatDescriptor[] pPfd)
        {
            unsafe
            {
                fixed (Gdi.PixelFormatDescriptor* pPfd_ptr = pPfd)
                {
                    return Delegates.wglChoosePixelFormat(hDc, pPfd_ptr);
                }
            }
        }

        public static
            int wglChoosePixelFormat(IntPtr hDc, ref Gdi.PixelFormatDescriptor pPfd)
        {
            unsafe
            {
                fixed (Gdi.PixelFormatDescriptor* pPfd_ptr = &pPfd)
                {
                    return Delegates.wglChoosePixelFormat(hDc, pPfd_ptr);
                }
            }
        }

        [CLSCompliant(false)]
        public static
        int wglChoosePixelFormat(IntPtr hDc, IntPtr pPfd)
        {
            unsafe
            {
                return Delegates.wglChoosePixelFormat(hDc, (Gdi.PixelFormatDescriptor*) pPfd);
            }
        }

        [CLSCompliant(false)]
        public static
        int wglDescribePixelFormat(IntPtr hdc, int ipfd, uint cjpfd, Gdi.PixelFormatDescriptor[] ppfd)
        {
            unsafe
            {
                fixed (Gdi.PixelFormatDescriptor* ppfd_ptr = ppfd)
                {
                    return Delegates.wglDescribePixelFormat(hdc, ipfd, cjpfd, ppfd_ptr);
                }
            }
        }

        public static
            int wglDescribePixelFormat(IntPtr hdc, int ipfd, int cjpfd, Gdi.PixelFormatDescriptor[] ppfd)
        {
            unsafe
            {
                fixed (Gdi.PixelFormatDescriptor* ppfd_ptr = ppfd)
                {
                    return Delegates.wglDescribePixelFormat(hdc, ipfd, (uint) cjpfd, ppfd_ptr);
                }
            }
        }

        [CLSCompliant(false)]
        public static
        int wglDescribePixelFormat(IntPtr hdc, int ipfd, uint cjpfd, ref Gdi.PixelFormatDescriptor ppfd)
        {
            unsafe
            {
                fixed (Gdi.PixelFormatDescriptor* ppfd_ptr = &ppfd)
                {
                    return Delegates.wglDescribePixelFormat(hdc, ipfd, cjpfd, ppfd_ptr);
                }
            }
        }

        public static
            int wglDescribePixelFormat(IntPtr hdc, int ipfd, int cjpfd, ref Gdi.PixelFormatDescriptor ppfd)
        {
            unsafe
            {
                fixed (Gdi.PixelFormatDescriptor* ppfd_ptr = &ppfd)
                {
                    return Delegates.wglDescribePixelFormat(hdc, ipfd, (uint) cjpfd, ppfd_ptr);
                }
            }
        }

        [CLSCompliant(false)]
        public static
        int wglDescribePixelFormat(IntPtr hdc, int ipfd, uint cjpfd, IntPtr ppfd)
        {
            unsafe
            {
                return Delegates.wglDescribePixelFormat(hdc, ipfd, cjpfd, (Gdi.PixelFormatDescriptor*) ppfd);
            }
        }

        [CLSCompliant(false)]
        public static
        int wglDescribePixelFormat(IntPtr hdc, int ipfd, int cjpfd, IntPtr ppfd)
        {
            unsafe
            {
                return Delegates.wglDescribePixelFormat(hdc, ipfd, (uint) cjpfd, (Gdi.PixelFormatDescriptor*) ppfd);
            }
        }

        public static
            IntPtr wglGetCurrentDC()
        {
            return Delegates.wglGetCurrentDC();
        }

        public static
            IntPtr wglGetDefaultProcAddress(string lpszProc)
        {
            return Delegates.wglGetDefaultProcAddress(lpszProc);
        }

        public static
            IntPtr wglGetProcAddress(string lpszProc)
        {
            return Delegates.wglGetProcAddress(lpszProc);
        }

        public static
            int wglGetPixelFormat(IntPtr hdc)
        {
            return Delegates.wglGetPixelFormat(hdc);
        }

        public static
            bool wglSetPixelFormat(IntPtr hdc, int ipfd, Gdi.PixelFormatDescriptor[] ppfd)
        {
            unsafe
            {
                fixed (Gdi.PixelFormatDescriptor* ppfd_ptr = ppfd)
                {
                    return Delegates.wglSetPixelFormat(hdc, ipfd, ppfd_ptr);
                }
            }
        }

        public static
            bool wglSetPixelFormat(IntPtr hdc, int ipfd, ref Gdi.PixelFormatDescriptor ppfd)
        {
            unsafe
            {
                fixed (Gdi.PixelFormatDescriptor* ppfd_ptr = &ppfd)
                {
                    return Delegates.wglSetPixelFormat(hdc, ipfd, ppfd_ptr);
                }
            }
        }

        [CLSCompliant(false)]
        public static
        bool wglSetPixelFormat(IntPtr hdc, int ipfd, IntPtr ppfd)
        {
            unsafe
            {
                return Delegates.wglSetPixelFormat(hdc, ipfd, (Gdi.PixelFormatDescriptor*) ppfd);
            }
        }

        public static
            bool wglSwapBuffers(IntPtr hdc)
        {
            return Delegates.wglSwapBuffers(hdc);
        }

        public static
            bool wglShareLists(IntPtr hrcSrvShare, IntPtr hrcSrvSource)
        {
            return Delegates.wglShareLists(hrcSrvShare, hrcSrvSource);
        }

        public static
            IntPtr wglCreateLayerContext(IntPtr hDc, int level)
        {
            return Delegates.wglCreateLayerContext(hDc, level);
        }

        [CLSCompliant(false)]
        public static
        bool wglDescribeLayerPlane(IntPtr hDc, int pixelFormat, int layerPlane, uint nBytes,
            Gdi.LayerPlaneDescriptor[] plpd)
        {
            unsafe
            {
                fixed (Gdi.LayerPlaneDescriptor* plpd_ptr = plpd)
                {
                    return Delegates.wglDescribeLayerPlane(hDc, pixelFormat, layerPlane, nBytes, plpd_ptr);
                }
            }
        }

        public static
            bool wglDescribeLayerPlane(IntPtr hDc, int pixelFormat, int layerPlane, int nBytes,
                Gdi.LayerPlaneDescriptor[] plpd)
        {
            unsafe
            {
                fixed (Gdi.LayerPlaneDescriptor* plpd_ptr = plpd)
                {
                    return Delegates.wglDescribeLayerPlane(hDc, pixelFormat, layerPlane, (uint) nBytes, plpd_ptr);
                }
            }
        }

        [CLSCompliant(false)]
        public static
        bool wglDescribeLayerPlane(IntPtr hDc, int pixelFormat, int layerPlane, uint nBytes,
            ref Gdi.LayerPlaneDescriptor plpd)
        {
            unsafe
            {
                fixed (Gdi.LayerPlaneDescriptor* plpd_ptr = &plpd)
                {
                    return Delegates.wglDescribeLayerPlane(hDc, pixelFormat, layerPlane, nBytes, plpd_ptr);
                }
            }
        }

        public static
            bool wglDescribeLayerPlane(IntPtr hDc, int pixelFormat, int layerPlane, int nBytes,
                ref Gdi.LayerPlaneDescriptor plpd)
        {
            unsafe
            {
                fixed (Gdi.LayerPlaneDescriptor* plpd_ptr = &plpd)
                {
                    return Delegates.wglDescribeLayerPlane(hDc, pixelFormat, layerPlane, (uint) nBytes, plpd_ptr);
                }
            }
        }

        [CLSCompliant(false)]
        public static
        bool wglDescribeLayerPlane(IntPtr hDc, int pixelFormat, int layerPlane, uint nBytes, IntPtr plpd)
        {
            unsafe
            {
                return Delegates.wglDescribeLayerPlane(hDc, pixelFormat, layerPlane, nBytes,
                    (Gdi.LayerPlaneDescriptor*) plpd);
            }
        }

        [CLSCompliant(false)]
        public static
        bool wglDescribeLayerPlane(IntPtr hDc, int pixelFormat, int layerPlane, int nBytes, IntPtr plpd)
        {
            unsafe
            {
                return Delegates.wglDescribeLayerPlane(hDc, pixelFormat, layerPlane, (uint) nBytes,
                    (Gdi.LayerPlaneDescriptor*) plpd);
            }
        }

        public static
            int wglSetLayerPaletteEntries(IntPtr hdc, int iLayerPlane, int iStart, int cEntries, int[] pcr)
        {
            unsafe
            {
                fixed (int* pcr_ptr = pcr)
                {
                    return Delegates.wglSetLayerPaletteEntries(hdc, iLayerPlane, iStart, cEntries, pcr_ptr);
                }
            }
        }

        public static
            int wglSetLayerPaletteEntries(IntPtr hdc, int iLayerPlane, int iStart, int cEntries, ref int pcr)
        {
            unsafe
            {
                fixed (int* pcr_ptr = &pcr)
                {
                    return Delegates.wglSetLayerPaletteEntries(hdc, iLayerPlane, iStart, cEntries, pcr_ptr);
                }
            }
        }

        [CLSCompliant(false)]
        public static
        int wglSetLayerPaletteEntries(IntPtr hdc, int iLayerPlane, int iStart, int cEntries, IntPtr pcr)
        {
            unsafe
            {
                return Delegates.wglSetLayerPaletteEntries(hdc, iLayerPlane, iStart, cEntries, (int*) pcr);
            }
        }

        public static
            int wglGetLayerPaletteEntries(IntPtr hdc, int iLayerPlane, int iStart, int cEntries, int[] pcr)
        {
            unsafe
            {
                fixed (int* pcr_ptr = pcr)
                {
                    return Delegates.wglGetLayerPaletteEntries(hdc, iLayerPlane, iStart, cEntries, pcr_ptr);
                }
            }
        }

        public static
            int wglGetLayerPaletteEntries(IntPtr hdc, int iLayerPlane, int iStart, int cEntries, ref int pcr)
        {
            unsafe
            {
                fixed (int* pcr_ptr = &pcr)
                {
                    return Delegates.wglGetLayerPaletteEntries(hdc, iLayerPlane, iStart, cEntries, pcr_ptr);
                }
            }
        }

        [CLSCompliant(false)]
        public static
        int wglGetLayerPaletteEntries(IntPtr hdc, int iLayerPlane, int iStart, int cEntries, IntPtr pcr)
        {
            unsafe
            {
                return Delegates.wglGetLayerPaletteEntries(hdc, iLayerPlane, iStart, cEntries, (int*) pcr);
            }
        }

        public static
            bool wglRealizeLayerPalette(IntPtr hdc, int iLayerPlane, bool bRealize)
        {
            return Delegates.wglRealizeLayerPalette(hdc, iLayerPlane, bRealize);
        }

        [CLSCompliant(false)]
        public static
        bool wglSwapLayerBuffers(IntPtr hdc, uint fuFlags)
        {
            return Delegates.wglSwapLayerBuffers(hdc, fuFlags);
        }

        public static
            bool wglSwapLayerBuffers(IntPtr hdc, int fuFlags)
        {
            return Delegates.wglSwapLayerBuffers(hdc, (uint)fuFlags);
        }

        public static
            bool wglUseFontBitmapsA(IntPtr hDC, int first, int count, int listBase)
        {
            return Delegates.wglUseFontBitmapsA(hDC, first, count, listBase);
        }

        public static
            bool wglUseFontBitmapsW(IntPtr hDC, int first, int count, int listBase)
        {
            return Delegates.wglUseFontBitmapsW(hDC, first, count, listBase);
        }

        public static
            bool wglUseFontOutlinesA(IntPtr hDC, int first, int count, int listBase, float thickness, float deviation,
                int fontMode, Gdi.GlyphMetricsFloat[] glyphMetrics)
        {
            unsafe
            {
                fixed (Gdi.GlyphMetricsFloat* glyphMetrics_ptr = glyphMetrics)
                {
                    return Delegates.wglUseFontOutlinesA(hDC, first, count, listBase, thickness, deviation, fontMode,
                        glyphMetrics_ptr);
                }
            }
        }

        public static
            bool wglUseFontOutlinesA(IntPtr hDC, int first, int count, int listBase, float thickness, float deviation,
                int fontMode, ref Gdi.GlyphMetricsFloat glyphMetrics)
        {
            unsafe
            {
                fixed (Gdi.GlyphMetricsFloat* glyphMetrics_ptr = &glyphMetrics)
                {
                    return Delegates.wglUseFontOutlinesA(hDC, first, count, listBase, thickness, deviation, fontMode,
                        glyphMetrics_ptr);
                }
            }
        }

        [CLSCompliant(false)]
        public static
        bool wglUseFontOutlinesA(IntPtr hDC, int first, int count, int listBase, float thickness, float deviation,
            int fontMode, IntPtr glyphMetrics)
        {
            unsafe
            {
                return Delegates.wglUseFontOutlinesA(hDC, first, count, listBase, thickness, deviation, fontMode,
                    (Gdi.GlyphMetricsFloat*) glyphMetrics);
            }
        }

        public static
            bool wglUseFontOutlinesW(IntPtr hDC, int first, int count, int listBase, float thickness, float deviation,
                int fontMode, Gdi.GlyphMetricsFloat[] glyphMetrics)
        {
            unsafe
            {
                fixed (Gdi.GlyphMetricsFloat* glyphMetrics_ptr = glyphMetrics)
                {
                    return Delegates.wglUseFontOutlinesW(hDC, first, count, listBase, thickness, deviation, fontMode,
                        glyphMetrics_ptr);
                }
            }
        }

        public static
            bool wglUseFontOutlinesW(IntPtr hDC, int first, int count, int listBase, float thickness, float deviation,
                int fontMode, ref Gdi.GlyphMetricsFloat glyphMetrics)
        {
            unsafe
            {
                fixed (Gdi.GlyphMetricsFloat* glyphMetrics_ptr = &glyphMetrics)
                {
                    return Delegates.wglUseFontOutlinesW(hDC, first, count, listBase, thickness, deviation, fontMode,
                        glyphMetrics_ptr);
                }
            }
        }

        [CLSCompliant(false)]
        public static
        bool wglUseFontOutlinesW(IntPtr hDC, int first, int count, int listBase, float thickness, float deviation,
            int fontMode, IntPtr glyphMetrics)
        {
            unsafe
            {
                return Delegates.wglUseFontOutlinesW(hDC, first, count, listBase, thickness, deviation, fontMode,
                    (Gdi.GlyphMetricsFloat*) glyphMetrics);
            }
        }

        [CLSCompliant(false)]
        public static
        IntPtr wglCreateBufferRegionARB(IntPtr hDC, int iLayerPlane, uint uType)
        {
            return Delegates.wglCreateBufferRegionARB(hDC, iLayerPlane, uType);
        }

        public static
            IntPtr wglCreateBufferRegionARB(IntPtr hDC, int iLayerPlane, int uType)
        {
            return Delegates.wglCreateBufferRegionARB(hDC, iLayerPlane, (uint) uType);
        }

        public static
            void wglDeleteBufferRegionARB(IntPtr hRegion)
        {
            Delegates.wglDeleteBufferRegionARB(hRegion);
        }

        public static
            bool wglSaveBufferRegionARB(IntPtr hRegion, int x, int y, int width, int height)
        {
            return Delegates.wglSaveBufferRegionARB(hRegion, x, y, width, height);
        }

        public static
            bool wglRestoreBufferRegionARB(IntPtr hRegion, int x, int y, int width, int height, int xSrc, int ySrc)
        {
            return Delegates.wglRestoreBufferRegionARB(hRegion, x, y, width, height, xSrc, ySrc);
        }

        public static
            string wglGetExtensionsStringARB(IntPtr hdc)
        {
            return Marshal.PtrToStringAnsi(Delegates.wglGetExtensionsStringARB(hdc));
        }

        [CLSCompliant(false)]
        public static
        bool wglGetPixelFormatAttribivARB(IntPtr hdc, int iPixelFormat, int iLayerPlane, uint nAttributes,
            int[] piAttributes, [Out] int[] piValues)
        {
            unsafe
            {
                fixed (int* piAttributes_ptr = piAttributes)
                fixed (int* piValues_ptr = piValues)
                {
                    return Delegates.wglGetPixelFormatAttribivARB(hdc, iPixelFormat, iLayerPlane, nAttributes,
                        piAttributes_ptr, piValues_ptr);
                }
            }
        }

        public static
            bool wglGetPixelFormatAttribivARB(IntPtr hdc, int iPixelFormat, int iLayerPlane, int nAttributes,
                int[] piAttributes, [Out] int[] piValues)
        {
            unsafe
            {
                fixed (int* piAttributes_ptr = piAttributes)
                fixed (int* piValues_ptr = piValues)
                {
                    return Delegates.wglGetPixelFormatAttribivARB(hdc, iPixelFormat, iLayerPlane, (uint) nAttributes,
                        piAttributes_ptr, piValues_ptr);
                }
            }
        }

        [CLSCompliant(false)]
        public static
        bool wglGetPixelFormatAttribivARB(IntPtr hdc, int iPixelFormat, int iLayerPlane, uint nAttributes,
            ref int piAttributes, [Out] out int piValues)
        {
            unsafe
            {
                fixed (int* piAttributes_ptr = &piAttributes)
                fixed (int* piValues_ptr = &piValues)
                {
                    var retval = Delegates.wglGetPixelFormatAttribivARB(hdc, iPixelFormat, iLayerPlane, nAttributes,
                        piAttributes_ptr, piValues_ptr);
                    piValues = *piValues_ptr;
                    return retval;
                }
            }
        }

        public static
            bool wglGetPixelFormatAttribivARB(IntPtr hdc, int iPixelFormat, int iLayerPlane, int nAttributes,
                ref int piAttributes, [Out] out int piValues)
        {
            unsafe
            {
                fixed (int* piAttributes_ptr = &piAttributes)
                fixed (int* piValues_ptr = &piValues)
                {
                    var retval = Delegates.wglGetPixelFormatAttribivARB(hdc, iPixelFormat, iLayerPlane,
                        (uint) nAttributes, piAttributes_ptr, piValues_ptr);
                    piValues = *piValues_ptr;
                    return retval;
                }
            }
        }

        [CLSCompliant(false)]
        public static
        bool wglGetPixelFormatAttribivARB(IntPtr hdc, int iPixelFormat, int iLayerPlane, uint nAttributes,
            IntPtr piAttributes, [Out] IntPtr piValues)
        {
            unsafe
            {
                return Delegates.wglGetPixelFormatAttribivARB(hdc, iPixelFormat, iLayerPlane, nAttributes,
                    (int*) piAttributes, (int*) piValues);
            }
        }

        [CLSCompliant(false)]
        public static
        bool wglGetPixelFormatAttribivARB(IntPtr hdc, int iPixelFormat, int iLayerPlane, int nAttributes,
            IntPtr piAttributes, [Out] IntPtr piValues)
        {
            unsafe
            {
                return Delegates.wglGetPixelFormatAttribivARB(hdc, iPixelFormat, iLayerPlane, (uint) nAttributes,
                    (int*) piAttributes, (int*) piValues);
            }
        }

        [CLSCompliant(false)]
        public static
        bool wglGetPixelFormatAttribfvARB(IntPtr hdc, int iPixelFormat, int iLayerPlane, uint nAttributes,
            int[] piAttributes, [Out] float[] pfValues)
        {
            unsafe
            {
                fixed (int* piAttributes_ptr = piAttributes)
                fixed (float* pfValues_ptr = pfValues)
                {
                    return Delegates.wglGetPixelFormatAttribfvARB(hdc, iPixelFormat, iLayerPlane, nAttributes,
                        piAttributes_ptr, pfValues_ptr);
                }
            }
        }

        public static
            bool wglGetPixelFormatAttribfvARB(IntPtr hdc, int iPixelFormat, int iLayerPlane, int nAttributes,
                int[] piAttributes, [Out] float[] pfValues)
        {
            unsafe
            {
                fixed (int* piAttributes_ptr = piAttributes)
                fixed (float* pfValues_ptr = pfValues)
                {
                    return Delegates.wglGetPixelFormatAttribfvARB(hdc, iPixelFormat, iLayerPlane, (uint) nAttributes,
                        piAttributes_ptr, pfValues_ptr);
                }
            }
        }

        [CLSCompliant(false)]
        public static
        bool wglGetPixelFormatAttribfvARB(IntPtr hdc, int iPixelFormat, int iLayerPlane, uint nAttributes,
            ref int piAttributes, [Out] out float pfValues)
        {
            unsafe
            {
                fixed (int* piAttributes_ptr = &piAttributes)
                fixed (float* pfValues_ptr = &pfValues)
                {
                    var retval = Delegates.wglGetPixelFormatAttribfvARB(hdc, iPixelFormat, iLayerPlane, nAttributes,
                        piAttributes_ptr, pfValues_ptr);
                    pfValues = *pfValues_ptr;
                    return retval;
                }
            }
        }

        public static
            bool wglGetPixelFormatAttribfvARB(IntPtr hdc, int iPixelFormat, int iLayerPlane, int nAttributes,
                ref int piAttributes, [Out] out float pfValues)
        {
            unsafe
            {
                fixed (int* piAttributes_ptr = &piAttributes)
                fixed (float* pfValues_ptr = &pfValues)
                {
                    var retval = Delegates.wglGetPixelFormatAttribfvARB(hdc, iPixelFormat, iLayerPlane,
                        (uint) nAttributes, piAttributes_ptr, pfValues_ptr);
                    pfValues = *pfValues_ptr;
                    return retval;
                }
            }
        }

        [CLSCompliant(false)]
        public static
        bool wglGetPixelFormatAttribfvARB(IntPtr hdc, int iPixelFormat, int iLayerPlane, uint nAttributes,
            IntPtr piAttributes, [Out] IntPtr pfValues)
        {
            unsafe
            {
                return Delegates.wglGetPixelFormatAttribfvARB(hdc, iPixelFormat, iLayerPlane, nAttributes,
                    (int*) piAttributes, (float*) pfValues);
            }
        }

        [CLSCompliant(false)]
        public static
        bool wglGetPixelFormatAttribfvARB(IntPtr hdc, int iPixelFormat, int iLayerPlane, int nAttributes,
            IntPtr piAttributes, [Out] IntPtr pfValues)
        {
            unsafe
            {
                return Delegates.wglGetPixelFormatAttribfvARB(hdc, iPixelFormat, iLayerPlane, (uint) nAttributes,
                    (int*) piAttributes, (float*) pfValues);
            }
        }

        [CLSCompliant(false)]
        public static
        bool wglChoosePixelFormatARB(IntPtr hdc, int[] piAttribIList, float[] pfAttribFList, uint nMaxFormats,
            [Out] int[] piFormats, [Out] uint[] nNumFormats)
        {
            unsafe
            {
                fixed (int* piAttribIList_ptr = piAttribIList)
                fixed (float* pfAttribFList_ptr = pfAttribFList)
                fixed (int* piFormats_ptr = piFormats)
                fixed (uint* nNumFormats_ptr = nNumFormats)
                {
                    return Delegates.wglChoosePixelFormatARB(hdc, piAttribIList_ptr, pfAttribFList_ptr, nMaxFormats,
                        piFormats_ptr, nNumFormats_ptr);
                }
            }
        }

        public static
            bool wglChoosePixelFormatARB(IntPtr hdc, int[] piAttribIList, float[] pfAttribFList, int nMaxFormats,
                [Out] int[] piFormats, [Out] int[] nNumFormats)
        {
            unsafe
            {
                fixed (int* piAttribIList_ptr = piAttribIList)
                fixed (float* pfAttribFList_ptr = pfAttribFList)
                fixed (int* piFormats_ptr = piFormats)
                fixed (int* nNumFormats_ptr = nNumFormats)
                {
                    return Delegates.wglChoosePixelFormatARB(hdc, piAttribIList_ptr, pfAttribFList_ptr,
                        (uint) nMaxFormats, piFormats_ptr, (uint*) nNumFormats_ptr);
                }
            }
        }

        [CLSCompliant(false)]
        public static
        bool wglChoosePixelFormatARB(IntPtr hdc, ref int piAttribIList, ref float pfAttribFList, uint nMaxFormats,
            [Out] out int piFormats, [Out] out uint nNumFormats)
        {
            unsafe
            {
                fixed (int* piAttribIList_ptr = &piAttribIList)
                fixed (float* pfAttribFList_ptr = &pfAttribFList)
                fixed (int* piFormats_ptr = &piFormats)
                fixed (uint* nNumFormats_ptr = &nNumFormats)
                {
                    var retval = Delegates.wglChoosePixelFormatARB(hdc, piAttribIList_ptr, pfAttribFList_ptr,
                        nMaxFormats, piFormats_ptr, nNumFormats_ptr);
                    piFormats = *piFormats_ptr;
                    nNumFormats = *nNumFormats_ptr;
                    return retval;
                }
            }
        }

        public static
            bool wglChoosePixelFormatARB(IntPtr hdc, ref int piAttribIList, ref float pfAttribFList, int nMaxFormats,
                [Out] out int piFormats, [Out] out int nNumFormats)
        {
            unsafe
            {
                fixed (int* piAttribIList_ptr = &piAttribIList)
                fixed (float* pfAttribFList_ptr = &pfAttribFList)
                fixed (int* piFormats_ptr = &piFormats)
                fixed (int* nNumFormats_ptr = &nNumFormats)
                {
                    var retval = Delegates.wglChoosePixelFormatARB(hdc, piAttribIList_ptr, pfAttribFList_ptr,
                        (uint) nMaxFormats, piFormats_ptr, (uint*) nNumFormats_ptr);
                    piFormats = *piFormats_ptr;
                    nNumFormats = *nNumFormats_ptr;
                    return retval;
                }
            }
        }

        [CLSCompliant(false)]
        public static
        bool wglChoosePixelFormatARB(IntPtr hdc, IntPtr piAttribIList, IntPtr pfAttribFList, uint nMaxFormats,
            [Out] IntPtr piFormats, [Out] IntPtr nNumFormats)
        {
            unsafe
            {
                return Delegates.wglChoosePixelFormatARB(hdc, (int*) piAttribIList, (float*) pfAttribFList, nMaxFormats,
                    (int*) piFormats, (uint*) nNumFormats);
            }
        }

        public static
            bool wglChoosePixelFormatARB(IntPtr hdc, IntPtr piAttribIList, IntPtr pfAttribFList, int nMaxFormats,
                [Out] IntPtr piFormats, [Out] IntPtr nNumFormats)
        {
            unsafe
            {
                return Delegates.wglChoosePixelFormatARB(hdc, (int*) piAttribIList, (float*) pfAttribFList,
                    (uint) nMaxFormats, (int*) piFormats, (uint*) nNumFormats);
            }
        }

        public static
            bool wglMakeContextCurrentARB(IntPtr hDrawDC, IntPtr hReadDC, IntPtr hglrc)
        {
            return Delegates.wglMakeContextCurrentARB(hDrawDC, hReadDC, hglrc);
        }

        public static
            IntPtr wglGetCurrentReadDCARB()
        {
            return Delegates.wglGetCurrentReadDCARB();
        }

        public static
            IntPtr wglCreatePbufferARB(IntPtr hDC, int iPixelFormat, int iWidth, int iHeight, int[] piAttribList)
        {
            unsafe
            {
                fixed (int* piAttribList_ptr = piAttribList)
                {
                    return Delegates.wglCreatePbufferARB(hDC, iPixelFormat, iWidth, iHeight, piAttribList_ptr);
                }
            }
        }

        public static
            IntPtr wglCreatePbufferARB(IntPtr hDC, int iPixelFormat, int iWidth, int iHeight, ref int piAttribList)
        {
            unsafe
            {
                fixed (int* piAttribList_ptr = &piAttribList)
                {
                    return Delegates.wglCreatePbufferARB(hDC, iPixelFormat, iWidth, iHeight, piAttribList_ptr);
                }
            }
        }

        [CLSCompliant(false)]
        public static
        IntPtr wglCreatePbufferARB(IntPtr hDC, int iPixelFormat, int iWidth, int iHeight, IntPtr piAttribList)
        {
            unsafe
            {
                return Delegates.wglCreatePbufferARB(hDC, iPixelFormat, iWidth, iHeight, (int*) piAttribList);
            }
        }

        public static
            IntPtr wglGetPbufferDCARB(IntPtr hPbuffer)
        {
            return Delegates.wglGetPbufferDCARB(hPbuffer);
        }

        public static
            int wglReleasePbufferDCARB(IntPtr hPbuffer, IntPtr hDC)
        {
            return Delegates.wglReleasePbufferDCARB(hPbuffer, hDC);
        }

        public static
            bool wglDestroyPbufferARB(IntPtr hPbuffer)
        {
            return Delegates.wglDestroyPbufferARB(hPbuffer);
        }

        public static
            bool wglQueryPbufferARB(IntPtr hPbuffer, int iAttribute, [Out] int[] piValue)
        {
            unsafe
            {
                fixed (int* piValue_ptr = piValue)
                {
                    return Delegates.wglQueryPbufferARB(hPbuffer, iAttribute, piValue_ptr);
                }
            }
        }

        public static
            bool wglQueryPbufferARB(IntPtr hPbuffer, int iAttribute, [Out] out int piValue)
        {
            unsafe
            {
                fixed (int* piValue_ptr = &piValue)
                {
                    var retval = Delegates.wglQueryPbufferARB(hPbuffer, iAttribute, piValue_ptr);
                    piValue = *piValue_ptr;
                    return retval;
                }
            }
        }

        [CLSCompliant(false)]
        public static
        bool wglQueryPbufferARB(IntPtr hPbuffer, int iAttribute, [Out] IntPtr piValue)
        {
            unsafe
            {
                return Delegates.wglQueryPbufferARB(hPbuffer, iAttribute, (int*) piValue);
            }
        }

        public static
            bool wglBindTexImageARB(IntPtr hPbuffer, int iBuffer)
        {
            return Delegates.wglBindTexImageARB(hPbuffer, iBuffer);
        }

        public static
            bool wglReleaseTexImageARB(IntPtr hPbuffer, int iBuffer)
        {
            return Delegates.wglReleaseTexImageARB(hPbuffer, iBuffer);
        }

        public static
            bool wglSetPbufferAttribARB(IntPtr hPbuffer, int[] piAttribList)
        {
            unsafe
            {
                fixed (int* piAttribList_ptr = piAttribList)
                {
                    return Delegates.wglSetPbufferAttribARB(hPbuffer, piAttribList_ptr);
                }
            }
        }

        public static
            bool wglSetPbufferAttribARB(IntPtr hPbuffer, ref int piAttribList)
        {
            unsafe
            {
                fixed (int* piAttribList_ptr = &piAttribList)
                {
                    return Delegates.wglSetPbufferAttribARB(hPbuffer, piAttribList_ptr);
                }
            }
        }

        [CLSCompliant(false)]
        public static
        bool wglSetPbufferAttribARB(IntPtr hPbuffer, IntPtr piAttribList)
        {
            unsafe
            {
                return Delegates.wglSetPbufferAttribARB(hPbuffer, (int*) piAttribList);
            }
        }

        [CLSCompliant(false)]
        public static
        bool wglCreateDisplayColorTableEXT(ushort id)
        {
            return Delegates.wglCreateDisplayColorTableEXT(id);
        }

        public static
            bool wglCreateDisplayColorTableEXT(short id)
        {
            return Delegates.wglCreateDisplayColorTableEXT((ushort) id);
        }

        [CLSCompliant(false)]
        public static
        bool wglLoadDisplayColorTableEXT(ushort[] table, uint length)
        {
            unsafe
            {
                fixed (ushort* table_ptr = table)
                {
                    return Delegates.wglLoadDisplayColorTableEXT(table_ptr, length);
                }
            }
        }

        public static
            bool wglLoadDisplayColorTableEXT(short[] table, int length)
        {
            unsafe
            {
                fixed (short* table_ptr = table)
                {
                    return Delegates.wglLoadDisplayColorTableEXT((ushort*) table_ptr, (uint) length);
                }
            }
        }

        [CLSCompliant(false)]
        public static
        bool wglLoadDisplayColorTableEXT(ref ushort table, uint length)
        {
            unsafe
            {
                fixed (ushort* table_ptr = &table)
                {
                    return Delegates.wglLoadDisplayColorTableEXT(table_ptr, length);
                }
            }
        }

        public static
            bool wglLoadDisplayColorTableEXT(ref short table, int length)
        {
            unsafe
            {
                fixed (short* table_ptr = &table)
                {
                    return Delegates.wglLoadDisplayColorTableEXT((ushort*) table_ptr, (uint) length);
                }
            }
        }

        [CLSCompliant(false)]
        public static
        bool wglLoadDisplayColorTableEXT(IntPtr table, uint length)
        {
            unsafe
            {
                return Delegates.wglLoadDisplayColorTableEXT((ushort*) table, length);
            }
        }

        public static
            bool wglLoadDisplayColorTableEXT(IntPtr table, int length)
        {
            unsafe
            {
                return Delegates.wglLoadDisplayColorTableEXT((ushort*) table, (uint) length);
            }
        }

        [CLSCompliant(false)]
        public static
        bool wglBindDisplayColorTableEXT(ushort id)
        {
            return Delegates.wglBindDisplayColorTableEXT(id);
        }

        public static
            bool wglBindDisplayColorTableEXT(short id)
        {
            return Delegates.wglBindDisplayColorTableEXT((ushort) id);
        }

        [CLSCompliant(false)]
        public static
        void wglDestroyDisplayColorTableEXT(ushort id)
        {
            Delegates.wglDestroyDisplayColorTableEXT(id);
        }

        public static
            void wglDestroyDisplayColorTableEXT(short id)
        {
            Delegates.wglDestroyDisplayColorTableEXT((ushort) id);
        }

        public static
            string wglGetExtensionsStringEXT()
        {
            return Marshal.PtrToStringAnsi(Delegates.wglGetExtensionsStringEXT());
        }

        public static
            bool wglMakeContextCurrentEXT(IntPtr hDrawDC, IntPtr hReadDC, IntPtr hglrc)
        {
            return Delegates.wglMakeContextCurrentEXT(hDrawDC, hReadDC, hglrc);
        }

        public static
            IntPtr wglGetCurrentReadDCEXT()
        {
            return Delegates.wglGetCurrentReadDCEXT();
        }

        public static
            IntPtr wglCreatePbufferEXT(IntPtr hDC, int iPixelFormat, int iWidth, int iHeight, int[] piAttribList)
        {
            unsafe
            {
                fixed (int* piAttribList_ptr = piAttribList)
                {
                    return Delegates.wglCreatePbufferEXT(hDC, iPixelFormat, iWidth, iHeight, piAttribList_ptr);
                }
            }
        }

        public static
            IntPtr wglCreatePbufferEXT(IntPtr hDC, int iPixelFormat, int iWidth, int iHeight, ref int piAttribList)
        {
            unsafe
            {
                fixed (int* piAttribList_ptr = &piAttribList)
                {
                    return Delegates.wglCreatePbufferEXT(hDC, iPixelFormat, iWidth, iHeight, piAttribList_ptr);
                }
            }
        }

        [CLSCompliant(false)]
        public static
        IntPtr wglCreatePbufferEXT(IntPtr hDC, int iPixelFormat, int iWidth, int iHeight, IntPtr piAttribList)
        {
            unsafe
            {
                return Delegates.wglCreatePbufferEXT(hDC, iPixelFormat, iWidth, iHeight, (int*) piAttribList);
            }
        }

        public static
            IntPtr wglGetPbufferDCEXT(IntPtr hPbuffer)
        {
            return Delegates.wglGetPbufferDCEXT(hPbuffer);
        }

        public static
            int wglReleasePbufferDCEXT(IntPtr hPbuffer, IntPtr hDC)
        {
            return Delegates.wglReleasePbufferDCEXT(hPbuffer, hDC);
        }

        public static
            bool wglDestroyPbufferEXT(IntPtr hPbuffer)
        {
            return Delegates.wglDestroyPbufferEXT(hPbuffer);
        }

        public static
            bool wglQueryPbufferEXT(IntPtr hPbuffer, int iAttribute, [Out] int[] piValue)
        {
            unsafe
            {
                fixed (int* piValue_ptr = piValue)
                {
                    return Delegates.wglQueryPbufferEXT(hPbuffer, iAttribute, piValue_ptr);
                }
            }
        }

        public static
            bool wglQueryPbufferEXT(IntPtr hPbuffer, int iAttribute, [Out] out int piValue)
        {
            unsafe
            {
                fixed (int* piValue_ptr = &piValue)
                {
                    var retval = Delegates.wglQueryPbufferEXT(hPbuffer, iAttribute, piValue_ptr);
                    piValue = *piValue_ptr;
                    return retval;
                }
            }
        }

        [CLSCompliant(false)]
        public static
        bool wglQueryPbufferEXT(IntPtr hPbuffer, int iAttribute, [Out] IntPtr piValue)
        {
            unsafe
            {
                return Delegates.wglQueryPbufferEXT(hPbuffer, iAttribute, (int*) piValue);
            }
        }

        [CLSCompliant(false)]
        public static
        bool wglGetPixelFormatAttribivEXT(IntPtr hdc, int iPixelFormat, int iLayerPlane, uint nAttributes,
            [Out] int[] piAttributes, [Out] int[] piValues)
        {
            unsafe
            {
                fixed (int* piAttributes_ptr = piAttributes)
                fixed (int* piValues_ptr = piValues)
                {
                    return Delegates.wglGetPixelFormatAttribivEXT(hdc, iPixelFormat, iLayerPlane, nAttributes,
                        piAttributes_ptr, piValues_ptr);
                }
            }
        }

        public static
            bool wglGetPixelFormatAttribivEXT(IntPtr hdc, int iPixelFormat, int iLayerPlane, int nAttributes,
                [Out] int[] piAttributes, [Out] int[] piValues)
        {
            unsafe
            {
                fixed (int* piAttributes_ptr = piAttributes)
                fixed (int* piValues_ptr = piValues)
                {
                    return Delegates.wglGetPixelFormatAttribivEXT(hdc, iPixelFormat, iLayerPlane, (uint) nAttributes,
                        piAttributes_ptr, piValues_ptr);
                }
            }
        }

        [CLSCompliant(false)]
        public static
        bool wglGetPixelFormatAttribivEXT(IntPtr hdc, int iPixelFormat, int iLayerPlane, uint nAttributes,
            [Out] out int piAttributes, [Out] out int piValues)
        {
            unsafe
            {
                fixed (int* piAttributes_ptr = &piAttributes)
                fixed (int* piValues_ptr = &piValues)
                {
                    var retval = Delegates.wglGetPixelFormatAttribivEXT(hdc, iPixelFormat, iLayerPlane, nAttributes,
                        piAttributes_ptr, piValues_ptr);
                    piAttributes = *piAttributes_ptr;
                    piValues = *piValues_ptr;
                    return retval;
                }
            }
        }

        public static
            bool wglGetPixelFormatAttribivEXT(IntPtr hdc, int iPixelFormat, int iLayerPlane, int nAttributes,
                [Out] out int piAttributes, [Out] out int piValues)
        {
            unsafe
            {
                fixed (int* piAttributes_ptr = &piAttributes)
                fixed (int* piValues_ptr = &piValues)
                {
                    var retval = Delegates.wglGetPixelFormatAttribivEXT(hdc, iPixelFormat, iLayerPlane,
                        (uint) nAttributes, piAttributes_ptr, piValues_ptr);
                    piAttributes = *piAttributes_ptr;
                    piValues = *piValues_ptr;
                    return retval;
                }
            }
        }

        [CLSCompliant(false)]
        public static
        bool wglGetPixelFormatAttribivEXT(IntPtr hdc, int iPixelFormat, int iLayerPlane, uint nAttributes,
            [Out] IntPtr piAttributes, [Out] IntPtr piValues)
        {
            unsafe
            {
                return Delegates.wglGetPixelFormatAttribivEXT(hdc, iPixelFormat, iLayerPlane, nAttributes,
                    (int*) piAttributes, (int*) piValues);
            }
        }

        [CLSCompliant(false)]
        public static
        bool wglGetPixelFormatAttribivEXT(IntPtr hdc, int iPixelFormat, int iLayerPlane, int nAttributes,
            [Out] IntPtr piAttributes, [Out] IntPtr piValues)
        {
            unsafe
            {
                return Delegates.wglGetPixelFormatAttribivEXT(hdc, iPixelFormat, iLayerPlane, (uint) nAttributes,
                    (int*) piAttributes, (int*) piValues);
            }
        }

        [CLSCompliant(false)]
        public static
        bool wglGetPixelFormatAttribfvEXT(IntPtr hdc, int iPixelFormat, int iLayerPlane, uint nAttributes,
            [Out] int[] piAttributes, [Out] float[] pfValues)
        {
            unsafe
            {
                fixed (int* piAttributes_ptr = piAttributes)
                fixed (float* pfValues_ptr = pfValues)
                {
                    return Delegates.wglGetPixelFormatAttribfvEXT(hdc, iPixelFormat, iLayerPlane, nAttributes,
                        piAttributes_ptr, pfValues_ptr);
                }
            }
        }

        public static
            bool wglGetPixelFormatAttribfvEXT(IntPtr hdc, int iPixelFormat, int iLayerPlane, int nAttributes,
                [Out] int[] piAttributes, [Out] float[] pfValues)
        {
            unsafe
            {
                fixed (int* piAttributes_ptr = piAttributes)
                fixed (float* pfValues_ptr = pfValues)
                {
                    return Delegates.wglGetPixelFormatAttribfvEXT(hdc, iPixelFormat, iLayerPlane, (uint) nAttributes,
                        piAttributes_ptr, pfValues_ptr);
                }
            }
        }

        [CLSCompliant(false)]
        public static
        bool wglGetPixelFormatAttribfvEXT(IntPtr hdc, int iPixelFormat, int iLayerPlane, uint nAttributes,
            [Out] out int piAttributes, [Out] out float pfValues)
        {
            unsafe
            {
                fixed (int* piAttributes_ptr = &piAttributes)
                fixed (float* pfValues_ptr = &pfValues)
                {
                    var retval = Delegates.wglGetPixelFormatAttribfvEXT(hdc, iPixelFormat, iLayerPlane, nAttributes,
                        piAttributes_ptr, pfValues_ptr);
                    piAttributes = *piAttributes_ptr;
                    pfValues = *pfValues_ptr;
                    return retval;
                }
            }
        }

        public static
            bool wglGetPixelFormatAttribfvEXT(IntPtr hdc, int iPixelFormat, int iLayerPlane, int nAttributes,
                [Out] out int piAttributes, [Out] out float pfValues)
        {
            unsafe
            {
                fixed (int* piAttributes_ptr = &piAttributes)
                fixed (float* pfValues_ptr = &pfValues)
                {
                    var retval = Delegates.wglGetPixelFormatAttribfvEXT(hdc, iPixelFormat, iLayerPlane,
                        (uint) nAttributes, piAttributes_ptr, pfValues_ptr);
                    piAttributes = *piAttributes_ptr;
                    pfValues = *pfValues_ptr;
                    return retval;
                }
            }
        }

        [CLSCompliant(false)]
        public static
        bool wglGetPixelFormatAttribfvEXT(IntPtr hdc, int iPixelFormat, int iLayerPlane, uint nAttributes,
            [Out] IntPtr piAttributes, [Out] IntPtr pfValues)
        {
            unsafe
            {
                return Delegates.wglGetPixelFormatAttribfvEXT(hdc, iPixelFormat, iLayerPlane, nAttributes,
                    (int*) piAttributes, (float*) pfValues);
            }
        }

        [CLSCompliant(false)]
        public static
        bool wglGetPixelFormatAttribfvEXT(IntPtr hdc, int iPixelFormat, int iLayerPlane, int nAttributes,
            [Out] IntPtr piAttributes, [Out] IntPtr pfValues)
        {
            unsafe
            {
                return Delegates.wglGetPixelFormatAttribfvEXT(hdc, iPixelFormat, iLayerPlane, (uint) nAttributes,
                    (int*) piAttributes, (float*) pfValues);
            }
        }

        [CLSCompliant(false)]
        public static
        bool wglChoosePixelFormatEXT(IntPtr hdc, int[] piAttribIList, float[] pfAttribFList, uint nMaxFormats,
            [Out] int[] piFormats, [Out] uint[] nNumFormats)
        {
            unsafe
            {
                fixed (int* piAttribIList_ptr = piAttribIList)
                fixed (float* pfAttribFList_ptr = pfAttribFList)
                fixed (int* piFormats_ptr = piFormats)
                fixed (uint* nNumFormats_ptr = nNumFormats)
                {
                    return Delegates.wglChoosePixelFormatEXT(hdc, piAttribIList_ptr, pfAttribFList_ptr, nMaxFormats,
                        piFormats_ptr, nNumFormats_ptr);
                }
            }
        }

        public static
            bool wglChoosePixelFormatEXT(IntPtr hdc, int[] piAttribIList, float[] pfAttribFList, int nMaxFormats,
                [Out] int[] piFormats, [Out] int[] nNumFormats)
        {
            unsafe
            {
                fixed (int* piAttribIList_ptr = piAttribIList)
                fixed (float* pfAttribFList_ptr = pfAttribFList)
                fixed (int* piFormats_ptr = piFormats)
                fixed (int* nNumFormats_ptr = nNumFormats)
                {
                    return Delegates.wglChoosePixelFormatEXT(hdc, piAttribIList_ptr, pfAttribFList_ptr,
                        (uint) nMaxFormats, piFormats_ptr, (uint*) nNumFormats_ptr);
                }
            }
        }

        [CLSCompliant(false)]
        public static
        bool wglChoosePixelFormatEXT(IntPtr hdc, ref int piAttribIList, ref float pfAttribFList, uint nMaxFormats,
            [Out] out int piFormats, [Out] out uint nNumFormats)
        {
            unsafe
            {
                fixed (int* piAttribIList_ptr = &piAttribIList)
                fixed (float* pfAttribFList_ptr = &pfAttribFList)
                fixed (int* piFormats_ptr = &piFormats)
                fixed (uint* nNumFormats_ptr = &nNumFormats)
                {
                    var retval = Delegates.wglChoosePixelFormatEXT(hdc, piAttribIList_ptr, pfAttribFList_ptr,
                        nMaxFormats, piFormats_ptr, nNumFormats_ptr);
                    piFormats = *piFormats_ptr;
                    nNumFormats = *nNumFormats_ptr;
                    return retval;
                }
            }
        }

        public static
            bool wglChoosePixelFormatEXT(IntPtr hdc, ref int piAttribIList, ref float pfAttribFList, int nMaxFormats,
                [Out] out int piFormats, [Out] out int nNumFormats)
        {
            unsafe
            {
                fixed (int* piAttribIList_ptr = &piAttribIList)
                fixed (float* pfAttribFList_ptr = &pfAttribFList)
                fixed (int* piFormats_ptr = &piFormats)
                fixed (int* nNumFormats_ptr = &nNumFormats)
                {
                    var retval = Delegates.wglChoosePixelFormatEXT(hdc, piAttribIList_ptr, pfAttribFList_ptr,
                        (uint) nMaxFormats, piFormats_ptr, (uint*) nNumFormats_ptr);
                    piFormats = *piFormats_ptr;
                    nNumFormats = *nNumFormats_ptr;
                    return retval;
                }
            }
        }

        [CLSCompliant(false)]
        public static
        bool wglChoosePixelFormatEXT(IntPtr hdc, IntPtr piAttribIList, IntPtr pfAttribFList, uint nMaxFormats,
            [Out] IntPtr piFormats, [Out] IntPtr nNumFormats)
        {
            unsafe
            {
                return Delegates.wglChoosePixelFormatEXT(hdc, (int*) piAttribIList, (float*) pfAttribFList, nMaxFormats,
                    (int*) piFormats, (uint*) nNumFormats);
            }
        }

        public static
            bool wglChoosePixelFormatEXT(IntPtr hdc, IntPtr piAttribIList, IntPtr pfAttribFList, int nMaxFormats,
                [Out] IntPtr piFormats, [Out] IntPtr nNumFormats)
        {
            unsafe
            {
                return Delegates.wglChoosePixelFormatEXT(hdc, (int*) piAttribIList, (float*) pfAttribFList,
                    (uint) nMaxFormats, (int*) piFormats, (uint*) nNumFormats);
            }
        }

        public static
            bool wglSwapIntervalEXT(int interval)
        {
            return Delegates.wglSwapIntervalEXT(interval);
        }

        public static
            int wglGetSwapIntervalEXT()
        {
            return Delegates.wglGetSwapIntervalEXT();
        }

        public static
            IntPtr wglAllocateMemoryNV(int size, float readfreq, float writefreq, float priority)
        {
            return Delegates.wglAllocateMemoryNV(size, readfreq, writefreq, priority);
        }

        public static
            void wglFreeMemoryNV([Out] IntPtr[] pointer)
        {
            unsafe
            {
                fixed (IntPtr* pointer_ptr = pointer)
                {
                    Delegates.wglFreeMemoryNV(pointer_ptr);
                }
            }
        }

        public static
            void wglFreeMemoryNV([Out] out IntPtr pointer)
        {
            unsafe
            {
                fixed (IntPtr* pointer_ptr = &pointer)
                {
                    Delegates.wglFreeMemoryNV(pointer_ptr);
                    pointer = *pointer_ptr;
                }
            }
        }

        [CLSCompliant(false)]
        public static
        void wglFreeMemoryNV([Out] IntPtr pointer)
        {
            unsafe
            {
                Delegates.wglFreeMemoryNV((IntPtr*) pointer);
            }
        }

        public static
            bool wglGetSyncValuesOML(IntPtr hdc, [Out] long[] ust, [Out] long[] msc, [Out] long[] sbc)
        {
            unsafe
            {
                fixed (long* ust_ptr = ust)
                fixed (long* msc_ptr = msc)
                fixed (long* sbc_ptr = sbc)
                {
                    return Delegates.wglGetSyncValuesOML(hdc, ust_ptr, msc_ptr, sbc_ptr);
                }
            }
        }

        public static
            bool wglGetSyncValuesOML(IntPtr hdc, [Out] out long ust, [Out] out long msc, [Out] out long sbc)
        {
            unsafe
            {
                fixed (long* ust_ptr = &ust)
                fixed (long* msc_ptr = &msc)
                fixed (long* sbc_ptr = &sbc)
                {
                    var retval = Delegates.wglGetSyncValuesOML(hdc, ust_ptr, msc_ptr, sbc_ptr);
                    ust = *ust_ptr;
                    msc = *msc_ptr;
                    sbc = *sbc_ptr;
                    return retval;
                }
            }
        }

        [CLSCompliant(false)]
        public static
        bool wglGetSyncValuesOML(IntPtr hdc, [Out] IntPtr ust, [Out] IntPtr msc, [Out] IntPtr sbc)
        {
            unsafe
            {
                return Delegates.wglGetSyncValuesOML(hdc, (long*) ust, (long*) msc, (long*) sbc);
            }
        }

        public static
            bool wglGetMscRateOML(IntPtr hdc, [Out] int[] numerator, [Out] int[] denominator)
        {
            unsafe
            {
                fixed (int* numerator_ptr = numerator)
                fixed (int* denominator_ptr = denominator)
                {
                    return Delegates.wglGetMscRateOML(hdc, numerator_ptr, denominator_ptr);
                }
            }
        }

        public static
            bool wglGetMscRateOML(IntPtr hdc, [Out] out int numerator, [Out] out int denominator)
        {
            unsafe
            {
                fixed (int* numerator_ptr = &numerator)
                fixed (int* denominator_ptr = &denominator)
                {
                    var retval = Delegates.wglGetMscRateOML(hdc, numerator_ptr, denominator_ptr);
                    numerator = *numerator_ptr;
                    denominator = *denominator_ptr;
                    return retval;
                }
            }
        }

        [CLSCompliant(false)]
        public static
        bool wglGetMscRateOML(IntPtr hdc, [Out] IntPtr numerator, [Out] IntPtr denominator)
        {
            unsafe
            {
                return Delegates.wglGetMscRateOML(hdc, (int*) numerator, (int*) denominator);
            }
        }

        public static
            long wglSwapBuffersMscOML(IntPtr hdc, long target_msc, long divisor, long remainder)
        {
            return Delegates.wglSwapBuffersMscOML(hdc, target_msc, divisor, remainder);
        }

        public static
            long wglSwapLayerBuffersMscOML(IntPtr hdc, int fuPlanes, long target_msc, long divisor, long remainder)
        {
            return Delegates.wglSwapLayerBuffersMscOML(hdc, fuPlanes, target_msc, divisor, remainder);
        }

        public static
            bool wglWaitForMscOML(IntPtr hdc, long target_msc, long divisor, long remainder, [Out] long[] ust,
                [Out] long[] msc, [Out] long[] sbc)
        {
            unsafe
            {
                fixed (long* ust_ptr = ust)
                fixed (long* msc_ptr = msc)
                fixed (long* sbc_ptr = sbc)
                {
                    return Delegates.wglWaitForMscOML(hdc, target_msc, divisor, remainder, ust_ptr, msc_ptr, sbc_ptr);
                }
            }
        }

        public static
            bool wglWaitForMscOML(IntPtr hdc, long target_msc, long divisor, long remainder, [Out] out long ust,
                [Out] out long msc, [Out] out long sbc)
        {
            unsafe
            {
                fixed (long* ust_ptr = &ust)
                fixed (long* msc_ptr = &msc)
                fixed (long* sbc_ptr = &sbc)
                {
                    var retval = Delegates.wglWaitForMscOML(hdc, target_msc, divisor, remainder, ust_ptr, msc_ptr,
                        sbc_ptr);
                    ust = *ust_ptr;
                    msc = *msc_ptr;
                    sbc = *sbc_ptr;
                    return retval;
                }
            }
        }

        [CLSCompliant(false)]
        public static
        bool wglWaitForMscOML(IntPtr hdc, long target_msc, long divisor, long remainder, [Out] IntPtr ust,
            [Out] IntPtr msc, [Out] IntPtr sbc)
        {
            unsafe
            {
                return Delegates.wglWaitForMscOML(hdc, target_msc, divisor, remainder, (long*) ust, (long*) msc,
                    (long*) sbc);
            }
        }

        public static
            bool wglWaitForSbcOML(IntPtr hdc, long target_sbc, [Out] long[] ust, [Out] long[] msc, [Out] long[] sbc)
        {
            unsafe
            {
                fixed (long* ust_ptr = ust)
                fixed (long* msc_ptr = msc)
                fixed (long* sbc_ptr = sbc)
                {
                    return Delegates.wglWaitForSbcOML(hdc, target_sbc, ust_ptr, msc_ptr, sbc_ptr);
                }
            }
        }

        public static
            bool wglWaitForSbcOML(IntPtr hdc, long target_sbc, [Out] out long ust, [Out] out long msc,
                [Out] out long sbc)
        {
            unsafe
            {
                fixed (long* ust_ptr = &ust)
                fixed (long* msc_ptr = &msc)
                fixed (long* sbc_ptr = &sbc)
                {
                    var retval = Delegates.wglWaitForSbcOML(hdc, target_sbc, ust_ptr, msc_ptr, sbc_ptr);
                    ust = *ust_ptr;
                    msc = *msc_ptr;
                    sbc = *sbc_ptr;
                    return retval;
                }
            }
        }

        [CLSCompliant(false)]
        public static
        bool wglWaitForSbcOML(IntPtr hdc, long target_sbc, [Out] IntPtr ust, [Out] IntPtr msc, [Out] IntPtr sbc)
        {
            unsafe
            {
                return Delegates.wglWaitForSbcOML(hdc, target_sbc, (long*) ust, (long*) msc, (long*) sbc);
            }
        }

        public static
            bool wglGetDigitalVideoParametersI3D(IntPtr hDC, int iAttribute, [Out] int[] piValue)
        {
            unsafe
            {
                fixed (int* piValue_ptr = piValue)
                {
                    return Delegates.wglGetDigitalVideoParametersI3D(hDC, iAttribute, piValue_ptr);
                }
            }
        }

        public static
            bool wglGetDigitalVideoParametersI3D(IntPtr hDC, int iAttribute, [Out] out int piValue)
        {
            unsafe
            {
                fixed (int* piValue_ptr = &piValue)
                {
                    var retval = Delegates.wglGetDigitalVideoParametersI3D(hDC, iAttribute, piValue_ptr);
                    piValue = *piValue_ptr;
                    return retval;
                }
            }
        }

        [CLSCompliant(false)]
        public static
        bool wglGetDigitalVideoParametersI3D(IntPtr hDC, int iAttribute, [Out] IntPtr piValue)
        {
            unsafe
            {
                return Delegates.wglGetDigitalVideoParametersI3D(hDC, iAttribute, (int*) piValue);
            }
        }

        public static
            bool wglSetDigitalVideoParametersI3D(IntPtr hDC, int iAttribute, int[] piValue)
        {
            unsafe
            {
                fixed (int* piValue_ptr = piValue)
                {
                    return Delegates.wglSetDigitalVideoParametersI3D(hDC, iAttribute, piValue_ptr);
                }
            }
        }

        public static
            bool wglSetDigitalVideoParametersI3D(IntPtr hDC, int iAttribute, ref int piValue)
        {
            unsafe
            {
                fixed (int* piValue_ptr = &piValue)
                {
                    return Delegates.wglSetDigitalVideoParametersI3D(hDC, iAttribute, piValue_ptr);
                }
            }
        }

        [CLSCompliant(false)]
        public static
        bool wglSetDigitalVideoParametersI3D(IntPtr hDC, int iAttribute, IntPtr piValue)
        {
            unsafe
            {
                return Delegates.wglSetDigitalVideoParametersI3D(hDC, iAttribute, (int*) piValue);
            }
        }

        public static
            bool wglGetGammaTableParametersI3D(IntPtr hDC, int iAttribute, [Out] int[] piValue)
        {
            unsafe
            {
                fixed (int* piValue_ptr = piValue)
                {
                    return Delegates.wglGetGammaTableParametersI3D(hDC, iAttribute, piValue_ptr);
                }
            }
        }

        public static
            bool wglGetGammaTableParametersI3D(IntPtr hDC, int iAttribute, [Out] out int piValue)
        {
            unsafe
            {
                fixed (int* piValue_ptr = &piValue)
                {
                    var retval = Delegates.wglGetGammaTableParametersI3D(hDC, iAttribute, piValue_ptr);
                    piValue = *piValue_ptr;
                    return retval;
                }
            }
        }

        [CLSCompliant(false)]
        public static
        bool wglGetGammaTableParametersI3D(IntPtr hDC, int iAttribute, [Out] IntPtr piValue)
        {
            unsafe
            {
                return Delegates.wglGetGammaTableParametersI3D(hDC, iAttribute, (int*) piValue);
            }
        }

        public static
            bool wglSetGammaTableParametersI3D(IntPtr hDC, int iAttribute, int[] piValue)
        {
            unsafe
            {
                fixed (int* piValue_ptr = piValue)
                {
                    return Delegates.wglSetGammaTableParametersI3D(hDC, iAttribute, piValue_ptr);
                }
            }
        }

        public static
            bool wglSetGammaTableParametersI3D(IntPtr hDC, int iAttribute, ref int piValue)
        {
            unsafe
            {
                fixed (int* piValue_ptr = &piValue)
                {
                    return Delegates.wglSetGammaTableParametersI3D(hDC, iAttribute, piValue_ptr);
                }
            }
        }

        [CLSCompliant(false)]
        public static
        bool wglSetGammaTableParametersI3D(IntPtr hDC, int iAttribute, IntPtr piValue)
        {
            unsafe
            {
                return Delegates.wglSetGammaTableParametersI3D(hDC, iAttribute, (int*) piValue);
            }
        }

        [CLSCompliant(false)]
        public static
        bool wglGetGammaTableI3D(IntPtr hDC, int iEntries, [Out] ushort[] puRed, [Out] ushort[] puGreen,
            [Out] ushort[] puBlue)
        {
            unsafe
            {
                fixed (ushort* puRed_ptr = puRed)
                fixed (ushort* puGreen_ptr = puGreen)
                fixed (ushort* puBlue_ptr = puBlue)
                {
                    return Delegates.wglGetGammaTableI3D(hDC, iEntries, puRed_ptr, puGreen_ptr, puBlue_ptr);
                }
            }
        }

        public static
            bool wglGetGammaTableI3D(IntPtr hDC, int iEntries, [Out] short[] puRed, [Out] short[] puGreen,
                [Out] short[] puBlue)
        {
            unsafe
            {
                fixed (short* puRed_ptr = puRed)
                fixed (short* puGreen_ptr = puGreen)
                fixed (short* puBlue_ptr = puBlue)
                {
                    return Delegates.wglGetGammaTableI3D(hDC, iEntries, (ushort*) puRed_ptr, (ushort*) puGreen_ptr,
                        (ushort*) puBlue_ptr);
                }
            }
        }

        [CLSCompliant(false)]
        public static
        bool wglGetGammaTableI3D(IntPtr hDC, int iEntries, [Out] out ushort puRed, [Out] out ushort puGreen,
            [Out] out ushort puBlue)
        {
            unsafe
            {
                fixed (ushort* puRed_ptr = &puRed)
                fixed (ushort* puGreen_ptr = &puGreen)
                fixed (ushort* puBlue_ptr = &puBlue)
                {
                    var retval = Delegates.wglGetGammaTableI3D(hDC, iEntries, puRed_ptr, puGreen_ptr, puBlue_ptr);
                    puRed = *puRed_ptr;
                    puGreen = *puGreen_ptr;
                    puBlue = *puBlue_ptr;
                    return retval;
                }
            }
        }

        public static
            bool wglGetGammaTableI3D(IntPtr hDC, int iEntries, [Out] out short puRed, [Out] out short puGreen,
                [Out] out short puBlue)
        {
            unsafe
            {
                fixed (short* puRed_ptr = &puRed)
                fixed (short* puGreen_ptr = &puGreen)
                fixed (short* puBlue_ptr = &puBlue)
                {
                    var retval = Delegates.wglGetGammaTableI3D(hDC, iEntries, (ushort*) puRed_ptr, (ushort*) puGreen_ptr,
                        (ushort*) puBlue_ptr);
                    puRed = *puRed_ptr;
                    puGreen = *puGreen_ptr;
                    puBlue = *puBlue_ptr;
                    return retval;
                }
            }
        }

        public static
            bool wglGetGammaTableI3D(IntPtr hDC, int iEntries, [Out] IntPtr puRed, [Out] IntPtr puGreen,
                [Out] IntPtr puBlue)
        {
            unsafe
            {
                return Delegates.wglGetGammaTableI3D(hDC, iEntries, (ushort*) puRed, (ushort*) puGreen, (ushort*) puBlue);
            }
        }

        [CLSCompliant(false)]
        public static
        bool wglSetGammaTableI3D(IntPtr hDC, int iEntries, ushort[] puRed, ushort[] puGreen, ushort[] puBlue)
        {
            unsafe
            {
                fixed (ushort* puRed_ptr = puRed)
                fixed (ushort* puGreen_ptr = puGreen)
                fixed (ushort* puBlue_ptr = puBlue)
                {
                    return Delegates.wglSetGammaTableI3D(hDC, iEntries, puRed_ptr, puGreen_ptr, puBlue_ptr);
                }
            }
        }

        public static
            bool wglSetGammaTableI3D(IntPtr hDC, int iEntries, short[] puRed, short[] puGreen, short[] puBlue)
        {
            unsafe
            {
                fixed (short* puRed_ptr = puRed)
                fixed (short* puGreen_ptr = puGreen)
                fixed (short* puBlue_ptr = puBlue)
                {
                    return Delegates.wglSetGammaTableI3D(hDC, iEntries, (ushort*) puRed_ptr, (ushort*) puGreen_ptr,
                        (ushort*) puBlue_ptr);
                }
            }
        }

        [CLSCompliant(false)]
        public static
        bool wglSetGammaTableI3D(IntPtr hDC, int iEntries, ref ushort puRed, ref ushort puGreen, ref ushort puBlue)
        {
            unsafe
            {
                fixed (ushort* puRed_ptr = &puRed)
                fixed (ushort* puGreen_ptr = &puGreen)
                fixed (ushort* puBlue_ptr = &puBlue)
                {
                    return Delegates.wglSetGammaTableI3D(hDC, iEntries, puRed_ptr, puGreen_ptr, puBlue_ptr);
                }
            }
        }

        public static
            bool wglSetGammaTableI3D(IntPtr hDC, int iEntries, ref short puRed, ref short puGreen, ref short puBlue)
        {
            unsafe
            {
                fixed (short* puRed_ptr = &puRed)
                fixed (short* puGreen_ptr = &puGreen)
                fixed (short* puBlue_ptr = &puBlue)
                {
                    return Delegates.wglSetGammaTableI3D(hDC, iEntries, (ushort*) puRed_ptr, (ushort*) puGreen_ptr,
                        (ushort*) puBlue_ptr);
                }
            }
        }

        public static
            bool wglSetGammaTableI3D(IntPtr hDC, int iEntries, IntPtr puRed, IntPtr puGreen, IntPtr puBlue)
        {
            unsafe
            {
                return Delegates.wglSetGammaTableI3D(hDC, iEntries, (ushort*) puRed, (ushort*) puGreen, (ushort*) puBlue);
            }
        }

        public static
            bool wglEnableGenlockI3D(IntPtr hDC)
        {
            return Delegates.wglEnableGenlockI3D(hDC);
        }

        public static
            bool wglDisableGenlockI3D(IntPtr hDC)
        {
            return Delegates.wglDisableGenlockI3D(hDC);
        }

        public static
            bool wglIsEnabledGenlockI3D(IntPtr hDC, [Out] bool[] pFlag)
        {
            unsafe
            {
                fixed (bool* pFlag_ptr = pFlag)
                {
                    return Delegates.wglIsEnabledGenlockI3D(hDC, pFlag_ptr);
                }
            }
        }

        public static
            bool wglIsEnabledGenlockI3D(IntPtr hDC, [Out] out bool pFlag)
        {
            unsafe
            {
                fixed (bool* pFlag_ptr = &pFlag)
                {
                    var retval = Delegates.wglIsEnabledGenlockI3D(hDC, pFlag_ptr);
                    pFlag = *pFlag_ptr;
                    return retval;
                }
            }
        }

        [CLSCompliant(false)]
        public static
        bool wglIsEnabledGenlockI3D(IntPtr hDC, [Out] IntPtr pFlag)
        {
            unsafe
            {
                return Delegates.wglIsEnabledGenlockI3D(hDC, (bool*) pFlag);
            }
        }

        [CLSCompliant(false)]
        public static
        bool wglGenlockSourceI3D(IntPtr hDC, uint uSource)
        {
            return Delegates.wglGenlockSourceI3D(hDC, uSource);
        }

        public static
            bool wglGenlockSourceI3D(IntPtr hDC, int uSource)
        {
            return Delegates.wglGenlockSourceI3D(hDC, (uint) uSource);
        }

        [CLSCompliant(false)]
        public static
        bool wglGetGenlockSourceI3D(IntPtr hDC, [Out] uint[] uSource)
        {
            unsafe
            {
                fixed (uint* uSource_ptr = uSource)
                {
                    return Delegates.wglGetGenlockSourceI3D(hDC, uSource_ptr);
                }
            }
        }

        public static
            bool wglGetGenlockSourceI3D(IntPtr hDC, [Out] int[] uSource)
        {
            unsafe
            {
                fixed (int* uSource_ptr = uSource)
                {
                    return Delegates.wglGetGenlockSourceI3D(hDC, (uint*) uSource_ptr);
                }
            }
        }

        [CLSCompliant(false)]
        public static
        bool wglGetGenlockSourceI3D(IntPtr hDC, [Out] out uint uSource)
        {
            unsafe
            {
                fixed (uint* uSource_ptr = &uSource)
                {
                    var retval = Delegates.wglGetGenlockSourceI3D(hDC, uSource_ptr);
                    uSource = *uSource_ptr;
                    return retval;
                }
            }
        }

        public static
            bool wglGetGenlockSourceI3D(IntPtr hDC, [Out] out int uSource)
        {
            unsafe
            {
                fixed (int* uSource_ptr = &uSource)
                {
                    var retval = Delegates.wglGetGenlockSourceI3D(hDC, (uint*) uSource_ptr);
                    uSource = *uSource_ptr;
                    return retval;
                }
            }
        }

        public static
            bool wglGetGenlockSourceI3D(IntPtr hDC, [Out] IntPtr uSource)
        {
            unsafe
            {
                return Delegates.wglGetGenlockSourceI3D(hDC, (uint*) uSource);
            }
        }

        [CLSCompliant(false)]
        public static
        bool wglGenlockSourceEdgeI3D(IntPtr hDC, uint uEdge)
        {
            return Delegates.wglGenlockSourceEdgeI3D(hDC, uEdge);
        }

        public static
            bool wglGenlockSourceEdgeI3D(IntPtr hDC, int uEdge)
        {
            return Delegates.wglGenlockSourceEdgeI3D(hDC, (uint) uEdge);
        }

        [CLSCompliant(false)]
        public static
        bool wglGetGenlockSourceEdgeI3D(IntPtr hDC, [Out] uint[] uEdge)
        {
            unsafe
            {
                fixed (uint* uEdge_ptr = uEdge)
                {
                    return Delegates.wglGetGenlockSourceEdgeI3D(hDC, uEdge_ptr);
                }
            }
        }

        public static
            bool wglGetGenlockSourceEdgeI3D(IntPtr hDC, [Out] int[] uEdge)
        {
            unsafe
            {
                fixed (int* uEdge_ptr = uEdge)
                {
                    return Delegates.wglGetGenlockSourceEdgeI3D(hDC, (uint*) uEdge_ptr);
                }
            }
        }

        [CLSCompliant(false)]
        public static
        bool wglGetGenlockSourceEdgeI3D(IntPtr hDC, [Out] out uint uEdge)
        {
            unsafe
            {
                fixed (uint* uEdge_ptr = &uEdge)
                {
                    var retval = Delegates.wglGetGenlockSourceEdgeI3D(hDC, uEdge_ptr);
                    uEdge = *uEdge_ptr;
                    return retval;
                }
            }
        }

        public static
            bool wglGetGenlockSourceEdgeI3D(IntPtr hDC, [Out] out int uEdge)
        {
            unsafe
            {
                fixed (int* uEdge_ptr = &uEdge)
                {
                    var retval = Delegates.wglGetGenlockSourceEdgeI3D(hDC, (uint*) uEdge_ptr);
                    uEdge = *uEdge_ptr;
                    return retval;
                }
            }
        }

        public static
            bool wglGetGenlockSourceEdgeI3D(IntPtr hDC, [Out] IntPtr uEdge)
        {
            unsafe
            {
                return Delegates.wglGetGenlockSourceEdgeI3D(hDC, (uint*) uEdge);
            }
        }

        [CLSCompliant(false)]
        public static
        bool wglGenlockSampleRateI3D(IntPtr hDC, uint uRate)
        {
            return Delegates.wglGenlockSampleRateI3D(hDC, uRate);
        }

        public static
            bool wglGenlockSampleRateI3D(IntPtr hDC, int uRate)
        {
            return Delegates.wglGenlockSampleRateI3D(hDC, (uint) uRate);
        }

        [CLSCompliant(false)]
        public static
        bool wglGetGenlockSampleRateI3D(IntPtr hDC, [Out] uint[] uRate)
        {
            unsafe
            {
                fixed (uint* uRate_ptr = uRate)
                {
                    return Delegates.wglGetGenlockSampleRateI3D(hDC, uRate_ptr);
                }
            }
        }

        public static
            bool wglGetGenlockSampleRateI3D(IntPtr hDC, [Out] int[] uRate)
        {
            unsafe
            {
                fixed (int* uRate_ptr = uRate)
                {
                    return Delegates.wglGetGenlockSampleRateI3D(hDC, (uint*) uRate_ptr);
                }
            }
        }

        [CLSCompliant(false)]
        public static
        bool wglGetGenlockSampleRateI3D(IntPtr hDC, [Out] out uint uRate)
        {
            unsafe
            {
                fixed (uint* uRate_ptr = &uRate)
                {
                    var retval = Delegates.wglGetGenlockSampleRateI3D(hDC, uRate_ptr);
                    uRate = *uRate_ptr;
                    return retval;
                }
            }
        }

        public static
            bool wglGetGenlockSampleRateI3D(IntPtr hDC, [Out] out int uRate)
        {
            unsafe
            {
                fixed (int* uRate_ptr = &uRate)
                {
                    var retval = Delegates.wglGetGenlockSampleRateI3D(hDC, (uint*) uRate_ptr);
                    uRate = *uRate_ptr;
                    return retval;
                }
            }
        }

        public static
            bool wglGetGenlockSampleRateI3D(IntPtr hDC, [Out] IntPtr uRate)
        {
            unsafe
            {
                return Delegates.wglGetGenlockSampleRateI3D(hDC, (uint*) uRate);
            }
        }

        [CLSCompliant(false)]
        public static
        bool wglGenlockSourceDelayI3D(IntPtr hDC, uint uDelay)
        {
            return Delegates.wglGenlockSourceDelayI3D(hDC, uDelay);
        }

        public static
            bool wglGenlockSourceDelayI3D(IntPtr hDC, int uDelay)
        {
            return Delegates.wglGenlockSourceDelayI3D(hDC, (uint) uDelay);
        }

        [CLSCompliant(false)]
        public static
        bool wglGetGenlockSourceDelayI3D(IntPtr hDC, [Out] uint[] uDelay)
        {
            unsafe
            {
                fixed (uint* uDelay_ptr = uDelay)
                {
                    return Delegates.wglGetGenlockSourceDelayI3D(hDC, uDelay_ptr);
                }
            }
        }

        public static
            bool wglGetGenlockSourceDelayI3D(IntPtr hDC, [Out] int[] uDelay)
        {
            unsafe
            {
                fixed (int* uDelay_ptr = uDelay)
                {
                    return Delegates.wglGetGenlockSourceDelayI3D(hDC, (uint*) uDelay_ptr);
                }
            }
        }

        [CLSCompliant(false)]
        public static
        bool wglGetGenlockSourceDelayI3D(IntPtr hDC, [Out] out uint uDelay)
        {
            unsafe
            {
                fixed (uint* uDelay_ptr = &uDelay)
                {
                    var retval = Delegates.wglGetGenlockSourceDelayI3D(hDC, uDelay_ptr);
                    uDelay = *uDelay_ptr;
                    return retval;
                }
            }
        }

        public static
            bool wglGetGenlockSourceDelayI3D(IntPtr hDC, [Out] out int uDelay)
        {
            unsafe
            {
                fixed (int* uDelay_ptr = &uDelay)
                {
                    var retval = Delegates.wglGetGenlockSourceDelayI3D(hDC, (uint*) uDelay_ptr);
                    uDelay = *uDelay_ptr;
                    return retval;
                }
            }
        }

        public static
            bool wglGetGenlockSourceDelayI3D(IntPtr hDC, [Out] IntPtr uDelay)
        {
            unsafe
            {
                return Delegates.wglGetGenlockSourceDelayI3D(hDC, (uint*) uDelay);
            }
        }

        [CLSCompliant(false)]
        public static
        bool wglQueryGenlockMaxSourceDelayI3D(IntPtr hDC, [Out] uint[] uMaxLineDelay, [Out] uint[] uMaxPixelDelay)
        {
            unsafe
            {
                fixed (uint* uMaxLineDelay_ptr = uMaxLineDelay)
                fixed (uint* uMaxPixelDelay_ptr = uMaxPixelDelay)
                {
                    return Delegates.wglQueryGenlockMaxSourceDelayI3D(hDC, uMaxLineDelay_ptr, uMaxPixelDelay_ptr);
                }
            }
        }

        public static
            bool wglQueryGenlockMaxSourceDelayI3D(IntPtr hDC, [Out] int[] uMaxLineDelay, [Out] int[] uMaxPixelDelay)
        {
            unsafe
            {
                fixed (int* uMaxLineDelay_ptr = uMaxLineDelay)
                fixed (int* uMaxPixelDelay_ptr = uMaxPixelDelay)
                {
                    return Delegates.wglQueryGenlockMaxSourceDelayI3D(hDC, (uint*) uMaxLineDelay_ptr,
                        (uint*) uMaxPixelDelay_ptr);
                }
            }
        }

        [CLSCompliant(false)]
        public static
        bool wglQueryGenlockMaxSourceDelayI3D(IntPtr hDC, [Out] out uint uMaxLineDelay, [Out] out uint uMaxPixelDelay)
        {
            unsafe
            {
                fixed (uint* uMaxLineDelay_ptr = &uMaxLineDelay)
                fixed (uint* uMaxPixelDelay_ptr = &uMaxPixelDelay)
                {
                    var retval = Delegates.wglQueryGenlockMaxSourceDelayI3D(hDC, uMaxLineDelay_ptr, uMaxPixelDelay_ptr);
                    uMaxLineDelay = *uMaxLineDelay_ptr;
                    uMaxPixelDelay = *uMaxPixelDelay_ptr;
                    return retval;
                }
            }
        }

        public static
            bool wglQueryGenlockMaxSourceDelayI3D(IntPtr hDC, [Out] out int uMaxLineDelay, [Out] out int uMaxPixelDelay)
        {
            unsafe
            {
                fixed (int* uMaxLineDelay_ptr = &uMaxLineDelay)
                fixed (int* uMaxPixelDelay_ptr = &uMaxPixelDelay)
                {
                    var retval = Delegates.wglQueryGenlockMaxSourceDelayI3D(hDC, (uint*) uMaxLineDelay_ptr,
                        (uint*) uMaxPixelDelay_ptr);
                    uMaxLineDelay = *uMaxLineDelay_ptr;
                    uMaxPixelDelay = *uMaxPixelDelay_ptr;
                    return retval;
                }
            }
        }

        public static
            bool wglQueryGenlockMaxSourceDelayI3D(IntPtr hDC, [Out] IntPtr uMaxLineDelay, [Out] IntPtr uMaxPixelDelay)
        {
            unsafe
            {
                return Delegates.wglQueryGenlockMaxSourceDelayI3D(hDC, (uint*) uMaxLineDelay, (uint*) uMaxPixelDelay);
            }
        }

        [CLSCompliant(false)]
        public static
        IntPtr wglCreateImageBufferI3D(IntPtr hDC, int dwSize, uint uFlags)
        {
            return Delegates.wglCreateImageBufferI3D(hDC, dwSize, uFlags);
        }

        public static
            IntPtr wglCreateImageBufferI3D(IntPtr hDC, int dwSize, int uFlags)
        {
            return Delegates.wglCreateImageBufferI3D(hDC, dwSize, (uint) uFlags);
        }

        public static
            bool wglDestroyImageBufferI3D(IntPtr hDC, IntPtr pAddress)
        {
            return Delegates.wglDestroyImageBufferI3D(hDC, pAddress);
        }

        public static
            bool wglDestroyImageBufferI3D(IntPtr hDC, [In, Out] object pAddress)
        {
            var pAddress_ptr = GCHandle.Alloc(pAddress, GCHandleType.Pinned);
            try
            {
                return Delegates.wglDestroyImageBufferI3D(hDC, pAddress_ptr.AddrOfPinnedObject());
            }
            finally
            {
                pAddress_ptr.Free();
            }
        }

        [CLSCompliant(false)]
        public static
        bool wglAssociateImageBufferEventsI3D(IntPtr hDC, IntPtr[] pEvent, IntPtr pAddress, int[] pSize, uint count)
        {
            unsafe
            {
                fixed (IntPtr* pEvent_ptr = pEvent)
                fixed (int* pSize_ptr = pSize)
                {
                    return Delegates.wglAssociateImageBufferEventsI3D(hDC, pEvent_ptr, pAddress, pSize_ptr, count);
                }
            }
        }

        public static
            bool wglAssociateImageBufferEventsI3D(IntPtr hDC, IntPtr[] pEvent, IntPtr pAddress, int[] pSize, int count)
        {
            unsafe
            {
                fixed (IntPtr* pEvent_ptr = pEvent)
                fixed (int* pSize_ptr = pSize)
                {
                    return Delegates.wglAssociateImageBufferEventsI3D(hDC, pEvent_ptr, pAddress, pSize_ptr, (uint) count);
                }
            }
        }

        [CLSCompliant(false)]
        public static
        bool wglAssociateImageBufferEventsI3D(IntPtr hDC, IntPtr[] pEvent, [In, Out] object pAddress, int[] pSize,
            uint count)
        {
            unsafe
            {
                fixed (IntPtr* pEvent_ptr = pEvent)
                fixed (int* pSize_ptr = pSize)
                {
                    var pAddress_ptr = GCHandle.Alloc(pAddress, GCHandleType.Pinned);
                    try
                    {
                        return Delegates.wglAssociateImageBufferEventsI3D(hDC, pEvent_ptr,
                            pAddress_ptr.AddrOfPinnedObject(), pSize_ptr, count);
                    }
                    finally
                    {
                        pAddress_ptr.Free();
                    }
                }
            }
        }

        public static
            bool wglAssociateImageBufferEventsI3D(IntPtr hDC, IntPtr[] pEvent, [In, Out] object pAddress, int[] pSize,
                int count)
        {
            unsafe
            {
                fixed (IntPtr* pEvent_ptr = pEvent)
                fixed (int* pSize_ptr = pSize)
                {
                    var pAddress_ptr = GCHandle.Alloc(pAddress, GCHandleType.Pinned);
                    try
                    {
                        return Delegates.wglAssociateImageBufferEventsI3D(hDC, pEvent_ptr,
                            pAddress_ptr.AddrOfPinnedObject(), pSize_ptr, (uint) count);
                    }
                    finally
                    {
                        pAddress_ptr.Free();
                    }
                }
            }
        }

        [CLSCompliant(false)]
        public static
        bool wglAssociateImageBufferEventsI3D(IntPtr hDC, IntPtr[] pEvent, [In, Out] object pAddress, ref int pSize,
            uint count)
        {
            unsafe
            {
                fixed (IntPtr* pEvent_ptr = pEvent)
                fixed (int* pSize_ptr = &pSize)
                {
                    var pAddress_ptr = GCHandle.Alloc(pAddress, GCHandleType.Pinned);
                    try
                    {
                        return Delegates.wglAssociateImageBufferEventsI3D(hDC, pEvent_ptr,
                            pAddress_ptr.AddrOfPinnedObject(), pSize_ptr, count);
                    }
                    finally
                    {
                        pAddress_ptr.Free();
                    }
                }
            }
        }

        public static
            bool wglAssociateImageBufferEventsI3D(IntPtr hDC, IntPtr[] pEvent, [In, Out] object pAddress, ref int pSize,
                int count)
        {
            unsafe
            {
                fixed (IntPtr* pEvent_ptr = pEvent)
                fixed (int* pSize_ptr = &pSize)
                {
                    var pAddress_ptr = GCHandle.Alloc(pAddress, GCHandleType.Pinned);
                    try
                    {
                        return Delegates.wglAssociateImageBufferEventsI3D(hDC, pEvent_ptr,
                            pAddress_ptr.AddrOfPinnedObject(), pSize_ptr, (uint) count);
                    }
                    finally
                    {
                        pAddress_ptr.Free();
                    }
                }
            }
        }

        [CLSCompliant(false)]
        public static
        bool wglAssociateImageBufferEventsI3D(IntPtr hDC, ref IntPtr pEvent, [In, Out] object pAddress, int[] pSize,
            uint count)
        {
            unsafe
            {
                fixed (IntPtr* pEvent_ptr = &pEvent)
                fixed (int* pSize_ptr = pSize)
                {
                    var pAddress_ptr = GCHandle.Alloc(pAddress, GCHandleType.Pinned);
                    try
                    {
                        return Delegates.wglAssociateImageBufferEventsI3D(hDC, pEvent_ptr,
                            pAddress_ptr.AddrOfPinnedObject(), pSize_ptr, count);
                    }
                    finally
                    {
                        pAddress_ptr.Free();
                    }
                }
            }
        }

        public static
            bool wglAssociateImageBufferEventsI3D(IntPtr hDC, ref IntPtr pEvent, [In, Out] object pAddress, int[] pSize,
                int count)
        {
            unsafe
            {
                fixed (IntPtr* pEvent_ptr = &pEvent)
                fixed (int* pSize_ptr = pSize)
                {
                    var pAddress_ptr = GCHandle.Alloc(pAddress, GCHandleType.Pinned);
                    try
                    {
                        return Delegates.wglAssociateImageBufferEventsI3D(hDC, pEvent_ptr,
                            pAddress_ptr.AddrOfPinnedObject(), pSize_ptr, (uint) count);
                    }
                    finally
                    {
                        pAddress_ptr.Free();
                    }
                }
            }
        }

        [CLSCompliant(false)]
        public static
        bool wglAssociateImageBufferEventsI3D(IntPtr hDC, ref IntPtr pEvent, [In, Out] object pAddress, ref int pSize,
            uint count)
        {
            unsafe
            {
                fixed (IntPtr* pEvent_ptr = &pEvent)
                fixed (int* pSize_ptr = &pSize)
                {
                    var pAddress_ptr = GCHandle.Alloc(pAddress, GCHandleType.Pinned);
                    try
                    {
                        return Delegates.wglAssociateImageBufferEventsI3D(hDC, pEvent_ptr,
                            pAddress_ptr.AddrOfPinnedObject(), pSize_ptr, count);
                    }
                    finally
                    {
                        pAddress_ptr.Free();
                    }
                }
            }
        }

        public static
            bool wglAssociateImageBufferEventsI3D(IntPtr hDC, ref IntPtr pEvent, [In, Out] object pAddress,
                ref int pSize, int count)
        {
            unsafe
            {
                fixed (IntPtr* pEvent_ptr = &pEvent)
                fixed (int* pSize_ptr = &pSize)
                {
                    var pAddress_ptr = GCHandle.Alloc(pAddress, GCHandleType.Pinned);
                    try
                    {
                        return Delegates.wglAssociateImageBufferEventsI3D(hDC, pEvent_ptr,
                            pAddress_ptr.AddrOfPinnedObject(), pSize_ptr, (uint) count);
                    }
                    finally
                    {
                        pAddress_ptr.Free();
                    }
                }
            }
        }

        [CLSCompliant(false)]
        public static
        bool wglAssociateImageBufferEventsI3D(IntPtr hDC, IntPtr pEvent, [In, Out] object pAddress, IntPtr pSize,
            uint count)
        {
            unsafe
            {
                var pAddress_ptr = GCHandle.Alloc(pAddress, GCHandleType.Pinned);
                try
                {
                    return Delegates.wglAssociateImageBufferEventsI3D(hDC, (IntPtr*) pEvent,
                        pAddress_ptr.AddrOfPinnedObject(), (int*) pSize, count);
                }
                finally
                {
                    pAddress_ptr.Free();
                }
            }
        }

        [CLSCompliant(false)]
        public static
        bool wglAssociateImageBufferEventsI3D(IntPtr hDC, IntPtr pEvent, [In, Out] object pAddress, IntPtr pSize,
            int count)
        {
            unsafe
            {
                var pAddress_ptr = GCHandle.Alloc(pAddress, GCHandleType.Pinned);
                try
                {
                    return Delegates.wglAssociateImageBufferEventsI3D(hDC, (IntPtr*) pEvent,
                        pAddress_ptr.AddrOfPinnedObject(), (int*) pSize, (uint) count);
                }
                finally
                {
                    pAddress_ptr.Free();
                }
            }
        }

        [CLSCompliant(false)]
        public static
        bool wglAssociateImageBufferEventsI3D(IntPtr hDC, IntPtr pEvent, [In, Out] object pAddress, int[] pSize,
            uint count)
        {
            unsafe
            {
                fixed (int* pSize_ptr = pSize)
                {
                    var pAddress_ptr = GCHandle.Alloc(pAddress, GCHandleType.Pinned);
                    try
                    {
                        return Delegates.wglAssociateImageBufferEventsI3D(hDC, (IntPtr*) pEvent,
                            pAddress_ptr.AddrOfPinnedObject(), pSize_ptr, count);
                    }
                    finally
                    {
                        pAddress_ptr.Free();
                    }
                }
            }
        }

        [CLSCompliant(false)]
        public static
        bool wglAssociateImageBufferEventsI3D(IntPtr hDC, IntPtr pEvent, [In, Out] object pAddress, int[] pSize,
            int count)
        {
            unsafe
            {
                fixed (int* pSize_ptr = pSize)
                {
                    var pAddress_ptr = GCHandle.Alloc(pAddress, GCHandleType.Pinned);
                    try
                    {
                        return Delegates.wglAssociateImageBufferEventsI3D(hDC, (IntPtr*) pEvent,
                            pAddress_ptr.AddrOfPinnedObject(), pSize_ptr, (uint) count);
                    }
                    finally
                    {
                        pAddress_ptr.Free();
                    }
                }
            }
        }

        [CLSCompliant(false)]
        public static
        bool wglAssociateImageBufferEventsI3D(IntPtr hDC, IntPtr pEvent, [In, Out] object pAddress, ref int pSize,
            uint count)
        {
            unsafe
            {
                fixed (int* pSize_ptr = &pSize)
                {
                    var pAddress_ptr = GCHandle.Alloc(pAddress, GCHandleType.Pinned);
                    try
                    {
                        return Delegates.wglAssociateImageBufferEventsI3D(hDC, (IntPtr*) pEvent,
                            pAddress_ptr.AddrOfPinnedObject(), pSize_ptr, count);
                    }
                    finally
                    {
                        pAddress_ptr.Free();
                    }
                }
            }
        }

        [CLSCompliant(false)]
        public static
        bool wglAssociateImageBufferEventsI3D(IntPtr hDC, IntPtr pEvent, [In, Out] object pAddress, ref int pSize,
            int count)
        {
            unsafe
            {
                fixed (int* pSize_ptr = &pSize)
                {
                    var pAddress_ptr = GCHandle.Alloc(pAddress, GCHandleType.Pinned);
                    try
                    {
                        return Delegates.wglAssociateImageBufferEventsI3D(hDC, (IntPtr*) pEvent,
                            pAddress_ptr.AddrOfPinnedObject(), pSize_ptr, (uint) count);
                    }
                    finally
                    {
                        pAddress_ptr.Free();
                    }
                }
            }
        }

        [CLSCompliant(false)]
        public static
        bool wglReleaseImageBufferEventsI3D(IntPtr hDC, IntPtr pAddress, uint count)
        {
            return Delegates.wglReleaseImageBufferEventsI3D(hDC, pAddress, count);
        }

        public static
            bool wglReleaseImageBufferEventsI3D(IntPtr hDC, IntPtr pAddress, int count)
        {
            return Delegates.wglReleaseImageBufferEventsI3D(hDC, pAddress, (uint) count);
        }

        [CLSCompliant(false)]
        public static
        bool wglReleaseImageBufferEventsI3D(IntPtr hDC, [In, Out] object pAddress, uint count)
        {
            var pAddress_ptr = GCHandle.Alloc(pAddress, GCHandleType.Pinned);
            try
            {
                return Delegates.wglReleaseImageBufferEventsI3D(hDC, pAddress_ptr.AddrOfPinnedObject(), count);
            }
            finally
            {
                pAddress_ptr.Free();
            }
        }

        public static
            bool wglReleaseImageBufferEventsI3D(IntPtr hDC, [In, Out] object pAddress, int count)
        {
            var pAddress_ptr = GCHandle.Alloc(pAddress, GCHandleType.Pinned);
            try
            {
                return Delegates.wglReleaseImageBufferEventsI3D(hDC, pAddress_ptr.AddrOfPinnedObject(), (uint) count);
            }
            finally
            {
                pAddress_ptr.Free();
            }
        }

        public static
            bool wglEnableFrameLockI3D()
        {
            return Delegates.wglEnableFrameLockI3D();
        }

        public static
            bool wglDisableFrameLockI3D()
        {
            return Delegates.wglDisableFrameLockI3D();
        }

        public static
            bool wglIsEnabledFrameLockI3D([Out] bool[] pFlag)
        {
            unsafe
            {
                fixed (bool* pFlag_ptr = pFlag)
                {
                    return Delegates.wglIsEnabledFrameLockI3D(pFlag_ptr);
                }
            }
        }

        public static
            bool wglIsEnabledFrameLockI3D([Out] out bool pFlag)
        {
            unsafe
            {
                fixed (bool* pFlag_ptr = &pFlag)
                {
                    var retval = Delegates.wglIsEnabledFrameLockI3D(pFlag_ptr);
                    pFlag = *pFlag_ptr;
                    return retval;
                }
            }
        }

        [CLSCompliant(false)]
        public static
        bool wglIsEnabledFrameLockI3D([Out] IntPtr pFlag)
        {
            unsafe
            {
                return Delegates.wglIsEnabledFrameLockI3D((bool*) pFlag);
            }
        }

        public static
            bool wglQueryFrameLockMasterI3D([Out] bool[] pFlag)
        {
            unsafe
            {
                fixed (bool* pFlag_ptr = pFlag)
                {
                    return Delegates.wglQueryFrameLockMasterI3D(pFlag_ptr);
                }
            }
        }

        public static
            bool wglQueryFrameLockMasterI3D([Out] out bool pFlag)
        {
            unsafe
            {
                fixed (bool* pFlag_ptr = &pFlag)
                {
                    var retval = Delegates.wglQueryFrameLockMasterI3D(pFlag_ptr);
                    pFlag = *pFlag_ptr;
                    return retval;
                }
            }
        }

        [CLSCompliant(false)]
        public static
        bool wglQueryFrameLockMasterI3D([Out] IntPtr pFlag)
        {
            unsafe
            {
                return Delegates.wglQueryFrameLockMasterI3D((bool*) pFlag);
            }
        }

        public static
            bool wglGetFrameUsageI3D([Out] float[] pUsage)
        {
            unsafe
            {
                fixed (float* pUsage_ptr = pUsage)
                {
                    return Delegates.wglGetFrameUsageI3D(pUsage_ptr);
                }
            }
        }

        public static
            bool wglGetFrameUsageI3D([Out] out float pUsage)
        {
            unsafe
            {
                fixed (float* pUsage_ptr = &pUsage)
                {
                    var retval = Delegates.wglGetFrameUsageI3D(pUsage_ptr);
                    pUsage = *pUsage_ptr;
                    return retval;
                }
            }
        }

        [CLSCompliant(false)]
        public static
        bool wglGetFrameUsageI3D([Out] IntPtr pUsage)
        {
            unsafe
            {
                return Delegates.wglGetFrameUsageI3D((float*) pUsage);
            }
        }

        public static
            bool wglBeginFrameTrackingI3D()
        {
            return Delegates.wglBeginFrameTrackingI3D();
        }

        public static
            bool wglEndFrameTrackingI3D()
        {
            return Delegates.wglEndFrameTrackingI3D();
        }

        public static
            bool wglQueryFrameTrackingI3D([Out] int[] pFrameCount, [Out] int[] pMissedFrames,
                [Out] float[] pLastMissedUsage)
        {
            unsafe
            {
                fixed (int* pFrameCount_ptr = pFrameCount)
                fixed (int* pMissedFrames_ptr = pMissedFrames)
                fixed (float* pLastMissedUsage_ptr = pLastMissedUsage)
                {
                    return Delegates.wglQueryFrameTrackingI3D(pFrameCount_ptr, pMissedFrames_ptr, pLastMissedUsage_ptr);
                }
            }
        }

        public static
            bool wglQueryFrameTrackingI3D([Out] out int pFrameCount, [Out] out int pMissedFrames,
                [Out] out float pLastMissedUsage)
        {
            unsafe
            {
                fixed (int* pFrameCount_ptr = &pFrameCount)
                fixed (int* pMissedFrames_ptr = &pMissedFrames)
                fixed (float* pLastMissedUsage_ptr = &pLastMissedUsage)
                {
                    var retval = Delegates.wglQueryFrameTrackingI3D(pFrameCount_ptr, pMissedFrames_ptr,
                        pLastMissedUsage_ptr);
                    pFrameCount = *pFrameCount_ptr;
                    pMissedFrames = *pMissedFrames_ptr;
                    pLastMissedUsage = *pLastMissedUsage_ptr;
                    return retval;
                }
            }
        }

        [CLSCompliant(false)]
        public static
        bool wglQueryFrameTrackingI3D([Out] IntPtr pFrameCount, [Out] IntPtr pMissedFrames,
            [Out] IntPtr pLastMissedUsage)
        {
            unsafe
            {
                return Delegates.wglQueryFrameTrackingI3D((int*) pFrameCount, (int*) pMissedFrames,
                    (float*) pLastMissedUsage);
            }
        }
    }
}