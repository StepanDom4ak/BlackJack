using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace BlackJackService
{
    [ServiceContract(CallbackContract = typeof(IMyCallback))]
    public interface IMyGame
    {
        [OperationContract]
        void EnterGame(string name);

        [OperationContract]
        void ExitGame(string name);
    }
    public interface IMyCallback
    {
        [OperationContract]
        Card GiveCard(int playerId);

        [OperationContract]
        bool IsReady(int playerId);

        [OperationContract]
        void Pass(int playerId);
    }
}
