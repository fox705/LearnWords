using System.Collections.Generic;
using Toci.business.Quiz.Implementation;
using Toci.business.Quiz.Interfaces;

namespace Toci.business.Quiz.Mock
{
    public class QuizLogicMock : IQuizLogic
    {
        public List<IQuizEntity> GetQuizEntities(string fromLanguage, string toLanguage)
        {
            return new List<IQuizEntity>()
            {
                new QuizEntity()
                {
                    Word = "dupa",
                    Answers = new Dictionary<string, IQuizAnswer>()
                    {
                        {"ass", new QuizAnswer() { Word = "ass", IsCorrectAnswer = true}},
                        {"computer", new QuizAnswer() { Word = "computer", IsCorrectAnswer = false}},
                    }
                }
            };
        }
    }
}