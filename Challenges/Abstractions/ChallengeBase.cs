using Challenges.Models;

namespace Challenges.Abstractions
{
    public abstract class ChallengeBase
    {
        public abstract ChallengeOutput GetChallengeOutput(object inputObject);
    }
}
