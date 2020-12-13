using ApplicationCore.Helpers;
using ApplicationCore.Services.Interfaces;
using Challenges.Abstractions;
using System.Text;

namespace ApplicationCore.Services
{
    internal class ChallengeService : IChallengeService
    {
        private readonly ChallengeBasedOnArray challengeBasedOnArray;

        public ChallengeService(ChallengeBasedOnArray challengeBasedOnArray)
        {
            this.challengeBasedOnArray = challengeBasedOnArray;
        }

        public string GetOutputData()
        {
            StringBuilder builder = new StringBuilder();

            var value = challengeBasedOnArray.GetChallengeBasedOnArray(new int[] { });

            builder.AppendLine(value.ToString());

            return OutputFormatHelper.FormatOutput(builder);
        }
    }
}
