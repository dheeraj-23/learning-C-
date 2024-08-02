namespace Interfaces
{
    interface IFlyable
    {
        void Fly();
    }
    public class Bird
    {
        public void Fly()
        {
            Console.WriteLine("The bird flies hign in the sky.");
        } 
    }
}
