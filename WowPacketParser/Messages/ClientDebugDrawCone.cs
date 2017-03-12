using System.Collections.Generic;
using WowPacketParser.Misc;

namespace WowPacketParser.Messages
{
    public unsafe struct ClientDebugDrawCone
    {
        public Vector3 Base;
        public float Baseradius;
        public uint Id;
        public Vector3 Direction;
        public float Height;
        public uint Color;
        public float Lifetime;
        public uint Settings;
    }
}