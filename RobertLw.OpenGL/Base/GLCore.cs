namespace RobertLw.OpenGL.Base
{
    using System;
    using System.Runtime.InteropServices;
    using System.Security;

    partial class Gl
    {

        internal static partial class Imports
        {

            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glNewList", ExactSpelling = true)]
            internal static extern void NewList(UInt32 list, int mode);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glEndList", ExactSpelling = true)]
            internal static extern void EndList();
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glCallList", ExactSpelling = true)]
            internal static extern void CallList(UInt32 list);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glCallLists", ExactSpelling = true)]
            internal static extern void CallLists(Int32 n, int type, IntPtr lists);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glDeleteLists", ExactSpelling = true)]
            internal static extern void DeleteLists(UInt32 list, Int32 range);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glGenLists", ExactSpelling = true)]
            internal static extern Int32 GenLists(Int32 range);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glListBase", ExactSpelling = true)]
            internal static extern void ListBase(UInt32 @base);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glBegin", ExactSpelling = true)]
            internal static extern void Begin(int mode);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glBitmap", ExactSpelling = true)]
            internal static extern unsafe void Bitmap(Int32 width, Int32 height, Single xorig, Single yorig, Single xmove, Single ymove, Byte* bitmap);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glColor3b", ExactSpelling = true)]
            internal static extern void Color3b(SByte red, SByte green, SByte blue);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glColor3bv", ExactSpelling = true)]
            internal static extern unsafe void Color3bv(SByte* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glColor3d", ExactSpelling = true)]
            internal static extern void Color3d(Double red, Double green, Double blue);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glColor3dv", ExactSpelling = true)]
            internal static extern unsafe void Color3dv(Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glColor3f", ExactSpelling = true)]
            internal static extern void Color3f(Single red, Single green, Single blue);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glColor3fv", ExactSpelling = true)]
            internal static extern unsafe void Color3fv(Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glColor3i", ExactSpelling = true)]
            internal static extern void Color3i(Int32 red, Int32 green, Int32 blue);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glColor3iv", ExactSpelling = true)]
            internal static extern unsafe void Color3iv(Int32* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glColor3s", ExactSpelling = true)]
            internal static extern void Color3s(Int16 red, Int16 green, Int16 blue);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glColor3sv", ExactSpelling = true)]
            internal static extern unsafe void Color3sv(Int16* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glColor3ub", ExactSpelling = true)]
            internal static extern void Color3ub(Byte red, Byte green, Byte blue);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glColor3ubv", ExactSpelling = true)]
            internal static extern unsafe void Color3ubv(Byte* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glColor3ui", ExactSpelling = true)]
            internal static extern void Color3ui(UInt32 red, UInt32 green, UInt32 blue);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glColor3uiv", ExactSpelling = true)]
            internal static extern unsafe void Color3uiv(UInt32* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glColor3us", ExactSpelling = true)]
            internal static extern void Color3us(UInt16 red, UInt16 green, UInt16 blue);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glColor3usv", ExactSpelling = true)]
            internal static extern unsafe void Color3usv(UInt16* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glColor4b", ExactSpelling = true)]
            internal static extern void Color4b(SByte red, SByte green, SByte blue, SByte alpha);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glColor4bv", ExactSpelling = true)]
            internal static extern unsafe void Color4bv(SByte* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glColor4d", ExactSpelling = true)]
            internal static extern void Color4d(Double red, Double green, Double blue, Double alpha);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glColor4dv", ExactSpelling = true)]
            internal static extern unsafe void Color4dv(Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glColor4f", ExactSpelling = true)]
            internal static extern void Color4f(Single red, Single green, Single blue, Single alpha);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glColor4fv", ExactSpelling = true)]
            internal static extern unsafe void Color4fv(Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glColor4i", ExactSpelling = true)]
            internal static extern void Color4i(Int32 red, Int32 green, Int32 blue, Int32 alpha);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glColor4iv", ExactSpelling = true)]
            internal static extern unsafe void Color4iv(Int32* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glColor4s", ExactSpelling = true)]
            internal static extern void Color4s(Int16 red, Int16 green, Int16 blue, Int16 alpha);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glColor4sv", ExactSpelling = true)]
            internal static extern unsafe void Color4sv(Int16* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glColor4ub", ExactSpelling = true)]
            internal static extern void Color4ub(Byte red, Byte green, Byte blue, Byte alpha);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glColor4ubv", ExactSpelling = true)]
            internal static extern unsafe void Color4ubv(Byte* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glColor4ui", ExactSpelling = true)]
            internal static extern void Color4ui(UInt32 red, UInt32 green, UInt32 blue, UInt32 alpha);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glColor4uiv", ExactSpelling = true)]
            internal static extern unsafe void Color4uiv(UInt32* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glColor4us", ExactSpelling = true)]
            internal static extern void Color4us(UInt16 red, UInt16 green, UInt16 blue, UInt16 alpha);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glColor4usv", ExactSpelling = true)]
            internal static extern unsafe void Color4usv(UInt16* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glEdgeFlag", ExactSpelling = true)]
            internal static extern void EdgeFlag(Int32 flag);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glEdgeFlagv", ExactSpelling = true)]
            internal static extern unsafe void EdgeFlagv(Int32* flag);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glEnd", ExactSpelling = true)]
            internal static extern void End();
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glIndexd", ExactSpelling = true)]
            internal static extern void Indexd(Double c);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glIndexdv", ExactSpelling = true)]
            internal static extern unsafe void Indexdv(Double* c);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glIndexf", ExactSpelling = true)]
            internal static extern void Indexf(Single c);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glIndexfv", ExactSpelling = true)]
            internal static extern unsafe void Indexfv(Single* c);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glIndexi", ExactSpelling = true)]
            internal static extern void Indexi(Int32 c);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glIndexiv", ExactSpelling = true)]
            internal static extern unsafe void Indexiv(Int32* c);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glIndexs", ExactSpelling = true)]
            internal static extern void Indexs(Int16 c);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glIndexsv", ExactSpelling = true)]
            internal static extern unsafe void Indexsv(Int16* c);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glNormal3b", ExactSpelling = true)]
            internal static extern void Normal3b(SByte nx, SByte ny, SByte nz);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glNormal3bv", ExactSpelling = true)]
            internal static extern unsafe void Normal3bv(SByte* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glNormal3d", ExactSpelling = true)]
            internal static extern void Normal3d(Double nx, Double ny, Double nz);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glNormal3dv", ExactSpelling = true)]
            internal static extern unsafe void Normal3dv(Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glNormal3f", ExactSpelling = true)]
            internal static extern void Normal3f(Single nx, Single ny, Single nz);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glNormal3fv", ExactSpelling = true)]
            internal static extern unsafe void Normal3fv(Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glNormal3i", ExactSpelling = true)]
            internal static extern void Normal3i(Int32 nx, Int32 ny, Int32 nz);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glNormal3iv", ExactSpelling = true)]
            internal static extern unsafe void Normal3iv(Int32* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glNormal3s", ExactSpelling = true)]
            internal static extern void Normal3s(Int16 nx, Int16 ny, Int16 nz);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glNormal3sv", ExactSpelling = true)]
            internal static extern unsafe void Normal3sv(Int16* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glRasterPos2d", ExactSpelling = true)]
            internal static extern void RasterPos2d(Double x, Double y);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glRasterPos2dv", ExactSpelling = true)]
            internal static extern unsafe void RasterPos2dv(Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glRasterPos2f", ExactSpelling = true)]
            internal static extern void RasterPos2f(Single x, Single y);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glRasterPos2fv", ExactSpelling = true)]
            internal static extern unsafe void RasterPos2fv(Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glRasterPos2i", ExactSpelling = true)]
            internal static extern void RasterPos2i(Int32 x, Int32 y);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glRasterPos2iv", ExactSpelling = true)]
            internal static extern unsafe void RasterPos2iv(Int32* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glRasterPos2s", ExactSpelling = true)]
            internal static extern void RasterPos2s(Int16 x, Int16 y);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glRasterPos2sv", ExactSpelling = true)]
            internal static extern unsafe void RasterPos2sv(Int16* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glRasterPos3d", ExactSpelling = true)]
            internal static extern void RasterPos3d(Double x, Double y, Double z);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glRasterPos3dv", ExactSpelling = true)]
            internal static extern unsafe void RasterPos3dv(Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glRasterPos3f", ExactSpelling = true)]
            internal static extern void RasterPos3f(Single x, Single y, Single z);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glRasterPos3fv", ExactSpelling = true)]
            internal static extern unsafe void RasterPos3fv(Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glRasterPos3i", ExactSpelling = true)]
            internal static extern void RasterPos3i(Int32 x, Int32 y, Int32 z);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glRasterPos3iv", ExactSpelling = true)]
            internal static extern unsafe void RasterPos3iv(Int32* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glRasterPos3s", ExactSpelling = true)]
            internal static extern void RasterPos3s(Int16 x, Int16 y, Int16 z);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glRasterPos3sv", ExactSpelling = true)]
            internal static extern unsafe void RasterPos3sv(Int16* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glRasterPos4d", ExactSpelling = true)]
            internal static extern void RasterPos4d(Double x, Double y, Double z, Double w);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glRasterPos4dv", ExactSpelling = true)]
            internal static extern unsafe void RasterPos4dv(Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glRasterPos4f", ExactSpelling = true)]
            internal static extern void RasterPos4f(Single x, Single y, Single z, Single w);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glRasterPos4fv", ExactSpelling = true)]
            internal static extern unsafe void RasterPos4fv(Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glRasterPos4i", ExactSpelling = true)]
            internal static extern void RasterPos4i(Int32 x, Int32 y, Int32 z, Int32 w);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glRasterPos4iv", ExactSpelling = true)]
            internal static extern unsafe void RasterPos4iv(Int32* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glRasterPos4s", ExactSpelling = true)]
            internal static extern void RasterPos4s(Int16 x, Int16 y, Int16 z, Int16 w);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glRasterPos4sv", ExactSpelling = true)]
            internal static extern unsafe void RasterPos4sv(Int16* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glRectd", ExactSpelling = true)]
            internal static extern void Rectd(Double x1, Double y1, Double x2, Double y2);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glRectdv", ExactSpelling = true)]
            internal static extern unsafe void Rectdv(Double* v1, Double* v2);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glRectf", ExactSpelling = true)]
            internal static extern void Rectf(Single x1, Single y1, Single x2, Single y2);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glRectfv", ExactSpelling = true)]
            internal static extern unsafe void Rectfv(Single* v1, Single* v2);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glRecti", ExactSpelling = true)]
            internal static extern void Recti(Int32 x1, Int32 y1, Int32 x2, Int32 y2);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glRectiv", ExactSpelling = true)]
            internal static extern unsafe void Rectiv(Int32* v1, Int32* v2);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glRects", ExactSpelling = true)]
            internal static extern void Rects(Int16 x1, Int16 y1, Int16 x2, Int16 y2);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glRectsv", ExactSpelling = true)]
            internal static extern unsafe void Rectsv(Int16* v1, Int16* v2);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glTexCoord1d", ExactSpelling = true)]
            internal static extern void TexCoord1d(Double s);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glTexCoord1dv", ExactSpelling = true)]
            internal static extern unsafe void TexCoord1dv(Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glTexCoord1f", ExactSpelling = true)]
            internal static extern void TexCoord1f(Single s);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glTexCoord1fv", ExactSpelling = true)]
            internal static extern unsafe void TexCoord1fv(Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glTexCoord1i", ExactSpelling = true)]
            internal static extern void TexCoord1i(Int32 s);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glTexCoord1iv", ExactSpelling = true)]
            internal static extern unsafe void TexCoord1iv(Int32* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glTexCoord1s", ExactSpelling = true)]
            internal static extern void TexCoord1s(Int16 s);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glTexCoord1sv", ExactSpelling = true)]
            internal static extern unsafe void TexCoord1sv(Int16* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glTexCoord2d", ExactSpelling = true)]
            internal static extern void TexCoord2d(Double s, Double t);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glTexCoord2dv", ExactSpelling = true)]
            internal static extern unsafe void TexCoord2dv(Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glTexCoord2f", ExactSpelling = true)]
            internal static extern void TexCoord2f(Single s, Single t);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glTexCoord2fv", ExactSpelling = true)]
            internal static extern unsafe void TexCoord2fv(Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glTexCoord2i", ExactSpelling = true)]
            internal static extern void TexCoord2i(Int32 s, Int32 t);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glTexCoord2iv", ExactSpelling = true)]
            internal static extern unsafe void TexCoord2iv(Int32* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glTexCoord2s", ExactSpelling = true)]
            internal static extern void TexCoord2s(Int16 s, Int16 t);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glTexCoord2sv", ExactSpelling = true)]
            internal static extern unsafe void TexCoord2sv(Int16* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glTexCoord3d", ExactSpelling = true)]
            internal static extern void TexCoord3d(Double s, Double t, Double r);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glTexCoord3dv", ExactSpelling = true)]
            internal static extern unsafe void TexCoord3dv(Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glTexCoord3f", ExactSpelling = true)]
            internal static extern void TexCoord3f(Single s, Single t, Single r);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glTexCoord3fv", ExactSpelling = true)]
            internal static extern unsafe void TexCoord3fv(Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glTexCoord3i", ExactSpelling = true)]
            internal static extern void TexCoord3i(Int32 s, Int32 t, Int32 r);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glTexCoord3iv", ExactSpelling = true)]
            internal static extern unsafe void TexCoord3iv(Int32* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glTexCoord3s", ExactSpelling = true)]
            internal static extern void TexCoord3s(Int16 s, Int16 t, Int16 r);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glTexCoord3sv", ExactSpelling = true)]
            internal static extern unsafe void TexCoord3sv(Int16* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glTexCoord4d", ExactSpelling = true)]
            internal static extern void TexCoord4d(Double s, Double t, Double r, Double q);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glTexCoord4dv", ExactSpelling = true)]
            internal static extern unsafe void TexCoord4dv(Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glTexCoord4f", ExactSpelling = true)]
            internal static extern void TexCoord4f(Single s, Single t, Single r, Single q);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glTexCoord4fv", ExactSpelling = true)]
            internal static extern unsafe void TexCoord4fv(Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glTexCoord4i", ExactSpelling = true)]
            internal static extern void TexCoord4i(Int32 s, Int32 t, Int32 r, Int32 q);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glTexCoord4iv", ExactSpelling = true)]
            internal static extern unsafe void TexCoord4iv(Int32* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glTexCoord4s", ExactSpelling = true)]
            internal static extern void TexCoord4s(Int16 s, Int16 t, Int16 r, Int16 q);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glTexCoord4sv", ExactSpelling = true)]
            internal static extern unsafe void TexCoord4sv(Int16* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glVertex2d", ExactSpelling = true)]
            internal static extern void Vertex2d(Double x, Double y);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glVertex2dv", ExactSpelling = true)]
            internal static extern unsafe void Vertex2dv(Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glVertex2f", ExactSpelling = true)]
            internal static extern void Vertex2f(Single x, Single y);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glVertex2fv", ExactSpelling = true)]
            internal static extern unsafe void Vertex2fv(Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glVertex2i", ExactSpelling = true)]
            internal static extern void Vertex2i(Int32 x, Int32 y);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glVertex2iv", ExactSpelling = true)]
            internal static extern unsafe void Vertex2iv(Int32* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glVertex2s", ExactSpelling = true)]
            internal static extern void Vertex2s(Int16 x, Int16 y);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glVertex2sv", ExactSpelling = true)]
            internal static extern unsafe void Vertex2sv(Int16* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glVertex3d", ExactSpelling = true)]
            internal static extern void Vertex3d(Double x, Double y, Double z);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glVertex3dv", ExactSpelling = true)]
            internal static extern unsafe void Vertex3dv(Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glVertex3f", ExactSpelling = true)]
            internal static extern void Vertex3f(Single x, Single y, Single z);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glVertex3fv", ExactSpelling = true)]
            internal static extern unsafe void Vertex3fv(Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glVertex3i", ExactSpelling = true)]
            internal static extern void Vertex3i(Int32 x, Int32 y, Int32 z);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glVertex3iv", ExactSpelling = true)]
            internal static extern unsafe void Vertex3iv(Int32* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glVertex3s", ExactSpelling = true)]
            internal static extern void Vertex3s(Int16 x, Int16 y, Int16 z);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glVertex3sv", ExactSpelling = true)]
            internal static extern unsafe void Vertex3sv(Int16* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glVertex4d", ExactSpelling = true)]
            internal static extern void Vertex4d(Double x, Double y, Double z, Double w);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glVertex4dv", ExactSpelling = true)]
            internal static extern unsafe void Vertex4dv(Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glVertex4f", ExactSpelling = true)]
            internal static extern void Vertex4f(Single x, Single y, Single z, Single w);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glVertex4fv", ExactSpelling = true)]
            internal static extern unsafe void Vertex4fv(Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glVertex4i", ExactSpelling = true)]
            internal static extern void Vertex4i(Int32 x, Int32 y, Int32 z, Int32 w);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glVertex4iv", ExactSpelling = true)]
            internal static extern unsafe void Vertex4iv(Int32* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glVertex4s", ExactSpelling = true)]
            internal static extern void Vertex4s(Int16 x, Int16 y, Int16 z, Int16 w);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glVertex4sv", ExactSpelling = true)]
            internal static extern unsafe void Vertex4sv(Int16* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glClipPlane", ExactSpelling = true)]
            internal static extern unsafe void ClipPlane(int plane, Double* equation);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glColorMaterial", ExactSpelling = true)]
            internal static extern void ColorMaterial(int face, int mode);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glCullFace", ExactSpelling = true)]
            internal static extern void CullFace(int mode);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glFogf", ExactSpelling = true)]
            internal static extern void Fogf(int pname, Single param);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glFogfv", ExactSpelling = true)]
            internal static extern unsafe void Fogfv(int pname, Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glFogi", ExactSpelling = true)]
            internal static extern void Fogi(int pname, Int32 param);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glFogiv", ExactSpelling = true)]
            internal static extern unsafe void Fogiv(int pname, Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glFrontFace", ExactSpelling = true)]
            internal static extern void FrontFace(int mode);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glHint", ExactSpelling = true)]
            internal static extern void Hint(int target, int mode);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glLightf", ExactSpelling = true)]
            internal static extern void Lightf(int light, int pname, Single param);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glLightfv", ExactSpelling = true)]
            internal static extern unsafe void Lightfv(int light, int pname, Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glLighti", ExactSpelling = true)]
            internal static extern void Lighti(int light, int pname, Int32 param);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glLightiv", ExactSpelling = true)]
            internal static extern unsafe void Lightiv(int light, int pname, Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glLightModelf", ExactSpelling = true)]
            internal static extern void LightModelf(int pname, Single param);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glLightModelfv", ExactSpelling = true)]
            internal static extern unsafe void LightModelfv(int pname, Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glLightModeli", ExactSpelling = true)]
            internal static extern void LightModeli(int pname, Int32 param);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glLightModeliv", ExactSpelling = true)]
            internal static extern unsafe void LightModeliv(int pname, Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glLineStipple", ExactSpelling = true)]
            internal static extern void LineStipple(Int32 factor, UInt16 pattern);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glLineWidth", ExactSpelling = true)]
            internal static extern void LineWidth(Single width);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glMaterialf", ExactSpelling = true)]
            internal static extern void Materialf(int face, int pname, Single param);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glMaterialfv", ExactSpelling = true)]
            internal static extern unsafe void Materialfv(int face, int pname, Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glMateriali", ExactSpelling = true)]
            internal static extern void Materiali(int face, int pname, Int32 param);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glMaterialiv", ExactSpelling = true)]
            internal static extern unsafe void Materialiv(int face, int pname, Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glPointSize", ExactSpelling = true)]
            internal static extern void PointSize(Single size);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glPolygonMode", ExactSpelling = true)]
            internal static extern void PolygonMode(int face, int mode);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glPolygonStipple", ExactSpelling = true)]
            internal static extern unsafe void PolygonStipple(Byte* mask);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glScissor", ExactSpelling = true)]
            internal static extern void Scissor(Int32 x, Int32 y, Int32 width, Int32 height);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glShadeModel", ExactSpelling = true)]
            internal static extern void ShadeModel(int mode);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glTexParameterf", ExactSpelling = true)]
            internal static extern void TexParameterf(int target, int pname, Single param);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glTexParameterfv", ExactSpelling = true)]
            internal static extern unsafe void TexParameterfv(int target, int pname, Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glTexParameteri", ExactSpelling = true)]
            internal static extern void TexParameteri(int target, int pname, Int32 param);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glTexParameteriv", ExactSpelling = true)]
            internal static extern unsafe void TexParameteriv(int target, int pname, Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glTexImage1D", ExactSpelling = true)]
            internal static extern void TexImage1D(int target, Int32 level, int internalformat, Int32 width, Int32 border, int format, int type, IntPtr pixels);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glTexImage2D", ExactSpelling = true)]
            internal static extern void TexImage2D(int target, Int32 level, int internalformat, Int32 width, Int32 height, Int32 border, int format, int type, IntPtr pixels);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glTexEnvf", ExactSpelling = true)]
            internal static extern void TexEnvf(int target, int pname, Single param);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glTexEnvfv", ExactSpelling = true)]
            internal static extern unsafe void TexEnvfv(int target, int pname, Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glTexEnvi", ExactSpelling = true)]
            internal static extern void TexEnvi(int target, int pname, Int32 param);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glTexEnviv", ExactSpelling = true)]
            internal static extern unsafe void TexEnviv(int target, int pname, Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glTexGend", ExactSpelling = true)]
            internal static extern void TexGend(int coord, int pname, Double param);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glTexGendv", ExactSpelling = true)]
            internal static extern unsafe void TexGendv(int coord, int pname, Double* @params);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glTexGenf", ExactSpelling = true)]
            internal static extern void TexGenf(int coord, int pname, Single param);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glTexGenfv", ExactSpelling = true)]
            internal static extern unsafe void TexGenfv(int coord, int pname, Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glTexGeni", ExactSpelling = true)]
            internal static extern void TexGeni(int coord, int pname, Int32 param);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glTexGeniv", ExactSpelling = true)]
            internal static extern unsafe void TexGeniv(int coord, int pname, Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glFeedbackBuffer", ExactSpelling = true)]
            internal static extern unsafe void FeedbackBuffer(Int32 size, int type, [Out] Single* buffer);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glSelectBuffer", ExactSpelling = true)]
            internal static extern unsafe void SelectBuffer(Int32 size, [Out] UInt32* buffer);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glRenderMode", ExactSpelling = true)]
            internal static extern Int32 RenderMode(int mode);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glInitNames", ExactSpelling = true)]
            internal static extern void InitNames();
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glLoadName", ExactSpelling = true)]
            internal static extern void LoadName(UInt32 name);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glPassThrough", ExactSpelling = true)]
            internal static extern void PassThrough(Single token);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glPopName", ExactSpelling = true)]
            internal static extern void PopName();
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glPushName", ExactSpelling = true)]
            internal static extern void PushName(UInt32 name);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glDrawBuffer", ExactSpelling = true)]
            internal static extern void DrawBuffer(int mode);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glClear", ExactSpelling = true)]
            internal static extern void Clear(int mask);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glClearAccum", ExactSpelling = true)]
            internal static extern void ClearAccum(Single red, Single green, Single blue, Single alpha);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glClearIndex", ExactSpelling = true)]
            internal static extern void ClearIndex(Single c);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glClearColor", ExactSpelling = true)]
            internal static extern void ClearColor(Single red, Single green, Single blue, Single alpha);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glClearStencil", ExactSpelling = true)]
            internal static extern void ClearStencil(Int32 s);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glClearDepth", ExactSpelling = true)]
            internal static extern void ClearDepth(Double depth);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glStencilMask", ExactSpelling = true)]
            internal static extern void StencilMask(UInt32 mask);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glColorMask", ExactSpelling = true)]
            internal static extern void ColorMask(Int32 red, Int32 green, Int32 blue, Int32 alpha);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glDepthMask", ExactSpelling = true)]
            internal static extern void DepthMask(Int32 flag);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glIndexMask", ExactSpelling = true)]
            internal static extern void IndexMask(UInt32 mask);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glAccum", ExactSpelling = true)]
            internal static extern void Accum(int op, Single value);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glDisable", ExactSpelling = true)]
            internal static extern void Disable(int cap);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glEnable", ExactSpelling = true)]
            internal static extern void Enable(int cap);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glFinish", ExactSpelling = true)]
            internal static extern void Finish();
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glFlush", ExactSpelling = true)]
            internal static extern void Flush();
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glPopAttrib", ExactSpelling = true)]
            internal static extern void PopAttrib();
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glPushAttrib", ExactSpelling = true)]
            internal static extern void PushAttrib(int mask);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glMap1d", ExactSpelling = true)]
            internal static extern unsafe void Map1d(int target, Double u1, Double u2, Int32 stride, Int32 order, Double* points);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glMap1f", ExactSpelling = true)]
            internal static extern unsafe void Map1f(int target, Single u1, Single u2, Int32 stride, Int32 order, Single* points);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glMap2d", ExactSpelling = true)]
            internal static extern unsafe void Map2d(int target, Double u1, Double u2, Int32 ustride, Int32 uorder, Double v1, Double v2, Int32 vstride, Int32 vorder, Double* points);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glMap2f", ExactSpelling = true)]
            internal static extern unsafe void Map2f(int target, Single u1, Single u2, Int32 ustride, Int32 uorder, Single v1, Single v2, Int32 vstride, Int32 vorder, Single* points);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glMapGrid1d", ExactSpelling = true)]
            internal static extern void MapGrid1d(Int32 un, Double u1, Double u2);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glMapGrid1f", ExactSpelling = true)]
            internal static extern void MapGrid1f(Int32 un, Single u1, Single u2);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glMapGrid2d", ExactSpelling = true)]
            internal static extern void MapGrid2d(Int32 un, Double u1, Double u2, Int32 vn, Double v1, Double v2);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glMapGrid2f", ExactSpelling = true)]
            internal static extern void MapGrid2f(Int32 un, Single u1, Single u2, Int32 vn, Single v1, Single v2);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glEvalCoord1d", ExactSpelling = true)]
            internal static extern void EvalCoord1d(Double u);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glEvalCoord1dv", ExactSpelling = true)]
            internal static extern unsafe void EvalCoord1dv(Double* u);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glEvalCoord1f", ExactSpelling = true)]
            internal static extern void EvalCoord1f(Single u);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glEvalCoord1fv", ExactSpelling = true)]
            internal static extern unsafe void EvalCoord1fv(Single* u);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glEvalCoord2d", ExactSpelling = true)]
            internal static extern void EvalCoord2d(Double u, Double v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glEvalCoord2dv", ExactSpelling = true)]
            internal static extern unsafe void EvalCoord2dv(Double* u);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glEvalCoord2f", ExactSpelling = true)]
            internal static extern void EvalCoord2f(Single u, Single v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glEvalCoord2fv", ExactSpelling = true)]
            internal static extern unsafe void EvalCoord2fv(Single* u);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glEvalMesh1", ExactSpelling = true)]
            internal static extern void EvalMesh1(int mode, Int32 i1, Int32 i2);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glEvalPoint1", ExactSpelling = true)]
            internal static extern void EvalPoint1(Int32 i);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glEvalMesh2", ExactSpelling = true)]
            internal static extern void EvalMesh2(int mode, Int32 i1, Int32 i2, Int32 j1, Int32 j2);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glEvalPoint2", ExactSpelling = true)]
            internal static extern void EvalPoint2(Int32 i, Int32 j);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glAlphaFunc", ExactSpelling = true)]
            internal static extern void AlphaFunc(int func, Single @ref);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glBlendFunc", ExactSpelling = true)]
            internal static extern void BlendFunc(int sfactor, int dfactor);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glLogicOp", ExactSpelling = true)]
            internal static extern void LogicOp(int opcode);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glStencilFunc", ExactSpelling = true)]
            internal static extern void StencilFunc(int func, Int32 @ref, UInt32 mask);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glStencilOp", ExactSpelling = true)]
            internal static extern void StencilOp(int fail, int zfail, int zpass);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glDepthFunc", ExactSpelling = true)]
            internal static extern void DepthFunc(int func);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glPixelZoom", ExactSpelling = true)]
            internal static extern void PixelZoom(Single xfactor, Single yfactor);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glPixelTransferf", ExactSpelling = true)]
            internal static extern void PixelTransferf(int pname, Single param);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glPixelTransferi", ExactSpelling = true)]
            internal static extern void PixelTransferi(int pname, Int32 param);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glPixelStoref", ExactSpelling = true)]
            internal static extern void PixelStoref(int pname, Single param);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glPixelStorei", ExactSpelling = true)]
            internal static extern void PixelStorei(int pname, Int32 param);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glPixelMapfv", ExactSpelling = true)]
            internal static extern unsafe void PixelMapfv(int map, Int32 mapsize, Single* values);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glPixelMapuiv", ExactSpelling = true)]
            internal static extern unsafe void PixelMapuiv(int map, Int32 mapsize, UInt32* values);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glPixelMapusv", ExactSpelling = true)]
            internal static extern unsafe void PixelMapusv(int map, Int32 mapsize, UInt16* values);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glReadBuffer", ExactSpelling = true)]
            internal static extern void ReadBuffer(int mode);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glCopyPixels", ExactSpelling = true)]
            internal static extern void CopyPixels(Int32 x, Int32 y, Int32 width, Int32 height, int type);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glReadPixels", ExactSpelling = true)]
            internal static extern void ReadPixels(Int32 x, Int32 y, Int32 width, Int32 height, int format, int type, [Out] IntPtr pixels);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glDrawPixels", ExactSpelling = true)]
            internal static extern void DrawPixels(Int32 width, Int32 height, int format, int type, IntPtr pixels);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glGetBooleanv", ExactSpelling = true)]
            internal static extern unsafe void GetBooleanv(int pname, [Out] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glGetClipPlane", ExactSpelling = true)]
            internal static extern unsafe void GetClipPlane(int plane, [Out] Double* equation);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glGetDoublev", ExactSpelling = true)]
            internal static extern unsafe void GetDoublev(int pname, [Out] Double* @params);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glGetError", ExactSpelling = true)]
            internal static extern int GetError();
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glGetFloatv", ExactSpelling = true)]
            internal static extern unsafe void GetFloatv(int pname, [Out] Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glGetIntegerv", ExactSpelling = true)]
            internal static extern unsafe void GetIntegerv(int pname, [Out] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glGetLightfv", ExactSpelling = true)]
            internal static extern unsafe void GetLightfv(int light, int pname, [Out] Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glGetLightiv", ExactSpelling = true)]
            internal static extern unsafe void GetLightiv(int light, int pname, [Out] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glGetMapdv", ExactSpelling = true)]
            internal static extern unsafe void GetMapdv(int target, int query, [Out] Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glGetMapfv", ExactSpelling = true)]
            internal static extern unsafe void GetMapfv(int target, int query, [Out] Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glGetMapiv", ExactSpelling = true)]
            internal static extern unsafe void GetMapiv(int target, int query, [Out] Int32* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glGetMaterialfv", ExactSpelling = true)]
            internal static extern unsafe void GetMaterialfv(int face, int pname, [Out] Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glGetMaterialiv", ExactSpelling = true)]
            internal static extern unsafe void GetMaterialiv(int face, int pname, [Out] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glGetPixelMapfv", ExactSpelling = true)]
            internal static extern unsafe void GetPixelMapfv(int map, [Out] Single* values);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glGetPixelMapuiv", ExactSpelling = true)]
            internal static extern unsafe void GetPixelMapuiv(int map, [Out] UInt32* values);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glGetPixelMapusv", ExactSpelling = true)]
            internal static extern unsafe void GetPixelMapusv(int map, [Out] UInt16* values);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glGetPolygonStipple", ExactSpelling = true)]
            internal static extern unsafe void GetPolygonStipple([Out] Byte* mask);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glGetString", ExactSpelling = true)]
            internal static extern IntPtr GetString(int name);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glGetTexEnvfv", ExactSpelling = true)]
            internal static extern unsafe void GetTexEnvfv(int target, int pname, [Out] Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glGetTexEnviv", ExactSpelling = true)]
            internal static extern unsafe void GetTexEnviv(int target, int pname, [Out] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glGetTexGendv", ExactSpelling = true)]
            internal static extern unsafe void GetTexGendv(int coord, int pname, [Out] Double* @params);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glGetTexGenfv", ExactSpelling = true)]
            internal static extern unsafe void GetTexGenfv(int coord, int pname, [Out] Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glGetTexGeniv", ExactSpelling = true)]
            internal static extern unsafe void GetTexGeniv(int coord, int pname, [Out] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glGetTexImage", ExactSpelling = true)]
            internal static extern void GetTexImage(int target, Int32 level, int format, int type, [Out] IntPtr pixels);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glGetTexParameterfv", ExactSpelling = true)]
            internal static extern unsafe void GetTexParameterfv(int target, int pname, [Out] Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glGetTexParameteriv", ExactSpelling = true)]
            internal static extern unsafe void GetTexParameteriv(int target, int pname, [Out] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glGetTexLevelParameterfv", ExactSpelling = true)]
            internal static extern unsafe void GetTexLevelParameterfv(int target, Int32 level, int pname, [Out] Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glGetTexLevelParameteriv", ExactSpelling = true)]
            internal static extern unsafe void GetTexLevelParameteriv(int target, Int32 level, int pname, [Out] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glIsEnabled", ExactSpelling = true)]
            internal static extern Int32 IsEnabled(int cap);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glIsList", ExactSpelling = true)]
            internal static extern Int32 IsList(UInt32 list);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glDepthRange", ExactSpelling = true)]
            internal static extern void DepthRange(Double near, Double far);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glFrustum", ExactSpelling = true)]
            internal static extern void Frustum(Double left, Double right, Double bottom, Double top, Double zNear, Double zFar);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glLoadIdentity", ExactSpelling = true)]
            internal static extern void LoadIdentity();
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glLoadMatrixf", ExactSpelling = true)]
            internal static extern unsafe void LoadMatrixf(Single* m);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glLoadMatrixd", ExactSpelling = true)]
            internal static extern unsafe void LoadMatrixd(Double* m);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glMatrixMode", ExactSpelling = true)]
            internal static extern void MatrixMode(int mode);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glMultMatrixf", ExactSpelling = true)]
            internal static extern unsafe void MultMatrixf(Single* m);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glMultMatrixd", ExactSpelling = true)]
            internal static extern unsafe void MultMatrixd(Double* m);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glOrtho", ExactSpelling = true)]
            internal static extern void Ortho(Double left, Double right, Double bottom, Double top, Double zNear, Double zFar);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glPopMatrix", ExactSpelling = true)]
            internal static extern void PopMatrix();
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glPushMatrix", ExactSpelling = true)]
            internal static extern void PushMatrix();
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glRotated", ExactSpelling = true)]
            internal static extern void Rotated(Double angle, Double x, Double y, Double z);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glRotatef", ExactSpelling = true)]
            internal static extern void Rotatef(Single angle, Single x, Single y, Single z);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glScaled", ExactSpelling = true)]
            internal static extern void Scaled(Double x, Double y, Double z);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glScalef", ExactSpelling = true)]
            internal static extern void Scalef(Single x, Single y, Single z);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glTranslated", ExactSpelling = true)]
            internal static extern void Translated(Double x, Double y, Double z);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glTranslatef", ExactSpelling = true)]
            internal static extern void Translatef(Single x, Single y, Single z);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glViewport", ExactSpelling = true)]
            internal static extern void Viewport(Int32 x, Int32 y, Int32 width, Int32 height);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glArrayElement", ExactSpelling = true)]
            internal static extern void ArrayElement(Int32 i);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glColorPointer", ExactSpelling = true)]
            internal static extern void ColorPointer(Int32 size, int type, Int32 stride, IntPtr pointer);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glDisableClientState", ExactSpelling = true)]
            internal static extern void DisableClientState(int array);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glDrawArrays", ExactSpelling = true)]
            internal static extern void DrawArrays(int mode, Int32 first, Int32 count);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glDrawElements", ExactSpelling = true)]
            internal static extern void DrawElements(int mode, Int32 count, int type, IntPtr indices);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glEdgeFlagPointer", ExactSpelling = true)]
            internal static extern void EdgeFlagPointer(Int32 stride, IntPtr pointer);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glEnableClientState", ExactSpelling = true)]
            internal static extern void EnableClientState(int array);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glGetPointerv", ExactSpelling = true)]
            internal static extern void GetPointerv(int pname, [Out] IntPtr @params);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glIndexPointer", ExactSpelling = true)]
            internal static extern void IndexPointer(int type, Int32 stride, IntPtr pointer);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glInterleavedArrays", ExactSpelling = true)]
            internal static extern void InterleavedArrays(int format, Int32 stride, IntPtr pointer);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glNormalPointer", ExactSpelling = true)]
            internal static extern void NormalPointer(int type, Int32 stride, IntPtr pointer);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glTexCoordPointer", ExactSpelling = true)]
            internal static extern void TexCoordPointer(Int32 size, int type, Int32 stride, IntPtr pointer);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glVertexPointer", ExactSpelling = true)]
            internal static extern void VertexPointer(Int32 size, int type, Int32 stride, IntPtr pointer);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glPolygonOffset", ExactSpelling = true)]
            internal static extern void PolygonOffset(Single factor, Single units);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glCopyTexImage1D", ExactSpelling = true)]
            internal static extern void CopyTexImage1D(int target, Int32 level, int internalformat, Int32 x, Int32 y, Int32 width, Int32 border);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glCopyTexImage2D", ExactSpelling = true)]
            internal static extern void CopyTexImage2D(int target, Int32 level, int internalformat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glCopyTexSubImage1D", ExactSpelling = true)]
            internal static extern void CopyTexSubImage1D(int target, Int32 level, Int32 xoffset, Int32 x, Int32 y, Int32 width);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glCopyTexSubImage2D", ExactSpelling = true)]
            internal static extern void CopyTexSubImage2D(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glTexSubImage1D", ExactSpelling = true)]
            internal static extern void TexSubImage1D(int target, Int32 level, Int32 xoffset, Int32 width, int format, int type, IntPtr pixels);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glTexSubImage2D", ExactSpelling = true)]
            internal static extern void TexSubImage2D(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, int format, int type, IntPtr pixels);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glAreTexturesResident", ExactSpelling = true)]
            internal static extern unsafe Int32 AreTexturesResident(Int32 n, UInt32* textures, [Out] Int32* residences);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glBindTexture", ExactSpelling = true)]
            internal static extern void BindTexture(int target, UInt32 texture);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glDeleteTextures", ExactSpelling = true)]
            internal static extern unsafe void DeleteTextures(Int32 n, UInt32* textures);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glGenTextures", ExactSpelling = true)]
            internal static extern unsafe void GenTextures(Int32 n, [Out] UInt32* textures);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glIsTexture", ExactSpelling = true)]
            internal static extern Int32 IsTexture(UInt32 texture);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glPrioritizeTextures", ExactSpelling = true)]
            internal static extern unsafe void PrioritizeTextures(Int32 n, UInt32* textures, Single* priorities);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glIndexub", ExactSpelling = true)]
            internal static extern void Indexub(Byte c);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glIndexubv", ExactSpelling = true)]
            internal static extern unsafe void Indexubv(Byte* c);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glPopClientAttrib", ExactSpelling = true)]
            internal static extern void PopClientAttrib();
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glPushClientAttrib", ExactSpelling = true)]
            internal static extern void PushClientAttrib(int mask);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glBlendColor", ExactSpelling = true)]
            internal static extern void BlendColor(Single red, Single green, Single blue, Single alpha);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glBlendEquation", ExactSpelling = true)]
            internal static extern void BlendEquation(int mode);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glDrawRangeElements", ExactSpelling = true)]
            internal static extern void DrawRangeElements(int mode, UInt32 start, UInt32 end, Int32 count, int type, IntPtr indices);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glColorTable", ExactSpelling = true)]
            internal static extern void ColorTable(int target, int internalformat, Int32 width, int format, int type, IntPtr table);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glColorTableParameterfv", ExactSpelling = true)]
            internal static extern unsafe void ColorTableParameterfv(int target, int pname, Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glColorTableParameteriv", ExactSpelling = true)]
            internal static extern unsafe void ColorTableParameteriv(int target, int pname, Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glCopyColorTable", ExactSpelling = true)]
            internal static extern void CopyColorTable(int target, int internalformat, Int32 x, Int32 y, Int32 width);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glGetColorTable", ExactSpelling = true)]
            internal static extern void GetColorTable(int target, int format, int type, [Out] IntPtr table);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glGetColorTableParameterfv", ExactSpelling = true)]
            internal static extern unsafe void GetColorTableParameterfv(int target, int pname, [Out] Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glGetColorTableParameteriv", ExactSpelling = true)]
            internal static extern unsafe void GetColorTableParameteriv(int target, int pname, [Out] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glColorSubTable", ExactSpelling = true)]
            internal static extern void ColorSubTable(int target, Int32 start, Int32 count, int format, int type, IntPtr data);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glCopyColorSubTable", ExactSpelling = true)]
            internal static extern void CopyColorSubTable(int target, Int32 start, Int32 x, Int32 y, Int32 width);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glConvolutionFilter1D", ExactSpelling = true)]
            internal static extern void ConvolutionFilter1D(int target, int internalformat, Int32 width, int format, int type, IntPtr image);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glConvolutionFilter2D", ExactSpelling = true)]
            internal static extern void ConvolutionFilter2D(int target, int internalformat, Int32 width, Int32 height, int format, int type, IntPtr image);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glConvolutionParameterf", ExactSpelling = true)]
            internal static extern void ConvolutionParameterf(int target, int pname, Single @params);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glConvolutionParameterfv", ExactSpelling = true)]
            internal static extern unsafe void ConvolutionParameterfv(int target, int pname, Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glConvolutionParameteri", ExactSpelling = true)]
            internal static extern void ConvolutionParameteri(int target, int pname, Int32 @params);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glConvolutionParameteriv", ExactSpelling = true)]
            internal static extern unsafe void ConvolutionParameteriv(int target, int pname, Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glCopyConvolutionFilter1D", ExactSpelling = true)]
            internal static extern void CopyConvolutionFilter1D(int target, int internalformat, Int32 x, Int32 y, Int32 width);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glCopyConvolutionFilter2D", ExactSpelling = true)]
            internal static extern void CopyConvolutionFilter2D(int target, int internalformat, Int32 x, Int32 y, Int32 width, Int32 height);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glGetConvolutionFilter", ExactSpelling = true)]
            internal static extern void GetConvolutionFilter(int target, int format, int type, [Out] IntPtr image);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glGetConvolutionParameterfv", ExactSpelling = true)]
            internal static extern unsafe void GetConvolutionParameterfv(int target, int pname, [Out] Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glGetConvolutionParameteriv", ExactSpelling = true)]
            internal static extern unsafe void GetConvolutionParameteriv(int target, int pname, [Out] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glGetSeparableFilter", ExactSpelling = true)]
            internal static extern void GetSeparableFilter(int target, int format, int type, [Out] IntPtr row, [Out] IntPtr column, [Out] IntPtr span);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glSeparableFilter2D", ExactSpelling = true)]
            internal static extern void SeparableFilter2D(int target, int internalformat, Int32 width, Int32 height, int format, int type, IntPtr row, IntPtr column);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glGetHistogram", ExactSpelling = true)]
            internal static extern void GetHistogram(int target, Int32 reset, int format, int type, [Out] IntPtr values);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glGetHistogramParameterfv", ExactSpelling = true)]
            internal static extern unsafe void GetHistogramParameterfv(int target, int pname, [Out] Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glGetHistogramParameteriv", ExactSpelling = true)]
            internal static extern unsafe void GetHistogramParameteriv(int target, int pname, [Out] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glGetMinmax", ExactSpelling = true)]
            internal static extern void GetMinmax(int target, Int32 reset, int format, int type, [Out] IntPtr values);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glGetMinmaxParameterfv", ExactSpelling = true)]
            internal static extern unsafe void GetMinmaxParameterfv(int target, int pname, [Out] Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glGetMinmaxParameteriv", ExactSpelling = true)]
            internal static extern unsafe void GetMinmaxParameteriv(int target, int pname, [Out] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glHistogram", ExactSpelling = true)]
            internal static extern void Histogram(int target, Int32 width, int internalformat, Int32 sink);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glMinmax", ExactSpelling = true)]
            internal static extern void Minmax(int target, int internalformat, Int32 sink);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glResetHistogram", ExactSpelling = true)]
            internal static extern void ResetHistogram(int target);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glResetMinmax", ExactSpelling = true)]
            internal static extern void ResetMinmax(int target);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glTexImage3D", ExactSpelling = true)]
            internal static extern void TexImage3D(int target, Int32 level, int internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, int format, int type, IntPtr pixels);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glTexSubImage3D", ExactSpelling = true)]
            internal static extern void TexSubImage3D(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, int format, int type, IntPtr pixels);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glCopyTexSubImage3D", ExactSpelling = true)]
            internal static extern void CopyTexSubImage3D(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 x, Int32 y, Int32 width, Int32 height);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glActiveTexture", ExactSpelling = true)]
            internal static extern void ActiveTexture(int texture);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glClientActiveTexture", ExactSpelling = true)]
            internal static extern void ClientActiveTexture(int texture);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glMultiTexCoord1d", ExactSpelling = true)]
            internal static extern void MultiTexCoord1d(int target, Double s);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glMultiTexCoord1dv", ExactSpelling = true)]
            internal static extern unsafe void MultiTexCoord1dv(int target, Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glMultiTexCoord1f", ExactSpelling = true)]
            internal static extern void MultiTexCoord1f(int target, Single s);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glMultiTexCoord1fv", ExactSpelling = true)]
            internal static extern unsafe void MultiTexCoord1fv(int target, Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glMultiTexCoord1i", ExactSpelling = true)]
            internal static extern void MultiTexCoord1i(int target, Int32 s);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glMultiTexCoord1iv", ExactSpelling = true)]
            internal static extern unsafe void MultiTexCoord1iv(int target, Int32* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glMultiTexCoord1s", ExactSpelling = true)]
            internal static extern void MultiTexCoord1s(int target, Int16 s);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glMultiTexCoord1sv", ExactSpelling = true)]
            internal static extern unsafe void MultiTexCoord1sv(int target, Int16* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glMultiTexCoord2d", ExactSpelling = true)]
            internal static extern void MultiTexCoord2d(int target, Double s, Double t);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glMultiTexCoord2dv", ExactSpelling = true)]
            internal static extern unsafe void MultiTexCoord2dv(int target, Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glMultiTexCoord2f", ExactSpelling = true)]
            internal static extern void MultiTexCoord2f(int target, Single s, Single t);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glMultiTexCoord2fv", ExactSpelling = true)]
            internal static extern unsafe void MultiTexCoord2fv(int target, Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glMultiTexCoord2i", ExactSpelling = true)]
            internal static extern void MultiTexCoord2i(int target, Int32 s, Int32 t);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glMultiTexCoord2iv", ExactSpelling = true)]
            internal static extern unsafe void MultiTexCoord2iv(int target, Int32* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glMultiTexCoord2s", ExactSpelling = true)]
            internal static extern void MultiTexCoord2s(int target, Int16 s, Int16 t);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glMultiTexCoord2sv", ExactSpelling = true)]
            internal static extern unsafe void MultiTexCoord2sv(int target, Int16* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glMultiTexCoord3d", ExactSpelling = true)]
            internal static extern void MultiTexCoord3d(int target, Double s, Double t, Double r);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glMultiTexCoord3dv", ExactSpelling = true)]
            internal static extern unsafe void MultiTexCoord3dv(int target, Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glMultiTexCoord3f", ExactSpelling = true)]
            internal static extern void MultiTexCoord3f(int target, Single s, Single t, Single r);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glMultiTexCoord3fv", ExactSpelling = true)]
            internal static extern unsafe void MultiTexCoord3fv(int target, Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glMultiTexCoord3i", ExactSpelling = true)]
            internal static extern void MultiTexCoord3i(int target, Int32 s, Int32 t, Int32 r);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glMultiTexCoord3iv", ExactSpelling = true)]
            internal static extern unsafe void MultiTexCoord3iv(int target, Int32* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glMultiTexCoord3s", ExactSpelling = true)]
            internal static extern void MultiTexCoord3s(int target, Int16 s, Int16 t, Int16 r);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glMultiTexCoord3sv", ExactSpelling = true)]
            internal static extern unsafe void MultiTexCoord3sv(int target, Int16* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glMultiTexCoord4d", ExactSpelling = true)]
            internal static extern void MultiTexCoord4d(int target, Double s, Double t, Double r, Double q);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glMultiTexCoord4dv", ExactSpelling = true)]
            internal static extern unsafe void MultiTexCoord4dv(int target, Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glMultiTexCoord4f", ExactSpelling = true)]
            internal static extern void MultiTexCoord4f(int target, Single s, Single t, Single r, Single q);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glMultiTexCoord4fv", ExactSpelling = true)]
            internal static extern unsafe void MultiTexCoord4fv(int target, Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glMultiTexCoord4i", ExactSpelling = true)]
            internal static extern void MultiTexCoord4i(int target, Int32 s, Int32 t, Int32 r, Int32 q);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glMultiTexCoord4iv", ExactSpelling = true)]
            internal static extern unsafe void MultiTexCoord4iv(int target, Int32* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glMultiTexCoord4s", ExactSpelling = true)]
            internal static extern void MultiTexCoord4s(int target, Int16 s, Int16 t, Int16 r, Int16 q);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glMultiTexCoord4sv", ExactSpelling = true)]
            internal static extern unsafe void MultiTexCoord4sv(int target, Int16* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glLoadTransposeMatrixf", ExactSpelling = true)]
            internal static extern unsafe void LoadTransposeMatrixf(Single* m);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glLoadTransposeMatrixd", ExactSpelling = true)]
            internal static extern unsafe void LoadTransposeMatrixd(Double* m);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glMultTransposeMatrixf", ExactSpelling = true)]
            internal static extern unsafe void MultTransposeMatrixf(Single* m);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glMultTransposeMatrixd", ExactSpelling = true)]
            internal static extern unsafe void MultTransposeMatrixd(Double* m);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glSampleCoverage", ExactSpelling = true)]
            internal static extern void SampleCoverage(Single value, Int32 invert);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glCompressedTexImage3D", ExactSpelling = true)]
            internal static extern void CompressedTexImage3D(int target, Int32 level, int internalformat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 imageSize, IntPtr data);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glCompressedTexImage2D", ExactSpelling = true)]
            internal static extern void CompressedTexImage2D(int target, Int32 level, int internalformat, Int32 width, Int32 height, Int32 border, Int32 imageSize, IntPtr data);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glCompressedTexImage1D", ExactSpelling = true)]
            internal static extern void CompressedTexImage1D(int target, Int32 level, int internalformat, Int32 width, Int32 border, Int32 imageSize, IntPtr data);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glCompressedTexSubImage3D", ExactSpelling = true)]
            internal static extern void CompressedTexSubImage3D(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, int format, Int32 imageSize, IntPtr data);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glCompressedTexSubImage2D", ExactSpelling = true)]
            internal static extern void CompressedTexSubImage2D(int target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, int format, Int32 imageSize, IntPtr data);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glCompressedTexSubImage1D", ExactSpelling = true)]
            internal static extern void CompressedTexSubImage1D(int target, Int32 level, Int32 xoffset, Int32 width, int format, Int32 imageSize, IntPtr data);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glGetCompressedTexImage", ExactSpelling = true)]
            internal static extern void GetCompressedTexImage(int target, Int32 level, [Out] IntPtr img);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glBlendFuncSeparate", ExactSpelling = true)]
            internal static extern void BlendFuncSeparate(int sfactorRGB, int dfactorRGB, int sfactorAlpha, int dfactorAlpha);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glFogCoordf", ExactSpelling = true)]
            internal static extern void FogCoordf(Single coord);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glFogCoordfv", ExactSpelling = true)]
            internal static extern unsafe void FogCoordfv(Single* coord);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glFogCoordd", ExactSpelling = true)]
            internal static extern void FogCoordd(Double coord);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glFogCoorddv", ExactSpelling = true)]
            internal static extern unsafe void FogCoorddv(Double* coord);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glFogCoordPointer", ExactSpelling = true)]
            internal static extern void FogCoordPointer(int type, Int32 stride, IntPtr pointer);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glMultiDrawArrays", ExactSpelling = true)]
            internal static extern unsafe void MultiDrawArrays(int mode, [Out] Int32* first, [Out] Int32* count, Int32 primcount);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glMultiDrawElements", ExactSpelling = true)]
            internal static extern unsafe void MultiDrawElements(int mode, Int32* count, int type, IntPtr indices, Int32 primcount);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glPointParameterf", ExactSpelling = true)]
            internal static extern void PointParameterf(int pname, Single param);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glPointParameterfv", ExactSpelling = true)]
            internal static extern unsafe void PointParameterfv(int pname, Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glPointParameteri", ExactSpelling = true)]
            internal static extern void PointParameteri(int pname, Int32 param);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glPointParameteriv", ExactSpelling = true)]
            internal static extern unsafe void PointParameteriv(int pname, Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glSecondaryColor3b", ExactSpelling = true)]
            internal static extern void SecondaryColor3b(SByte red, SByte green, SByte blue);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glSecondaryColor3bv", ExactSpelling = true)]
            internal static extern unsafe void SecondaryColor3bv(SByte* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glSecondaryColor3d", ExactSpelling = true)]
            internal static extern void SecondaryColor3d(Double red, Double green, Double blue);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glSecondaryColor3dv", ExactSpelling = true)]
            internal static extern unsafe void SecondaryColor3dv(Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glSecondaryColor3f", ExactSpelling = true)]
            internal static extern void SecondaryColor3f(Single red, Single green, Single blue);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glSecondaryColor3fv", ExactSpelling = true)]
            internal static extern unsafe void SecondaryColor3fv(Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glSecondaryColor3i", ExactSpelling = true)]
            internal static extern void SecondaryColor3i(Int32 red, Int32 green, Int32 blue);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glSecondaryColor3iv", ExactSpelling = true)]
            internal static extern unsafe void SecondaryColor3iv(Int32* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glSecondaryColor3s", ExactSpelling = true)]
            internal static extern void SecondaryColor3s(Int16 red, Int16 green, Int16 blue);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glSecondaryColor3sv", ExactSpelling = true)]
            internal static extern unsafe void SecondaryColor3sv(Int16* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glSecondaryColor3ub", ExactSpelling = true)]
            internal static extern void SecondaryColor3ub(Byte red, Byte green, Byte blue);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glSecondaryColor3ubv", ExactSpelling = true)]
            internal static extern unsafe void SecondaryColor3ubv(Byte* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glSecondaryColor3ui", ExactSpelling = true)]
            internal static extern void SecondaryColor3ui(UInt32 red, UInt32 green, UInt32 blue);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glSecondaryColor3uiv", ExactSpelling = true)]
            internal static extern unsafe void SecondaryColor3uiv(UInt32* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glSecondaryColor3us", ExactSpelling = true)]
            internal static extern void SecondaryColor3us(UInt16 red, UInt16 green, UInt16 blue);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glSecondaryColor3usv", ExactSpelling = true)]
            internal static extern unsafe void SecondaryColor3usv(UInt16* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glSecondaryColorPointer", ExactSpelling = true)]
            internal static extern void SecondaryColorPointer(Int32 size, int type, Int32 stride, IntPtr pointer);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glWindowPos2d", ExactSpelling = true)]
            internal static extern void WindowPos2d(Double x, Double y);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glWindowPos2dv", ExactSpelling = true)]
            internal static extern unsafe void WindowPos2dv(Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glWindowPos2f", ExactSpelling = true)]
            internal static extern void WindowPos2f(Single x, Single y);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glWindowPos2fv", ExactSpelling = true)]
            internal static extern unsafe void WindowPos2fv(Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glWindowPos2i", ExactSpelling = true)]
            internal static extern void WindowPos2i(Int32 x, Int32 y);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glWindowPos2iv", ExactSpelling = true)]
            internal static extern unsafe void WindowPos2iv(Int32* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glWindowPos2s", ExactSpelling = true)]
            internal static extern void WindowPos2s(Int16 x, Int16 y);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glWindowPos2sv", ExactSpelling = true)]
            internal static extern unsafe void WindowPos2sv(Int16* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glWindowPos3d", ExactSpelling = true)]
            internal static extern void WindowPos3d(Double x, Double y, Double z);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glWindowPos3dv", ExactSpelling = true)]
            internal static extern unsafe void WindowPos3dv(Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glWindowPos3f", ExactSpelling = true)]
            internal static extern void WindowPos3f(Single x, Single y, Single z);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glWindowPos3fv", ExactSpelling = true)]
            internal static extern unsafe void WindowPos3fv(Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glWindowPos3i", ExactSpelling = true)]
            internal static extern void WindowPos3i(Int32 x, Int32 y, Int32 z);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glWindowPos3iv", ExactSpelling = true)]
            internal static extern unsafe void WindowPos3iv(Int32* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glWindowPos3s", ExactSpelling = true)]
            internal static extern void WindowPos3s(Int16 x, Int16 y, Int16 z);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glWindowPos3sv", ExactSpelling = true)]
            internal static extern unsafe void WindowPos3sv(Int16* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glGenQueries", ExactSpelling = true)]
            internal static extern unsafe void GenQueries(Int32 n, [Out] UInt32* ids);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glDeleteQueries", ExactSpelling = true)]
            internal static extern unsafe void DeleteQueries(Int32 n, UInt32* ids);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glIsQuery", ExactSpelling = true)]
            internal static extern Int32 IsQuery(UInt32 id);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glBeginQuery", ExactSpelling = true)]
            internal static extern void BeginQuery(int target, UInt32 id);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glEndQuery", ExactSpelling = true)]
            internal static extern void EndQuery(int target);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glGetQueryiv", ExactSpelling = true)]
            internal static extern unsafe void GetQueryiv(int target, int pname, [Out] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glGetQueryObjectiv", ExactSpelling = true)]
            internal static extern unsafe void GetQueryObjectiv(UInt32 id, int pname, [Out] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glGetQueryObjectuiv", ExactSpelling = true)]
            internal static extern unsafe void GetQueryObjectuiv(UInt32 id, int pname, [Out] UInt32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glBindBuffer", ExactSpelling = true)]
            internal static extern void BindBuffer(int target, UInt32 buffer);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glDeleteBuffers", ExactSpelling = true)]
            internal static extern unsafe void DeleteBuffers(Int32 n, UInt32* buffers);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glGenBuffers", ExactSpelling = true)]
            internal static extern unsafe void GenBuffers(Int32 n, [Out] UInt32* buffers);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glIsBuffer", ExactSpelling = true)]
            internal static extern Int32 IsBuffer(UInt32 buffer);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glBufferData", ExactSpelling = true)]
            internal static extern void BufferData(int target, IntPtr size, IntPtr data, int usage);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glBufferSubData", ExactSpelling = true)]
            internal static extern void BufferSubData(int target, IntPtr offset, IntPtr size, IntPtr data);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glGetBufferSubData", ExactSpelling = true)]
            internal static extern void GetBufferSubData(int target, IntPtr offset, IntPtr size, [Out] IntPtr data);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glMapBuffer", ExactSpelling = true)]
            internal static extern IntPtr MapBuffer(int target, int access);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glUnmapBuffer", ExactSpelling = true)]
            internal static extern Int32 UnmapBuffer(int target);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glGetBufferParameteriv", ExactSpelling = true)]
            internal static extern unsafe void GetBufferParameteriv(int target, int pname, [Out] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glGetBufferPointerv", ExactSpelling = true)]
            internal static extern void GetBufferPointerv(int target, int pname, [Out] IntPtr @params);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glBlendEquationSeparate", ExactSpelling = true)]
            internal static extern void BlendEquationSeparate(int modeRGB, int modeAlpha);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glDrawBuffers", ExactSpelling = true)]
            internal static extern unsafe void DrawBuffers(Int32 n, int* bufs);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glStencilOpSeparate", ExactSpelling = true)]
            internal static extern void StencilOpSeparate(int face, int sfail, int dpfail, int dppass);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glStencilFuncSeparate", ExactSpelling = true)]
            internal static extern void StencilFuncSeparate(int frontfunc, int backfunc, Int32 @ref, UInt32 mask);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glStencilMaskSeparate", ExactSpelling = true)]
            internal static extern void StencilMaskSeparate(int face, UInt32 mask);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glAttachShader", ExactSpelling = true)]
            internal static extern void AttachShader(UInt32 program, UInt32 shader);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glBindAttribLocation", ExactSpelling = true)]
            internal static extern void BindAttribLocation(UInt32 program, UInt32 index, String name);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glCompileShader", ExactSpelling = true)]
            internal static extern void CompileShader(UInt32 shader);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glCreateProgram", ExactSpelling = true)]
            internal static extern Int32 CreateProgram();
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glCreateShader", ExactSpelling = true)]
            internal static extern Int32 CreateShader(int type);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glDeleteProgram", ExactSpelling = true)]
            internal static extern void DeleteProgram(UInt32 program);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glDeleteShader", ExactSpelling = true)]
            internal static extern void DeleteShader(UInt32 shader);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glDetachShader", ExactSpelling = true)]
            internal static extern void DetachShader(UInt32 program, UInt32 shader);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glDisableVertexAttribArray", ExactSpelling = true)]
            internal static extern void DisableVertexAttribArray(UInt32 index);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glEnableVertexAttribArray", ExactSpelling = true)]
            internal static extern void EnableVertexAttribArray(UInt32 index);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glGetActiveAttrib", ExactSpelling = true)]
            internal static extern unsafe void GetActiveAttrib(UInt32 program, UInt32 index, Int32 bufSize, [Out] Int32* length, [Out] Int32* size, [Out] int* type, [Out] System.Text.StringBuilder name);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glGetActiveUniform", ExactSpelling = true)]
            internal static extern unsafe void GetActiveUniform(UInt32 program, UInt32 index, Int32 bufSize, [Out] Int32* length, [Out] Int32* size, [Out] int* type, [Out] System.Text.StringBuilder name);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glGetAttachedShaders", ExactSpelling = true)]
            internal static extern unsafe void GetAttachedShaders(UInt32 program, Int32 maxCount, [Out] Int32* count, [Out] UInt32* obj);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glGetAttribLocation", ExactSpelling = true)]
            internal static extern Int32 GetAttribLocation(UInt32 program, String name);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glGetProgramiv", ExactSpelling = true)]
            internal static extern unsafe void GetProgramiv(UInt32 program, int pname, [Out] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glGetProgramInfoLog", ExactSpelling = true)]
            internal static extern unsafe void GetProgramInfoLog(UInt32 program, Int32 bufSize, [Out] Int32* length, [Out] System.Text.StringBuilder infoLog);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glGetShaderiv", ExactSpelling = true)]
            internal static extern unsafe void GetShaderiv(UInt32 shader, int pname, [Out] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glGetShaderInfoLog", ExactSpelling = true)]
            internal static extern unsafe void GetShaderInfoLog(UInt32 shader, Int32 bufSize, [Out] Int32* length, [Out] System.Text.StringBuilder infoLog);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glGetShaderSource", ExactSpelling = true)]
            internal static extern unsafe void GetShaderSource(UInt32 shader, Int32 bufSize, [Out] Int32* length, [Out] System.Text.StringBuilder[] source);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glGetUniformLocation", ExactSpelling = true)]
            internal static extern Int32 GetUniformLocation(UInt32 program, String name);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glGetUniformfv", ExactSpelling = true)]
            internal static extern unsafe void GetUniformfv(UInt32 program, Int32 location, [Out] Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glGetUniformiv", ExactSpelling = true)]
            internal static extern unsafe void GetUniformiv(UInt32 program, Int32 location, [Out] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glGetVertexAttribdv", ExactSpelling = true)]
            internal static extern unsafe void GetVertexAttribdv(UInt32 index, int pname, [Out] Double* @params);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glGetVertexAttribfv", ExactSpelling = true)]
            internal static extern unsafe void GetVertexAttribfv(UInt32 index, int pname, [Out] Single* @params);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glGetVertexAttribiv", ExactSpelling = true)]
            internal static extern unsafe void GetVertexAttribiv(UInt32 index, int pname, [Out] Int32* @params);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glGetVertexAttribPointerv", ExactSpelling = true)]
            internal static extern void GetVertexAttribPointerv(UInt32 index, int pname, [Out] IntPtr pointer);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glIsProgram", ExactSpelling = true)]
            internal static extern Int32 IsProgram(UInt32 program);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glIsShader", ExactSpelling = true)]
            internal static extern Int32 IsShader(UInt32 shader);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glLinkProgram", ExactSpelling = true)]
            internal static extern void LinkProgram(UInt32 program);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glShaderSource", ExactSpelling = true)]
            internal static extern unsafe void ShaderSource(UInt32 shader, Int32 count, String[] @string, Int32* length);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glUseProgram", ExactSpelling = true)]
            internal static extern void UseProgram(UInt32 program);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glUniform1f", ExactSpelling = true)]
            internal static extern void Uniform1f(Int32 location, Single v0);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glUniform2f", ExactSpelling = true)]
            internal static extern void Uniform2f(Int32 location, Single v0, Single v1);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glUniform3f", ExactSpelling = true)]
            internal static extern void Uniform3f(Int32 location, Single v0, Single v1, Single v2);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glUniform4f", ExactSpelling = true)]
            internal static extern void Uniform4f(Int32 location, Single v0, Single v1, Single v2, Single v3);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glUniform1i", ExactSpelling = true)]
            internal static extern void Uniform1i(Int32 location, Int32 v0);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glUniform2i", ExactSpelling = true)]
            internal static extern void Uniform2i(Int32 location, Int32 v0, Int32 v1);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glUniform3i", ExactSpelling = true)]
            internal static extern void Uniform3i(Int32 location, Int32 v0, Int32 v1, Int32 v2);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glUniform4i", ExactSpelling = true)]
            internal static extern void Uniform4i(Int32 location, Int32 v0, Int32 v1, Int32 v2, Int32 v3);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glUniform1fv", ExactSpelling = true)]
            internal static extern unsafe void Uniform1fv(Int32 location, Int32 count, Single* value);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glUniform2fv", ExactSpelling = true)]
            internal static extern unsafe void Uniform2fv(Int32 location, Int32 count, Single* value);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glUniform3fv", ExactSpelling = true)]
            internal static extern unsafe void Uniform3fv(Int32 location, Int32 count, Single* value);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glUniform4fv", ExactSpelling = true)]
            internal static extern unsafe void Uniform4fv(Int32 location, Int32 count, Single* value);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glUniform1iv", ExactSpelling = true)]
            internal static extern unsafe void Uniform1iv(Int32 location, Int32 count, Int32* value);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glUniform2iv", ExactSpelling = true)]
            internal static extern unsafe void Uniform2iv(Int32 location, Int32 count, Int32* value);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glUniform3iv", ExactSpelling = true)]
            internal static extern unsafe void Uniform3iv(Int32 location, Int32 count, Int32* value);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glUniform4iv", ExactSpelling = true)]
            internal static extern unsafe void Uniform4iv(Int32 location, Int32 count, Int32* value);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glUniformMatrix2fv", ExactSpelling = true)]
            internal static extern unsafe void UniformMatrix2fv(Int32 location, Int32 count, Int32 transpose, Single* value);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glUniformMatrix3fv", ExactSpelling = true)]
            internal static extern unsafe void UniformMatrix3fv(Int32 location, Int32 count, Int32 transpose, Single* value);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glUniformMatrix4fv", ExactSpelling = true)]
            internal static extern unsafe void UniformMatrix4fv(Int32 location, Int32 count, Int32 transpose, Single* value);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glValidateProgram", ExactSpelling = true)]
            internal static extern void ValidateProgram(UInt32 program);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glVertexAttrib1d", ExactSpelling = true)]
            internal static extern void VertexAttrib1d(UInt32 index, Double x);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glVertexAttrib1dv", ExactSpelling = true)]
            internal static extern unsafe void VertexAttrib1dv(UInt32 index, Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glVertexAttrib1f", ExactSpelling = true)]
            internal static extern void VertexAttrib1f(UInt32 index, Single x);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glVertexAttrib1fv", ExactSpelling = true)]
            internal static extern unsafe void VertexAttrib1fv(UInt32 index, Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glVertexAttrib1s", ExactSpelling = true)]
            internal static extern void VertexAttrib1s(UInt32 index, Int16 x);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glVertexAttrib1sv", ExactSpelling = true)]
            internal static extern unsafe void VertexAttrib1sv(UInt32 index, Int16* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glVertexAttrib2d", ExactSpelling = true)]
            internal static extern void VertexAttrib2d(UInt32 index, Double x, Double y);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glVertexAttrib2dv", ExactSpelling = true)]
            internal static extern unsafe void VertexAttrib2dv(UInt32 index, Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glVertexAttrib2f", ExactSpelling = true)]
            internal static extern void VertexAttrib2f(UInt32 index, Single x, Single y);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glVertexAttrib2fv", ExactSpelling = true)]
            internal static extern unsafe void VertexAttrib2fv(UInt32 index, Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glVertexAttrib2s", ExactSpelling = true)]
            internal static extern void VertexAttrib2s(UInt32 index, Int16 x, Int16 y);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glVertexAttrib2sv", ExactSpelling = true)]
            internal static extern unsafe void VertexAttrib2sv(UInt32 index, Int16* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glVertexAttrib3d", ExactSpelling = true)]
            internal static extern void VertexAttrib3d(UInt32 index, Double x, Double y, Double z);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glVertexAttrib3dv", ExactSpelling = true)]
            internal static extern unsafe void VertexAttrib3dv(UInt32 index, Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glVertexAttrib3f", ExactSpelling = true)]
            internal static extern void VertexAttrib3f(UInt32 index, Single x, Single y, Single z);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glVertexAttrib3fv", ExactSpelling = true)]
            internal static extern unsafe void VertexAttrib3fv(UInt32 index, Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glVertexAttrib3s", ExactSpelling = true)]
            internal static extern void VertexAttrib3s(UInt32 index, Int16 x, Int16 y, Int16 z);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glVertexAttrib3sv", ExactSpelling = true)]
            internal static extern unsafe void VertexAttrib3sv(UInt32 index, Int16* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glVertexAttrib4Nbv", ExactSpelling = true)]
            internal static extern unsafe void VertexAttrib4Nbv(UInt32 index, SByte* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glVertexAttrib4Niv", ExactSpelling = true)]
            internal static extern unsafe void VertexAttrib4Niv(UInt32 index, Int32* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glVertexAttrib4Nsv", ExactSpelling = true)]
            internal static extern unsafe void VertexAttrib4Nsv(UInt32 index, Int16* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glVertexAttrib4Nub", ExactSpelling = true)]
            internal static extern void VertexAttrib4Nub(UInt32 index, Byte x, Byte y, Byte z, Byte w);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glVertexAttrib4Nubv", ExactSpelling = true)]
            internal static extern unsafe void VertexAttrib4Nubv(UInt32 index, Byte* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glVertexAttrib4Nuiv", ExactSpelling = true)]
            internal static extern unsafe void VertexAttrib4Nuiv(UInt32 index, UInt32* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glVertexAttrib4Nusv", ExactSpelling = true)]
            internal static extern unsafe void VertexAttrib4Nusv(UInt32 index, UInt16* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glVertexAttrib4bv", ExactSpelling = true)]
            internal static extern unsafe void VertexAttrib4bv(UInt32 index, SByte* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glVertexAttrib4d", ExactSpelling = true)]
            internal static extern void VertexAttrib4d(UInt32 index, Double x, Double y, Double z, Double w);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glVertexAttrib4dv", ExactSpelling = true)]
            internal static extern unsafe void VertexAttrib4dv(UInt32 index, Double* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glVertexAttrib4f", ExactSpelling = true)]
            internal static extern void VertexAttrib4f(UInt32 index, Single x, Single y, Single z, Single w);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glVertexAttrib4fv", ExactSpelling = true)]
            internal static extern unsafe void VertexAttrib4fv(UInt32 index, Single* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glVertexAttrib4iv", ExactSpelling = true)]
            internal static extern unsafe void VertexAttrib4iv(UInt32 index, Int32* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glVertexAttrib4s", ExactSpelling = true)]
            internal static extern void VertexAttrib4s(UInt32 index, Int16 x, Int16 y, Int16 z, Int16 w);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glVertexAttrib4sv", ExactSpelling = true)]
            internal static extern unsafe void VertexAttrib4sv(UInt32 index, Int16* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glVertexAttrib4ubv", ExactSpelling = true)]
            internal static extern unsafe void VertexAttrib4ubv(UInt32 index, Byte* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glVertexAttrib4uiv", ExactSpelling = true)]
            internal static extern unsafe void VertexAttrib4uiv(UInt32 index, UInt32* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glVertexAttrib4usv", ExactSpelling = true)]
            internal static extern unsafe void VertexAttrib4usv(UInt32 index, UInt16* v);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glVertexAttribPointer", ExactSpelling = true)]
            internal static extern void VertexAttribPointer(UInt32 index, Int32 size, int type, Int32 normalized, Int32 stride, IntPtr pointer);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glUniformMatrix2x3fv", ExactSpelling = true)]
            internal static extern unsafe void UniformMatrix2x3fv(Int32 location, Int32 count, Int32 transpose, Single* value);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glUniformMatrix3x2fv", ExactSpelling = true)]
            internal static extern unsafe void UniformMatrix3x2fv(Int32 location, Int32 count, Int32 transpose, Single* value);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glUniformMatrix2x4fv", ExactSpelling = true)]
            internal static extern unsafe void UniformMatrix2x4fv(Int32 location, Int32 count, Int32 transpose, Single* value);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glUniformMatrix4x2fv", ExactSpelling = true)]
            internal static extern unsafe void UniformMatrix4x2fv(Int32 location, Int32 count, Int32 transpose, Single* value);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glUniformMatrix3x4fv", ExactSpelling = true)]
            internal static extern unsafe void UniformMatrix3x4fv(Int32 location, Int32 count, Int32 transpose, Single* value);
            [SuppressUnmanagedCodeSecurity()]
            [DllImport(Library, EntryPoint = "glUniformMatrix4x3fv", ExactSpelling = true)]
            internal static extern unsafe void UniformMatrix4x3fv(Int32 location, Int32 count, Int32 transpose, Single* value);
        }
    }
}
