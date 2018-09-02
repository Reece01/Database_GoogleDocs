using HwidGetter;
namespace Test_GoogleDocs.ConsoleMenu
{
    internal class User
    {

        public static string Hwid()
        {
            string data = HwidGetter.HWID_Getter.HWID_GET.Value();
            return data;
        }
    }
}