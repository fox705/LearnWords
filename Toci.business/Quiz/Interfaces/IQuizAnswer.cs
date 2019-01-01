namespace Toci.business.Quiz.Interfaces
{
    public interface IQuizAnswer
    {
        string Word { get; set; }

        bool IsCorrectAnswer { get; set; }
    }
}