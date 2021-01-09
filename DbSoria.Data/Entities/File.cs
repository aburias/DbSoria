namespace DbSoria.Data.Entities
{
    public class File : BaseEntity
    {
        public string Name { get; set; }
        public string Extension { get; set; }
        public string MimeType { get; set; }
        public byte[] Data { get; set; }
        public bool IsBlob { get; set; }
        public string ExternalUrl { get; set; }
    }
}