namespace DbSoria.Data.Entities
{
    public class Permission : BaseEntity
    {
        public Permission()
        {
            Read = true;
            Write = false;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public bool Read { get; set; }
        public bool Write { get; set; }
    }
}