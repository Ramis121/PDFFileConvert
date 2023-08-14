using Spire.Pdf;
using Spire.Pdf.Conversion.Compression;


PdfCompressor compressor = new PdfCompressor("C:/Users/Admin/OneDrive/Рабочий стол/PDF/PDF_Converter_Pro_Quick_Reference_Guide.RU.pdf");

TextCompressionOptions compressionOptions = compressor.Options.TextCompressionOptions;

compressionOptions.CompressFonts = true;


ImageCompressionOptions imageCompression = compressor.Options.ImageCompressionOptions;  

imageCompression.ImageQuality = ImageQuality.High;

imageCompression.ResizeImages = true; 

imageCompression.CompressImage = true;

compressor.CompressToFile("C:/Users/Admin/OneDrive/Рабочий стол/PDF/PDF_Convert.pdf.pdf");
