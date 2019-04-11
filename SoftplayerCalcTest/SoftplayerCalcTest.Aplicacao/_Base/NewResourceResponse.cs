namespace SoftplayerCalcTest.Aplicacao._Base
{
    public class NewResourceResponse : HandlerResponse
    {
        public ResponseType ResponseType { get; private set; }
        public string Message { get; private set; }
        public decimal NewId { get; private set; }

        private NewResourceResponse() { }

        public static NewResourceResponse CreateError(string message)
        {
            var response = new NewResourceResponse();
            response.ResponseType = ResponseType.Error;
            response.Message = message;
            return response;
        }

        public static NewResourceResponse CreateSuccess(decimal id)
        {
            var response = new NewResourceResponse();
            response.ResponseType = ResponseType.Success;
            response.NewId = id;
            return response;
        }
    }
}
