namespace Inputs
{
    public class InputUtils
    {
        public static readonly IInputActionFactory InputActionFactory = CreateInputActionFactory();

        private static IInputActionFactory CreateInputActionFactory()
        {
            var factory = new InputActionFactory();
            factory.AddInputAction<IFloat2InputAction, Float2InputAction>();
            return factory;
        }
    }
}