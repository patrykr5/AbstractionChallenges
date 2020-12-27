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

            inputParametersDict.Add(1, new int[] { 2, 3, 1, 0 });
            inputParametersDict.Add(2, new int[] { 4, 1, 1 });
            inputParametersDict.Add(3, new int[] { 1, 0, 3, 3, 7, 2, 1 });
            inputParametersDict.Add(4, new int[] { 0 });

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

            return string.Empty;
        }
    }
}
