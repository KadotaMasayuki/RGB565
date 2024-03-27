# RGB565

## image2rgb565.cs

M5Stack Core2 understand RGB565 color.

i needs convet image to c++ array as

```
unsigned int w = 2;
unsigned int h = 2;
unsigned int rgb565[4] {
  0xffff, 0xfe88,
  0xfe88, 0x0088
 };
```

## why c#

i can't use python or c++ libpng or etc...
but fortunately, my pc windows 11 already installed c# compiler csc.exe and have DotNetFramework library.
then i can write c# program to convert image file to rgb565 formatted c++ array.

## build
 
c:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe  image2rgb565.cs

## usage
 
   image2rgb565.exe  some_image_file  >  output.txt

