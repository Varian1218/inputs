namespace Inputs
{
    public interface IInputActionMap
    {
        T GetAction<T>(string hash) where T : class;
    }
}