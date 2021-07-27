using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchSysHidplusClient.Enums
{
    // Reference: https://switchbrew.github.io/libnx/hid_8h.html (HidNpadButton enum)
    enum SwitchButtons
    {
        A = 1,
        B = 1 << 1,
        X = 1 << 2,
        Y = 1 << 3,
        StickL = 1 << 4,
        StickR = 1 << 5,
        L = 1 << 6,
        R = 1 << 7,
        ZL = 1 << 8,
        ZR = 1 << 9,
        Plus = 1 << 10,
        Minus = 1 << 11,
        DPadLeft = 1 << 12,
        DPadUp = 1 << 13,
        DPadRight = 1 << 14,
        DPadDown = 1 << 15,

        // Decided to skip joysticks because they won't be used by this program. If you want to implement them, check the reference above.

        // SL and SR. These are masked by Horizon and cannot be used, but if we find a way for Horizon to not mask them, we could use them:
        LeftJoySL = 1 << 24,
        LeftJoySR = 1 << 25,
        RightJoySL = 1 << 26,
        RightJoySR = 1 << 27,
        AnySL = LeftJoySL | RightJoySL,
        AnySR = LeftJoySR | RightJoySR
    }
}
