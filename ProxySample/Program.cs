// See https://aka.ms/new-console-template for more information



namespace ProxySample
{
    class ProGram
    {
        static void Main(string[] args)
        {
            ISearcher searcher;
            searcher = new ProxySearcher();
            String result = searcher.DoSearch("杨过", "玉女心经");
            Console.Read();
        }
    }
}

