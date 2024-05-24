namespace TempProject.Service.Controling.Core.Model
{
    public class ConnectResponse
    {
        public ConnectResponse() { }

        public ConnectResponse(int value)
        {
            if (value == 1)
            {
                isError = false;
                Message = new string("Execution Successful");
                Type = TypeConnectResponse.Success;
            }
            else if (value == 0)
            {
                isError = true;
                Message = new string("Execution Failure");
                Type = TypeConnectResponse.DataError;
            }
            else if (value == 2)
            {
                isError = true;
                Message = new string("Execution Failure");
                Type = TypeConnectResponse.Error;
            }
        }

        public bool isError { get; set; }
        public TypeConnectResponse Type { get; set; }
        public string? Message { get; set; }
    }

    public enum TypeConnectResponse
    {
        Success,
        Error,
        DataError
    }
}
