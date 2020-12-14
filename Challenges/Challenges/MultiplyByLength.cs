using Challenges.Abstractions;
using Challenges.Models;
using System;
using System.Diagnostics;

namespace Challenges.Challenges
{
    public class MultiplyByLength : ChallengeBase
    {
        // TODO Create target algorithm
        public override ChallengeOutput GetChallengeOutput(object inputObject)
        {
            var stopWatch = Stopwatch.StartNew();
            try
            {
                var result = new int[] { 1, 2 };

                return new ChallengeOutput(true, result, stopWatch.Elapsed);
            }
            catch (Exception ex)
            {
                return new ChallengeOutput(true, stopWatch.Elapsed, ex);
            }
        }
    }
}
