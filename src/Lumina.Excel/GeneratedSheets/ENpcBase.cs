// ReSharper disable All

using Lumina.Text;
using Lumina.Data;
using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ENpcBase", columnHash: 0x927347d8 )]
    public class ENpcBase : IExcelRow
    {
        
        public ushort EventHandler;
        public bool Important;
        public uint[] ENpcData;
        public float Scale;
        public LazyRow< ModelChara > ModelChara;
        public LazyRow< Race > Race;
        public byte Gender;
        public byte BodyType;
        public byte Height;
        public LazyRow< Tribe > Tribe;
        public byte Face;
        public byte HairStyle;
        public byte HairHighlight;
        public byte SkinColor;
        public byte EyeHeterochromia;
        public byte HairColor;
        public byte HairHighlightColor;
        public byte FacialFeature;
        public byte FacialFeatureColor;
        public byte Eyebrows;
        public byte EyeColor;
        public byte EyeShape;
        public byte Nose;
        public byte Jaw;
        public byte Mouth;
        public byte LipColor;
        public byte BustOrTone1;
        public byte ExtraFeature1;
        public byte ExtraFeature2OrBust;
        public byte FacePaint;
        public byte FacePaintColor;
        public byte Unknown62;
        public LazyRow< NpcEquip > NpcEquip;
        public LazyRow< Behavior > Behavior;
        public ulong ModelMainHand;
        public LazyRow< Stain > DyeMainHand;
        public ulong ModelOffHand;
        public LazyRow< Stain > DyeOffHand;
        public uint ModelHead;
        public LazyRow< Stain > DyeHead;
        public bool Visor;
        public uint ModelBody;
        public LazyRow< Stain > DyeBody;
        public uint ModelHands;
        public LazyRow< Stain > DyeHands;
        public uint ModelLegs;
        public LazyRow< Stain > DyeLegs;
        public uint ModelFeet;
        public LazyRow< Stain > DyeFeet;
        public uint ModelEars;
        public LazyRow< Stain > DyeEars;
        public uint ModelNeck;
        public LazyRow< Stain > DyeNeck;
        public uint ModelWrists;
        public LazyRow< Stain > DyeWrists;
        public uint ModelLeftRing;
        public LazyRow< Stain > DyeLeftRing;
        public uint ModelRightRing;
        public LazyRow< Stain > DyeRightRing;
        public byte Invisibility;
        public LazyRow< Balloon > Balloon;
        public bool NotRewriteHeight;
        public byte DefaultBalloon;
        public byte Unknown94;
        
        public uint RowId { get; set; }
        public uint SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina, Language language )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            EventHandler = parser.ReadColumn< ushort >( 0 );
            Important = parser.ReadColumn< bool >( 1 );
            ENpcData = new uint[ 32 ];
            for( var i = 0; i < 32; i++ )
                ENpcData[ i ] = parser.ReadColumn< uint >( 2 + i );
            Scale = parser.ReadColumn< float >( 34 );
            ModelChara = new LazyRow< ModelChara >( lumina, parser.ReadColumn< ushort >( 35 ), language );
            Race = new LazyRow< Race >( lumina, parser.ReadColumn< byte >( 36 ), language );
            Gender = parser.ReadColumn< byte >( 37 );
            BodyType = parser.ReadColumn< byte >( 38 );
            Height = parser.ReadColumn< byte >( 39 );
            Tribe = new LazyRow< Tribe >( lumina, parser.ReadColumn< byte >( 40 ), language );
            Face = parser.ReadColumn< byte >( 41 );
            HairStyle = parser.ReadColumn< byte >( 42 );
            HairHighlight = parser.ReadColumn< byte >( 43 );
            SkinColor = parser.ReadColumn< byte >( 44 );
            EyeHeterochromia = parser.ReadColumn< byte >( 45 );
            HairColor = parser.ReadColumn< byte >( 46 );
            HairHighlightColor = parser.ReadColumn< byte >( 47 );
            FacialFeature = parser.ReadColumn< byte >( 48 );
            FacialFeatureColor = parser.ReadColumn< byte >( 49 );
            Eyebrows = parser.ReadColumn< byte >( 50 );
            EyeColor = parser.ReadColumn< byte >( 51 );
            EyeShape = parser.ReadColumn< byte >( 52 );
            Nose = parser.ReadColumn< byte >( 53 );
            Jaw = parser.ReadColumn< byte >( 54 );
            Mouth = parser.ReadColumn< byte >( 55 );
            LipColor = parser.ReadColumn< byte >( 56 );
            BustOrTone1 = parser.ReadColumn< byte >( 57 );
            ExtraFeature1 = parser.ReadColumn< byte >( 58 );
            ExtraFeature2OrBust = parser.ReadColumn< byte >( 59 );
            FacePaint = parser.ReadColumn< byte >( 60 );
            FacePaintColor = parser.ReadColumn< byte >( 61 );
            Unknown62 = parser.ReadColumn< byte >( 62 );
            NpcEquip = new LazyRow< NpcEquip >( lumina, parser.ReadColumn< ushort >( 63 ), language );
            Behavior = new LazyRow< Behavior >( lumina, parser.ReadColumn< ushort >( 64 ), language );
            ModelMainHand = parser.ReadColumn< ulong >( 65 );
            DyeMainHand = new LazyRow< Stain >( lumina, parser.ReadColumn< byte >( 66 ), language );
            ModelOffHand = parser.ReadColumn< ulong >( 67 );
            DyeOffHand = new LazyRow< Stain >( lumina, parser.ReadColumn< byte >( 68 ), language );
            ModelHead = parser.ReadColumn< uint >( 69 );
            DyeHead = new LazyRow< Stain >( lumina, parser.ReadColumn< byte >( 70 ), language );
            Visor = parser.ReadColumn< bool >( 71 );
            ModelBody = parser.ReadColumn< uint >( 72 );
            DyeBody = new LazyRow< Stain >( lumina, parser.ReadColumn< byte >( 73 ), language );
            ModelHands = parser.ReadColumn< uint >( 74 );
            DyeHands = new LazyRow< Stain >( lumina, parser.ReadColumn< byte >( 75 ), language );
            ModelLegs = parser.ReadColumn< uint >( 76 );
            DyeLegs = new LazyRow< Stain >( lumina, parser.ReadColumn< byte >( 77 ), language );
            ModelFeet = parser.ReadColumn< uint >( 78 );
            DyeFeet = new LazyRow< Stain >( lumina, parser.ReadColumn< byte >( 79 ), language );
            ModelEars = parser.ReadColumn< uint >( 80 );
            DyeEars = new LazyRow< Stain >( lumina, parser.ReadColumn< byte >( 81 ), language );
            ModelNeck = parser.ReadColumn< uint >( 82 );
            DyeNeck = new LazyRow< Stain >( lumina, parser.ReadColumn< byte >( 83 ), language );
            ModelWrists = parser.ReadColumn< uint >( 84 );
            DyeWrists = new LazyRow< Stain >( lumina, parser.ReadColumn< byte >( 85 ), language );
            ModelLeftRing = parser.ReadColumn< uint >( 86 );
            DyeLeftRing = new LazyRow< Stain >( lumina, parser.ReadColumn< byte >( 87 ), language );
            ModelRightRing = parser.ReadColumn< uint >( 88 );
            DyeRightRing = new LazyRow< Stain >( lumina, parser.ReadColumn< byte >( 89 ), language );
            Invisibility = parser.ReadColumn< byte >( 90 );
            Balloon = new LazyRow< Balloon >( lumina, parser.ReadColumn< ushort >( 91 ), language );
            NotRewriteHeight = parser.ReadColumn< bool >( 92 );
            DefaultBalloon = parser.ReadColumn< byte >( 93 );
            Unknown94 = parser.ReadColumn< byte >( 94 );
        }
    }
}