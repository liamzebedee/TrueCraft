using System;
using TrueCraft.API.Logic;
using TrueCraft.API;
using TrueCraft.Core.Logic.Items;

namespace TrueCraft.Core.Logic.Blocks
{
    public class IronDoorBlock : BlockProvider, ICraftingRecipe
    {
        public static readonly byte BlockID = 0x47;
        
        public override byte ID { get { return 0x47; } }
        
        public override double BlastResistance { get { return 25; } }

        public override double Hardness { get { return 5; } }

        public override byte Luminance { get { return 0; } }

        public override bool Opaque { get { return false; } }
        
        public override string DisplayName { get { return "Iron Door"; } }

        public override Tuple<int, int> GetTextureMap(byte metadata)
        {
            return new Tuple<int, int>(1, 6);
        }

        public ItemStack[,] Pattern
        {
            get
            {
                return new[,]
                {
                    {new ItemStack(IronIngotItem.ItemID), new ItemStack(IronIngotItem.ItemID)},
                    {new ItemStack(IronIngotItem.ItemID), new ItemStack(IronIngotItem.ItemID)},
                    {new ItemStack(IronIngotItem.ItemID), new ItemStack(IronIngotItem.ItemID)}
                };
            }
        }

        public ItemStack Output
        {
            get { return new ItemStack(BlockID); }
        }

        public bool SignificantMetadata
        {
            get { return false; }
        }
    }
}