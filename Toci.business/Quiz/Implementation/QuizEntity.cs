using System.Collections.Generic;
using Toci.business.Quiz.Interfaces;

namespace Toci.business.Quiz.Implementation
{
    public class QuizEntity : IQuizEntity
    {
        public string Word { get; set; }

        public Dictionary<string, IQuizAnswer> Answers { get; set; }
    }
}