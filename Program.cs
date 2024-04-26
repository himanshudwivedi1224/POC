using Tesseract;

class Program
{
    static void Main(string[] args)
    {
        // Replace "path/to/your/image.png" with the path to your image file
        string imagePath = "C:\\Users\\ZK618AP\\Downloads\\unnamed.png";

        try
        {


            using (var engine = new TesseractEngine("C:\\Users\\ZK618AP\\AppData\\Local\\Programs\\Tesseract-OCR\\tessdata", "eng", EngineMode.Default))
            {
                using (var img = Pix.LoadFromFile(imagePath))
                {
                    using (var page = engine.Process(img))
                    {
                        var text = page.GetText();
                        Console.WriteLine("OCR Result:");
                        Console.WriteLine(text);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }

        Console.ReadLine();
    }
}
