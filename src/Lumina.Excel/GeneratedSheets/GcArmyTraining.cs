// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GcArmyTraining", columnHash: 0x274780bb )]
    public class GcArmyTraining : IExcelRow
    {
        
        public sbyte PhysicalBonus;
        public sbyte MentalBonus;
        public sbyte TacticalBonus;
        public uint Experience;
        public SeString Name;
        public SeString Description;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            PhysicalBonus = parser.ReadColumn< sbyte >( 0 );
            MentalBonus = parser.ReadColumn< sbyte >( 1 );
            TacticalBonus = parser.ReadColumn< sbyte >( 2 );
            Experience = parser.ReadColumn< uint >( 3 );
            Name = parser.ReadColumn< SeString >( 4 );
            Description = parser.ReadColumn< SeString >( 5 );
        }
    }
}