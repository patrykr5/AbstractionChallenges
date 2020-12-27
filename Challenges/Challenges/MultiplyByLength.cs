using Challenges.Abstractions;
using Challenges.Models;
using System;
using System.Diagnostics;

namespace Challenges.Challenges
{
    public class MultiplyByLength : ChallengeBase
    {
        // Good solution, if acceptable is operations on input object
        public override ChallengeOutput GetChallengeOutput(object inputObject)
        {
            int[] inputArray = (int[])inputObject;
            var stopWatch = Stopwatch.StartNew();

            try
            {
                int inputArrayLength = inputArray.Length;

                for (int i = 0; i < inputArrayLength; i++)
                {
                    inputArray[i] *= inputArrayLength;
                }

                return new ChallengeOutput(true, inputArray, stopWatch.Elapsed);
            }
            catch (Exception ex)
            {
                return new ChallengeOutput(true, stopWatch.Elapsed, ex);
            }
        }

        //public override ChallengeOutput GetChallengeOutput(object inputObject)
        //{
        //    int[] inputArray = (int[])inputObject;
        //    var stopWatch = Stopwatch.StartNew();

        //    try
        //    {
        //        int inputArrayLength = inputArray.Length;
        //        int[] targetArray = new int[inputArrayLength];

        //        for (int i = 0; i < inputArrayLength; i++)
        //        {
        //            targetArray[i] = inputArray[i] * inputArrayLength;
        //        }

        //        return new ChallengeOutput(true, targetArray, stopWatch.Elapsed);
        //    }
        //    catch (Exception ex)
        //    {
        //        return new ChallengeOutput(true, stopWatch.Elapsed, ex);
        //    }
        //}
    }
}
