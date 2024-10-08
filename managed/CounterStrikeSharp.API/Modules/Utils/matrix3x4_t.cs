﻿/*
 *  This file is part of CounterStrikeSharp.
 *  CounterStrikeSharp is free software: you can redistribute it and/or modify
 *  it under the terms of the GNU General Public License as published by
 *  the Free Software Foundation, either version 3 of the License, or
 *  (at your option) any later version.
 *
 *  CounterStrikeSharp is distributed in the hope that it will be useful,
 *  but WITHOUT ANY WARRANTY; without even the implied warranty of
 *  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *  GNU General Public License for more details.
 *
 *  You should have received a copy of the GNU General Public License
 *  along with CounterStrikeSharp.  If not, see <https://www.gnu.org/licenses/>. *
 */

using System.Runtime.CompilerServices;

namespace CounterStrikeSharp.API.Modules.Utils;

public partial class matrix3x4_t : NativeObject
{
    public unsafe ref float this[int row, int column] => ref Unsafe.Add(ref *(float*)Handle, row * 4 + column);

    public matrix3x4_t(IntPtr pointer) : base(pointer)
    {
    }

    public matrix3x4_t(float? m00 = null, float? m01 = null, float? m02 = null, float? m03 = null,
                       float? m10 = null, float? m11 = null, float? m12 = null, float? m13 = null,
                       float? m20 = null, float? m21 = null, float? m22 = null, float? m23 = null) : this(NativeAPI.Matrix3x4New())
    {
        this[0, 0] = m00 ?? 0;
        this[0, 1] = m01 ?? 0;
        this[0, 2] = m02 ?? 0;
        this[0, 3] = m03 ?? 0;

        this[1, 0] = m10 ?? 0;
        this[1, 1] = m11 ?? 0;
        this[1, 2] = m12 ?? 0;
        this[1, 3] = m13 ?? 0;

        this[2, 0] = m20 ?? 0;
        this[2, 1] = m21 ?? 0;
        this[2, 2] = m22 ?? 0;
        this[2, 3] = m23 ?? 0;
    }

}
