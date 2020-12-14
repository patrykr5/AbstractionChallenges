using System;

namespace Challenges.Models
{
    public class ChallengeOutput
    {
        public bool Successful { get; set; }
        public object Output { get; set; }
        public TimeSpan ExecutionTime { get; set; }
        public Exception Exception { get; set; }

        public ChallengeOutput(bool successful, object output, TimeSpan executionTime, Exception exception = null)
        {
            Successful = successful;
            Output = output;
            ExecutionTime = executionTime;
            Exception = exception;
        }

        public ChallengeOutput(bool successful, TimeSpan executionTime, Exception exception = null)
        {
            Successful = successful;
            ExecutionTime = executionTime;
            Exception = exception;
        }
    }
}
