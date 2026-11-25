
namespace Infrastructure
{
    public record SqlResourceEntity
    {
        public string Path{get;set;}

        public SqlResourceEntity(string path)=>Path = path;
    }
}