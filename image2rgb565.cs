/*
 output RGB565 format as csv from image file.

 create
   2024/03/26 kadota
 environment
   Windows 11 22H2
 build
   c:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe image2rgb565.cs
 usage
   image2rgb565.exe some_image_file > output.txt
*/

class Program
{
    public static int Main(string[] arg)
    {
		if (arg.Length < 1) {
			System.Console.WriteLine("Image file to RGB565");
			System.Console.WriteLine("    usage : image2rgb565.exe  some_image  >  output.txt");
			return -1;
		}
		System.Drawing.Bitmap bitmap = new System.Drawing.Bitmap(arg[0]);
		string s = "";
		for (int y = 0; y < bitmap.Height; y ++) {
			for (int x = 0; x < bitmap.Width; x ++) {
				System.Drawing.Color pixel = bitmap.GetPixel(x, y);
				uint r = pixel.R;
				uint g = pixel.G;
				uint b = pixel.B;
				uint rgb565 = ((r >> 3) << 11) | ((g >> 2) << 5) | (b >> 3);
				if (x != 0) {
					s += ",\t";
				}
				s += string.Format("0x{0:X4}", rgb565);
			}
			s += ",\n";
		}
		System.Console.WriteLine("unsigned int width = " + bitmap.Width + ";");
		System.Console.WriteLine("unsigned int height = " + bitmap.Height + ";");
		System.Console.WriteLine("unsigned int rgb565[" + bitmap.Width * bitmap.Height + "] = {");
        System.Console.WriteLine(s);
		System.Console.WriteLine("};");
		return 0;
    }
}
