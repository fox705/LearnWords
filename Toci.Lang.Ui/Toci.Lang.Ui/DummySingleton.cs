namespace Toci.Lang.Ui
{
    public class DummySingleton//<T> where T : new()
    {
        public int IAmAProperty { get; set; }
        private static DummySingleton Instance;
        private DummySingleton()
        {

        }

        public static DummySingleton GetInstance()
        {
            if (Instance == null)
            {
                Instance = new DummySingleton();
            }

            return Instance;
        }
    }
}