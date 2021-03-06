// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Lobby", columnHash: 0x54075f2e )]
    public class Lobby : IExcelRow
    {
        
        public uint TYPE;
        public uint PARAM;
        public uint LINK;
        public SeString Text;
        public SeString Unknown4;
        public SeString Unknown5;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            TYPE = parser.ReadColumn< uint >( 0 );
            PARAM = parser.ReadColumn< uint >( 1 );
            LINK = parser.ReadColumn< uint >( 2 );
            Text = parser.ReadColumn< SeString >( 3 );
            Unknown4 = parser.ReadColumn< SeString >( 4 );
            Unknown5 = parser.ReadColumn< SeString >( 5 );
        }
    }
}