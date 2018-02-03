using System.IO;

namespace ACE.DatLoader.Entity
{
    public class PositionNew : IUnpackable // Rename this to Position after migration is complete
    {
        public uint ObjCellID { get; private set; }

        public Frame Frame = new Frame();

        public void Unpack(BinaryReader reader)
        {
            ObjCellID = reader.ReadUInt32();

            Frame.Unpack(reader);
        }
    }
}
