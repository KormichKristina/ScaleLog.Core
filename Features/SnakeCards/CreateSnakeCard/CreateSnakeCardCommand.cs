
using MediatR;

namespace SnakeCards.CreateSnakeCard
{
    public class CreateSnakeCardCommand:IRequest
    {
        public string Name{get;set;} = null!;
        public string Morph{get;set;} = null!;
        public string Species{get;set;} = null!;
        public DateTimeOffset dateOfBirth{get;set;}
        public string Gender{get;set;} = null!;
    }
}