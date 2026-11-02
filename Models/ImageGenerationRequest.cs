namespace AiDemo.Models;

public class ImageGenerationRequest
{
    public string Prompt { get; set; } = string.Empty;
    public int Width { get; set; } = 1024;
    public int Height { get; set; } = 768;
    public string Model { get; set; } = string.Empty;
}