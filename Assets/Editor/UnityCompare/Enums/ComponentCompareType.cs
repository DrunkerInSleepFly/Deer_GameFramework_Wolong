using System;

namespace UnityCompare
{
    [Flags]
    public enum ComponentCompareType
    {
        none = 0,
        contentEqual = 1 << 1, //内容相等

        allEqual = contentEqual,
    }
}
