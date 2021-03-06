// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "BuddyAction", columnHash: 0x9a695bec )]
    public class BuddyAction : IExcelRow
    {
        
        public SeString Name;
        public SeString Description;
        public int Icon;
        public int IconStatus;
        public ushort Reward;
        public byte Sort;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Name = parser.ReadColumn< SeString >( 0 );
            Description = parser.ReadColumn< SeString >( 1 );
            Icon = parser.ReadColumn< int >( 2 );
            IconStatus = parser.ReadColumn< int >( 3 );
            Reward = parser.ReadColumn< ushort >( 4 );
            Sort = parser.ReadColumn< byte >( 5 );
        }
    }
}