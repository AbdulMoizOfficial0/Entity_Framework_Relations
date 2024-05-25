namespace Entity_Framework_Relations.Models.Entities
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Backpack Backpack { get; set; }
        public List<Weapon> Weapons { get; set; }
        public List<Faction> Factions { get; set; }

    }
}
