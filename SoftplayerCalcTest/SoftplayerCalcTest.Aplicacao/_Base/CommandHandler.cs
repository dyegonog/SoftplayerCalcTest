namespace SoftplayerCalcTest.Aplicacao._Base
{
    public interface CommandHandler <TCommand, TResponse>
        where TCommand : Command
        where TResponse : HandlerResponse

    {
        TResponse Executar(TCommand cmd);
    }
}