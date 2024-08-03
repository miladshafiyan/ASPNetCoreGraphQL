using ASPNetCoreGraphQL.GraphQl.Data;

namespace ASPNetCoreGraphQL.GraphQl
{
    public class AddSpeakerPayload
    {
        public AddSpeakerPayload(Speaker speaker)
        {
            Speaker = speaker;
        }

        public Speaker Speaker { get; }
    }
}
