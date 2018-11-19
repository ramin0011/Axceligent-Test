using System;

namespace Test4
{
    internal class Alexa
    {
        public AlexaConfigurations _configurations;
        public void Configure(Action<AlexaConfigurations> action)
        {
            action(_configurations ?? (_configurations=new AlexaConfigurations())) ;
        }

        public string Talk()
        {
            return _configurations==null ? "hello, i am Alexa" :
                _configurations.GreetingMessage.Replace("{OwnerName}", _configurations.OwnerName);
        }
    }
}