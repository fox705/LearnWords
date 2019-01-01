using System.Collections.Generic;

namespace Toci.business.Quiz.Interfaces
{
    public interface IQuizEntity
    {
        string Word { get; set; }

        Dictionary<string, IQuizAnswer> Answers { get; set; }
    }
}