namespace Inputs
{
    public interface IInputActionFactory
    {
        T CreateInputAction<T>() where T : class;
    }
}