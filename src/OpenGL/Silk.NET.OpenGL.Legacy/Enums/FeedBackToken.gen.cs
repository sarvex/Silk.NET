// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy
{
    [NativeName("Name", "FeedBackToken")]
    public enum FeedBackToken : int
    {
        [System.Obsolete]
        [NativeName("Name", "GL_PASS_THROUGH_TOKEN")]
        PassThroughToken = 0x700,
        [System.Obsolete]
        [NativeName("Name", "GL_POINT_TOKEN")]
        PointToken = 0x701,
        [System.Obsolete]
        [NativeName("Name", "GL_LINE_TOKEN")]
        LineToken = 0x702,
        [System.Obsolete]
        [NativeName("Name", "GL_POLYGON_TOKEN")]
        PolygonToken = 0x703,
        [System.Obsolete]
        [NativeName("Name", "GL_BITMAP_TOKEN")]
        BitmapToken = 0x704,
        [System.Obsolete]
        [NativeName("Name", "GL_DRAW_PIXEL_TOKEN")]
        DrawPixelToken = 0x705,
        [System.Obsolete]
        [NativeName("Name", "GL_COPY_PIXEL_TOKEN")]
        CopyPixelToken = 0x706,
        [System.Obsolete]
        [NativeName("Name", "GL_LINE_RESET_TOKEN")]
        LineResetToken = 0x707,
    }
}
