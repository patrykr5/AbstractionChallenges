using ApplicationCore.Extensions;
using Challenges.Models;
using System;
using System.Diagnostics;

namespace ApplicationCore.Helpers
{
    internal class OutputFormatHelper
    {
        private static string FormatExecutionTime(TimeSpan executionTime)
        {
            return executionTime.ToStringExecutionTime() + " | ";
        }

        internal static string FormatOutput(ChallengeOutput challengeOutput, string outputMessage)
        {
            if (challengeOutput.Successful)
            {
                return string.Concat(FormatExecutionTime(challengeOutput.ExecutionTime), outputMessage);
            }

            return string.Concat(
                FormatExecutionTime(challengeOutput.ExecutionTime),
                challengeOutput.Exception.Message,
                Environment.NewLine,
                "Line number: ",
                new StackTrace(challengeOutput.Exception, true).GetFrame(0).GetFileLineNumber());
        }
    }
}
