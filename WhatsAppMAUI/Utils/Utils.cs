namespace WhatsAppMAUI.Utils
{
    public static class Utils
    {
        public static async Task ReadData() 
        {
            try
            {
                using var stream = await FileSystem.OpenAppPackageFileAsync("AboutAssets.txt");
                using var reader = new StreamReader(stream);

                var contents = reader.ReadToEnd();
            }
            catch (Exception)
            {
                throw;
            }
            
        }
    }
}