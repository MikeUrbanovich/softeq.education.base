namespace TrialsSystem.UsersService.Api.Exceptions
{
    /// <summary>
    /// UserNotFondException
    /// </summary>
    public class TrialUserNotFondException : Exception
    {
        /// <summary>
        /// 
        /// </summary>
        public string Id { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public TrialUserNotFondException(string id)
        {
            Id = id;
        }
    }
}