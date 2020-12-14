using ApplicationCore.Services;
using ApplicationCore.Services.Interfaces;
using Challenges.Challenges;
using System;

namespace ApplicationCore
{
    internal class Program
    {
        private static void Main()
        {
            IChallengeService challengeService = new ChallengeService(new MultiplyByLength());

            Console.WriteLine(challengeService.GetChallengeOutputData());
        }
    }
}
