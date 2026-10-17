namespace ProjetoTestePlaywright.Config
{
    public class TestSettings
    {
        public string BaseUrl { get; set; } = string.Empty;
        public string Browser { get; set; } = "Chromium";
        public bool Headless { get; set; } = false;
        public float Timeout { get; set; } = 30000;
    }
}