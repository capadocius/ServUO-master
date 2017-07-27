using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Server.Evolution
{
    public class XpSystem
    {
        [CommandProperty(AccessLevel.GameMaster)]
        public int pointXP { get; set; }

        public void Serialize(GenericWriter writer)
        {
            writer.Write(36);  //version
            writer.Write(pointXP);
        }

        public XpSystem()
        {
            pointXP = 0;
        }

        public XpSystem(GenericReader reader)
        {
            int version = reader.ReadInt();
            pointXP = reader.ReadInt();
        }
    }
}
