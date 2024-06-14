namespace Assets.XLFrame.Scripts
{
    public interface ILog
    {
        void Debug(string info);
        void DebugError(string info);
        void DebugWarning(string info);

    }
}