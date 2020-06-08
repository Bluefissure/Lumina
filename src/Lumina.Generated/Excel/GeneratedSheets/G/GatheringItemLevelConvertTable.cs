using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GatheringItemLevelConvertTable", columnHash: 0xde74b4c4 )]
    public class GatheringItemLevelConvertTable : IExcelRow
    {
        // column defs from Sun, 10 May 2020 19:27:42 GMT


        // col: 00 offset: 0000
        public byte GatheringItemLevel;

        // col: 01 offset: 0001
        public byte Stars;


        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            GatheringItemLevel = parser.ReadOffset< byte >( 0x0 );

            // col: 1 offset: 0001
            Stars = parser.ReadOffset< byte >( 0x1 );


        }
    }
}