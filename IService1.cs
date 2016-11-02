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
        void ExitGame(int playerId);

        [OperationContract]
        void Ready(int playerId);

        [OperationContract]
        void Pass(int playerId);

        [OperationContract]
        Card GiveCard(int playerId);

    }
    public interface IMyCallback
    {
        [OperationContract]
        void ShowCard(Card card);
    }
}
