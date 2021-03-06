//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Abide.Tag.Cache.Generated
{
    using System;
    using Abide.HaloLibrary;
    using Abide.Tag;
    
    /// <summary>
    /// Represents the generated bitmap_block tag block.
    /// </summary>
    public sealed class BitmapBlock : Block
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BitmapBlock"/> class.
        /// </summary>
        public BitmapBlock()
        {
            this.Fields.Add(new ExplanationField("Type", @"Type controls bitmap geometry. All dimensions must be a power of 2 except for SPRITES and INTERFACE BITMAPS:

* 2D TEXTURES: Ordinary 2D textures will be generated.
* 3D TEXTURES: Volume textures will be generated from each sequence of 2D texture slices.
* CUBE MAPS: Generated from each consecutive set of six 2D textures in each sequence, all faces of a cube map must be square and the same size.
* SPRITES: Sprite texture pages will be generated.
* INTERFACE BITMAPS: Similar to 2D TEXTURES but without mipmaps and without the power of 2 restriction."));
            this.Fields.Add(new EnumField("Type", "2D Textures", "3D Textures", "Cube Maps", "Sprites", "Interface Bitmaps"));
            this.Fields.Add(new ExplanationField("Format", @"Format controls how pixels will be stored internally:

* COMPRESSED WITH COLOR-KEY TRANSPARENCY: DXT1 compression, using 4 bits/pixel. 4-x-4 blocks of pixels, are reduced to two colors and interpolated, alpha channel uses color-key transparency instead of alpha from the plate (all zero-alpha pixels also have zero-color).
* COMPRESSED WITH EXPLICIT ALPHA: DXT2/3 compression, using 8 bits/pixel. Same as DXT1 without the color key transparency, alpha channel uses alpha from plate quantized down to 4 bits/pixel.
* COMPRESSED WITH INTERPOLATED ALPHA: DXT4/5 compression, using 8 bits/pixel. Same as DXT2/3, except alpha is smoother. Better for smooth alpha gradients, but worse for noisy alpha.
* 16-BIT COLOR: Uses 16 bits/pixel. Depending on the alpha channel, bitmaps are quantized to either r5g6b5 (no alpha), a1r5g5b5 (1-bit alpha), or a4r4g4b4 (>1-bit alpha).
* 32-BIT COLOR: Uses 32 bits/pixel. Very high quality and can have alpha at no added cost. This format takes up the most memory, however. Bitmap formats are x8r8g8b8 and a8r8g8b.
* MONOCHROME: Uses either 8 or 16 bits/pixel. Bitmap formats are a8 (alpha), y8 (intensity), ay8 (combined alpha intensity), and a8y8 (separate alpha intensity)."));
            this.Fields.Add(new EnumField("Format", "Compressed with Color-Key Transparency", "Compressed with Explicit Alpha", "Compressed with Interpolated Alpha", "16-Bit Color", "32-Bit Color", "Monochrome"));
            this.Fields.Add(new ExplanationField("Usage", @"Usage controls how mipmaps are generated:

* ALPHA BLEND: Pixels with zero alpha are ignored in mipmaps, to prevent bleeding the transparent color.
* DEFAULT: Downsampling works normally, as in Photoshop.
* HEIGHT MAP: The bitmap (normally grayscale) is a height map that gets converted to a bump map. Uses <bump height> below. Alpha is passed through unmodified.
* DETAIL MAP: Mipmap color fades to gray, controlled by <detail fade factor> below. Alpha fades to white.
* LIGHT MAP: Generates no mipmaps. Do not use!
* VECTOR MAP: Used mostly for special effects; pixels are treated as xyz vectors and normalized after downsampling. Alpha is passed through unmodified."));
            this.Fields.Add(new EnumField("Usage", "Alpha Blend", "Default", "Height Map", "Detail Map", "Light Map", "Vector Map", "Height Map BLUE 255", "embm", "Height Map A8L8", "Height Map G8B8", "Height Map G8B8 w/ Alpha"));
            this.Fields.Add(new WordFlagsField("Flags", "Enable Diffusion Dithering", "Disable Height Map Compression", "Uniform Sprite Sequences", "Filthy Sprite Bug Fix", "Use Sharp Bump Filter", "UNUSED", "Use Clamped/Mirrored Bump Filter", "Invert Detail Fade", "Swap x-y Vector Components", "Convert from Signed", "Convert to Signed", "Import mipmap Chains", "Intentionally True Color"));
            this.Fields.Add(new ExplanationField("Postprocessing", "These properties control how mipmaps are postprocessed."));
            this.Fields.Add(new RealFractionField("Detail Fade Factor:[0,1]#0 means fade to gray by last mipmap; 1 means fade to gra" +
                        "y by first mipmap."));
            this.Fields.Add(new RealFractionField("Sharpen Amount:[0,1]#Sharpens mipmap after downsampling."));
            this.Fields.Add(new RealField("Bump Height:repeats#tApparent height of the bump map above the triangle onto whic" +
                        "h it is textured, in texture repeats (i.e., 1.0 would be as high as the texture " +
                        "is wide)."));
            this.Fields.Add(new EnumField("sprite size", "32 x 32", "64 x 64", "128 x 128", "256 x 256", "512 x 512", "1024 x 1024"));
            this.Fields.Add(new ShortIntegerField(""));
            this.Fields.Add(new ExplanationField("Color Plate", "The original image file used to import the bitmap group."));
            this.Fields.Add(new ShortIntegerField("Color Plate Width*:pixels"));
            this.Fields.Add(new ShortIntegerField("Color Plate Height*:pixels"));
            this.Fields.Add(new PadField("Compressed Color Plate Data*", 8));
            this.Fields.Add(new ExplanationField("Processed Pixel Data", "Pixel data after being processed by the tool."));
            this.Fields.Add(new PadField("Processed Pixel Data*", 8));
            this.Fields.Add(new ExplanationField("Miscellaneous", ""));
            this.Fields.Add(new RealField("Blur Filter Size:[0,10] pixels#Blurs the bitmap before generating mipmaps."));
            this.Fields.Add(new RealField("Alpha Bias:[-1,1]#Affects alpha mipmap generation."));
            this.Fields.Add(new ShortIntegerField("Mipmap Count:levels#0 Defaults to all levels."));
            this.Fields.Add(new ExplanationField("...More Sprite Processing", "Sprite usage controls the background color of sprite plates."));
            this.Fields.Add(new EnumField("Sprite Usage", "Blend/Add/Subtract/Max", "Multiply/Min", "Double Multiply"));
            this.Fields.Add(new ShortIntegerField("Sprite Spacing*"));
            this.Fields.Add(new ExplanationField("...More Stuff", ""));
            this.Fields.Add(new EnumField("Force Format", "Default", "Force G8B8", "Force DXT1", "Force DXT3", "Force DXT5", "Force ALPHA-LUMINANCE8", "Force A4R4G4B4"));
            this.Fields.Add(new BlockField<BitmapGroupSequenceBlock>("Sequences*", 256));
            this.Fields.Add(new BlockField<BitmapDataBlock>("Bitmaps*", 65536));
        }
        /// <summary>
        /// Gets and returns the name of the bitmap_block tag block.
        /// </summary>
        public override string BlockName
        {
            get
            {
                return "bitmap_block";
            }
        }
        /// <summary>
        /// Gets and returns the display name of the bitmap_block tag block.
        /// </summary>
        public override string DisplayName
        {
            get
            {
                return "bitmap";
            }
        }
        /// <summary>
        /// Gets and returns the maximum number of elements allowed of the bitmap_block tag block.
        /// </summary>
        public override int MaximumElementCount
        {
            get
            {
                return 1;
            }
        }
        /// <summary>
        /// Gets and returns the alignment of the bitmap_block tag block.
        /// </summary>
        public override int Alignment
        {
            get
            {
                return 4;
            }
        }
    }
}
