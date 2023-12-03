namespace CounterStrikeSharp.API.Modules.Listeners
{
    public class Listener
    {
        public string Name { get; private set; }

        public Listener(string name)
        {
            if (NativeAPI.CreateListener(name))
            {
                Name = name;
            } else
            {
                throw new Exception($"Listener '{name}' has been already created.");
            }
        }

        public void Execute(params object[] args)
        {
            NativeAPI.ExecuteListener(Name, args);
        }
    }
}
