using ApplicationCore.Extensions;
using ApplicationCore.Helpers;
using ApplicationCore.Services.Interfaces;
using Challenges.Abstractions;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Services
{
    internal class ChallengeService : IChallengeService
    {
        private readonly ChallengeBase challengeBase;

        public ChallengeService(ChallengeBase challengeBase)
        {
            this.challengeBase = challengeBase;
        }

        public string GetChallengeOutputData()
        {
            StringBuilder builder = new StringBuilder();

            foreach (var inputParametersDict in GetInputParameters())
            {
                var challengeOutput = challengeBase.GetChallengeOutput(inputParametersDict.Value);
                builder.AppendLine(OutputFormatHelper.FormatOutput(challengeOutput, RetriveOutputMessage(challengeOutput.Output)));
            }

            return builder.ToString();
        }

        private IDictionary<int, object> GetInputParameters()
        {
            IDictionary<int, object> inputParametersDict = new Dictionary<int, object>();

            inputParametersDict.Add(1, new int[] { 1 });
            inputParametersDict.Add(2, new int[] { 2, 4, 3 });

            return inputParametersDict;
        }

        // TODO Add support for other types
        private string RetriveOutputMessage(object output)
        {
            if (output != null)
            {
                var type = output.GetType();

                if (type == typeof(int[]))
                {
                    return ((int[])output).ToJoinString();
                }
            }

            return output.ToString();
        }
    }
}
