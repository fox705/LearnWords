using System.Collections.Generic;

namespace Toci.business.Quiz.Interfaces
{
    public interface IQuizLogic
    {
        List<IQuizEntity> GetQuizEntities(string fromLanguage, string toLanguage);
    }
}