namespace ProxySample;

public class ProxySearcher : ISearcher //代理查询类  代理主题角色
{
    private RealSearcher mSearcher = new RealSearcher(); //维持一个对真实主题的引用
    private AccessValidator mValidator;
    private Logger mLogger;

    public string DoSearch(string userId, string keyword)
    {
        //如果身份验证成功,则执行查询
        if (this.Validate(userId))
        {
            string result = mSearcher.DoSearch(userId, keyword);
            this.Log(userId);
            return result;
        }
        else
        {
            return null;
        }
    }

    //创建访问验证对象并调用其Validate方法实现身份验证
    private bool Validate(string userId)
    {
        mValidator = new AccessValidator();
        return mValidator.Validate(userId);
    }

    //创建日志记录对象并调用其Log方法实现日志记录
    private void Log(string userId)
    {
        mLogger = new Logger();
        mLogger.Log(userId);
    }
}