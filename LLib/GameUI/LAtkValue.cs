﻿using Dalamud.Memory;
using FFXIVClientStructs.FFXIV.Component.GUI;

namespace LLib.GameUI;

public static class LAtkValue
{
    public static unsafe string? ReadAtkString(this AtkValue atkValue)
    {
        if (atkValue.String != null)
            return MemoryHelper.ReadSeStringNullTerminated(new nint(atkValue.String)).ToString();
        return null;
    }
}
