namespace ECS.Refactored
{
    interface IHeater
    {
        void TurnOn();

        void TurnOff();

        bool RunSelfTest();
    }
}