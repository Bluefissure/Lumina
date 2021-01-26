// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "WebGuidance", columnHash: 0x7290695a )]
    public class WebGuidance : IExcelRow
    {
        
        public int Image;
        public LazyRow< WebURL > Url;
        public int Name;
        public byte Unknown54;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Image = parser.ReadColumn< int >( 0 );
            Url = new LazyRow< WebURL >( lumina, parser.ReadColumn< byte >( 1 ), language );
            Name = parser.ReadColumn< int >( 2 );
            Unknown54 = parser.ReadColumn< byte >( 3 );
        }
    }
}