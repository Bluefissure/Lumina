// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Opening", columnHash: 0xfe684a57 )]
    public class Opening : IExcelRow
    {
        
        public SeString Name;
        public LazyRow< Quest > Quest;
        public SeString Unknown2;
        public SeString Unknown3;
        public SeString Unknown4;
        public SeString Unknown5;
        public SeString Unknown6;
        public SeString Unknown7;
        public SeString Unknown8;
        public SeString Unknown9;
        public SeString Unknown10;
        public SeString Unknown11;
        public SeString Unknown12;
        public SeString Unknown13;
        public SeString Unknown14;
        public SeString Unknown15;
        public SeString Unknown16;
        public SeString Unknown17;
        public SeString Unknown18;
        public SeString Unknown19;
        public SeString Unknown20;
        public SeString Unknown21;
        public SeString Unknown22;
        public SeString Unknown23;
        public SeString Unknown24;
        public SeString Unknown25;
        public SeString Unknown26;
        public SeString Unknown27;
        public SeString Unknown28;
        public SeString Unknown29;
        public SeString Unknown30;
        public SeString Unknown31;
        public SeString Unknown32;
        public SeString Unknown33;
        public SeString Unknown34;
        public SeString Unknown35;
        public SeString Unknown36;
        public SeString Unknown37;
        public SeString Unknown38;
        public SeString Unknown39;
        public SeString Unknown40;
        public SeString Unknown41;
        public uint Unknown42;
        public uint Unknown43;
        public uint Unknown44;
        public uint Unknown45;
        public uint Unknown46;
        public uint Unknown47;
        public uint Unknown48;
        public uint Unknown49;
        public uint Unknown50;
        public uint Unknown51;
        public uint Unknown52;
        public uint Unknown53;
        public uint Unknown54;
        public uint Unknown55;
        public uint Unknown56;
        public uint Unknown57;
        public uint Unknown58;
        public uint Unknown59;
        public uint Unknown60;
        public uint Unknown61;
        public uint Unknown62;
        public uint Unknown63;
        public uint Unknown64;
        public uint Unknown65;
        public uint Unknown66;
        public uint Unknown67;
        public uint Unknown68;
        public uint Unknown69;
        public uint Unknown70;
        public uint Unknown71;
        public uint Unknown72;
        public uint Unknown73;
        public uint Unknown74;
        public uint Unknown75;
        public uint Unknown76;
        public uint Unknown77;
        public uint Unknown78;
        public uint Unknown79;
        public uint Unknown80;
        public uint Unknown81;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            Name = parser.ReadColumn< SeString >( 0 );
            Quest = new LazyRow< Quest >( lumina, parser.ReadColumn< uint >( 1 ), language );
            Unknown2 = parser.ReadColumn< SeString >( 2 );
            Unknown3 = parser.ReadColumn< SeString >( 3 );
            Unknown4 = parser.ReadColumn< SeString >( 4 );
            Unknown5 = parser.ReadColumn< SeString >( 5 );
            Unknown6 = parser.ReadColumn< SeString >( 6 );
            Unknown7 = parser.ReadColumn< SeString >( 7 );
            Unknown8 = parser.ReadColumn< SeString >( 8 );
            Unknown9 = parser.ReadColumn< SeString >( 9 );
            Unknown10 = parser.ReadColumn< SeString >( 10 );
            Unknown11 = parser.ReadColumn< SeString >( 11 );
            Unknown12 = parser.ReadColumn< SeString >( 12 );
            Unknown13 = parser.ReadColumn< SeString >( 13 );
            Unknown14 = parser.ReadColumn< SeString >( 14 );
            Unknown15 = parser.ReadColumn< SeString >( 15 );
            Unknown16 = parser.ReadColumn< SeString >( 16 );
            Unknown17 = parser.ReadColumn< SeString >( 17 );
            Unknown18 = parser.ReadColumn< SeString >( 18 );
            Unknown19 = parser.ReadColumn< SeString >( 19 );
            Unknown20 = parser.ReadColumn< SeString >( 20 );
            Unknown21 = parser.ReadColumn< SeString >( 21 );
            Unknown22 = parser.ReadColumn< SeString >( 22 );
            Unknown23 = parser.ReadColumn< SeString >( 23 );
            Unknown24 = parser.ReadColumn< SeString >( 24 );
            Unknown25 = parser.ReadColumn< SeString >( 25 );
            Unknown26 = parser.ReadColumn< SeString >( 26 );
            Unknown27 = parser.ReadColumn< SeString >( 27 );
            Unknown28 = parser.ReadColumn< SeString >( 28 );
            Unknown29 = parser.ReadColumn< SeString >( 29 );
            Unknown30 = parser.ReadColumn< SeString >( 30 );
            Unknown31 = parser.ReadColumn< SeString >( 31 );
            Unknown32 = parser.ReadColumn< SeString >( 32 );
            Unknown33 = parser.ReadColumn< SeString >( 33 );
            Unknown34 = parser.ReadColumn< SeString >( 34 );
            Unknown35 = parser.ReadColumn< SeString >( 35 );
            Unknown36 = parser.ReadColumn< SeString >( 36 );
            Unknown37 = parser.ReadColumn< SeString >( 37 );
            Unknown38 = parser.ReadColumn< SeString >( 38 );
            Unknown39 = parser.ReadColumn< SeString >( 39 );
            Unknown40 = parser.ReadColumn< SeString >( 40 );
            Unknown41 = parser.ReadColumn< SeString >( 41 );
            Unknown42 = parser.ReadColumn< uint >( 42 );
            Unknown43 = parser.ReadColumn< uint >( 43 );
            Unknown44 = parser.ReadColumn< uint >( 44 );
            Unknown45 = parser.ReadColumn< uint >( 45 );
            Unknown46 = parser.ReadColumn< uint >( 46 );
            Unknown47 = parser.ReadColumn< uint >( 47 );
            Unknown48 = parser.ReadColumn< uint >( 48 );
            Unknown49 = parser.ReadColumn< uint >( 49 );
            Unknown50 = parser.ReadColumn< uint >( 50 );
            Unknown51 = parser.ReadColumn< uint >( 51 );
            Unknown52 = parser.ReadColumn< uint >( 52 );
            Unknown53 = parser.ReadColumn< uint >( 53 );
            Unknown54 = parser.ReadColumn< uint >( 54 );
            Unknown55 = parser.ReadColumn< uint >( 55 );
            Unknown56 = parser.ReadColumn< uint >( 56 );
            Unknown57 = parser.ReadColumn< uint >( 57 );
            Unknown58 = parser.ReadColumn< uint >( 58 );
            Unknown59 = parser.ReadColumn< uint >( 59 );
            Unknown60 = parser.ReadColumn< uint >( 60 );
            Unknown61 = parser.ReadColumn< uint >( 61 );
            Unknown62 = parser.ReadColumn< uint >( 62 );
            Unknown63 = parser.ReadColumn< uint >( 63 );
            Unknown64 = parser.ReadColumn< uint >( 64 );
            Unknown65 = parser.ReadColumn< uint >( 65 );
            Unknown66 = parser.ReadColumn< uint >( 66 );
            Unknown67 = parser.ReadColumn< uint >( 67 );
            Unknown68 = parser.ReadColumn< uint >( 68 );
            Unknown69 = parser.ReadColumn< uint >( 69 );
            Unknown70 = parser.ReadColumn< uint >( 70 );
            Unknown71 = parser.ReadColumn< uint >( 71 );
            Unknown72 = parser.ReadColumn< uint >( 72 );
            Unknown73 = parser.ReadColumn< uint >( 73 );
            Unknown74 = parser.ReadColumn< uint >( 74 );
            Unknown75 = parser.ReadColumn< uint >( 75 );
            Unknown76 = parser.ReadColumn< uint >( 76 );
            Unknown77 = parser.ReadColumn< uint >( 77 );
            Unknown78 = parser.ReadColumn< uint >( 78 );
            Unknown79 = parser.ReadColumn< uint >( 79 );
            Unknown80 = parser.ReadColumn< uint >( 80 );
            Unknown81 = parser.ReadColumn< uint >( 81 );
        }
    }
}