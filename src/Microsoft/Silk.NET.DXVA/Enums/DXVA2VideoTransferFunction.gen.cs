// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.DXVA
{
    [NativeName("Name", "_DXVA2_VideoTransferFunction")]
    public enum DXVA2VideoTransferFunction : int
    {
        [Obsolete("Deprecated in favour of \"VideoTransFuncMask\"")]
        [NativeName("Name", "DXVA2_VideoTransFuncMask")]
        DXVA2VideoTransFuncMask = 0x1F,
        [Obsolete("Deprecated in favour of \"VideoTransFuncUnknown\"")]
        [NativeName("Name", "DXVA2_VideoTransFunc_Unknown")]
        DXVA2VideoTransFuncUnknown = 0x0,
        [Obsolete("Deprecated in favour of \"VideoTransFunc10\"")]
        [NativeName("Name", "DXVA2_VideoTransFunc_10")]
        DXVA2VideoTransFunc10 = 0x1,
        [Obsolete("Deprecated in favour of \"VideoTransFunc18\"")]
        [NativeName("Name", "DXVA2_VideoTransFunc_18")]
        DXVA2VideoTransFunc18 = 0x2,
        [Obsolete("Deprecated in favour of \"VideoTransFunc20\"")]
        [NativeName("Name", "DXVA2_VideoTransFunc_20")]
        DXVA2VideoTransFunc20 = 0x3,
        [Obsolete("Deprecated in favour of \"VideoTransFunc22\"")]
        [NativeName("Name", "DXVA2_VideoTransFunc_22")]
        DXVA2VideoTransFunc22 = 0x4,
        [Obsolete("Deprecated in favour of \"VideoTransFunc709\"")]
        [NativeName("Name", "DXVA2_VideoTransFunc_709")]
        DXVA2VideoTransFunc709 = 0x5,
        [Obsolete("Deprecated in favour of \"VideoTransFunc240M\"")]
        [NativeName("Name", "DXVA2_VideoTransFunc_240M")]
        DXVA2VideoTransFunc240M = 0x6,
        [Obsolete("Deprecated in favour of \"VideoTransFuncSRgb\"")]
        [NativeName("Name", "DXVA2_VideoTransFunc_sRGB")]
        DXVA2VideoTransFuncSRgb = 0x7,
        [Obsolete("Deprecated in favour of \"VideoTransFunc28\"")]
        [NativeName("Name", "DXVA2_VideoTransFunc_28")]
        DXVA2VideoTransFunc28 = 0x8,
        [NativeName("Name", "DXVA2_VideoTransFuncMask")]
        VideoTransFuncMask = 0x1F,
        [NativeName("Name", "DXVA2_VideoTransFunc_Unknown")]
        VideoTransFuncUnknown = 0x0,
        [NativeName("Name", "DXVA2_VideoTransFunc_10")]
        VideoTransFunc10 = 0x1,
        [NativeName("Name", "DXVA2_VideoTransFunc_18")]
        VideoTransFunc18 = 0x2,
        [NativeName("Name", "DXVA2_VideoTransFunc_20")]
        VideoTransFunc20 = 0x3,
        [NativeName("Name", "DXVA2_VideoTransFunc_22")]
        VideoTransFunc22 = 0x4,
        [NativeName("Name", "DXVA2_VideoTransFunc_709")]
        VideoTransFunc709 = 0x5,
        [NativeName("Name", "DXVA2_VideoTransFunc_240M")]
        VideoTransFunc240M = 0x6,
        [NativeName("Name", "DXVA2_VideoTransFunc_sRGB")]
        VideoTransFuncSRgb = 0x7,
        [NativeName("Name", "DXVA2_VideoTransFunc_28")]
        VideoTransFunc28 = 0x8,
    }
}
