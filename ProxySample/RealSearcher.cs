namespace ProxySample;

public class RealSearcher : ISearcher
{
    public string DoSearch(string userId, string keyword)
    {
        Console.WriteLine("用户'{0}'使用关键字'{1}'查询商务信息！", userId, keyword);
        return "返回具体内容";
    }
}