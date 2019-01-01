using Toci.business.Quiz.Interfaces;

namespace Toci.business.Quiz.Implementation
{
    public class QuizAnswer : IQuizAnswer
    {
        public string Word { get; set; }

        public bool IsCorrectAnswer { get; set; }
    }
}