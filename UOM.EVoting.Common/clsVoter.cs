namespace UOM.EVoting.Common
{
    public class clsVoter
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public bool HasVoted { get; set; }
        public int ConstituencyId { get; set; }
    }
}
