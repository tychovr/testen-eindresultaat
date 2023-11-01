namespace Hypotheker
{
    class Program
    {
        static void Main(string[] args)
        {
            Prompts prompts = new Prompts();
            prompts.Initialize();
            prompts.AskInput();
            prompts.Calculate();
        }
    }
}