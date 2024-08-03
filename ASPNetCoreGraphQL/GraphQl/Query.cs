using ASPNetCoreGraphQL.GraphQl.Data;

namespace ASPNetCoreGraphQL.GraphQl
{
    public class Query
    {
        public IQueryable<Speaker> GetSpeakers([Service] ApplicationDbContext context) =>
            context.Speakers;
    }
}
