namespace PatronesComportamiento._5.Memento.Helper
{
    public static class RandomStringGenerator
    {
        public static string GenerateRandomString(int length = 10)
        {
            const string allowedSymbols = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var result = string.Empty;
            var random = new Random();

            while (length > 0)
            {
                result += allowedSymbols[random.Next(0, allowedSymbols.Length)];
                Thread.Sleep(12);
                length--;
            }

            return result;
        }
    }
}
