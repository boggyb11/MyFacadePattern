
namespace MyFacadePattern
{
    class Player
    {
        private string _name;

        public string Name { get => _name;}

        public Player(string name)
        {
            this._name = name;
        }
    }
}
