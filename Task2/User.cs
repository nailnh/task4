
internal class User
{
    private string _username;
    private string _password;
    public string Username
    {
        get { return _username; }
        set
        {
            if (!string.IsNullOrEmpty(value.Trim(' ')) && value.Length > 1 && value.Length < 50)
            {
                _username = value;
            }
            else
            {
                Console.WriteLine("Enter correct Username");
            }
        }
    }
    public string Password
    {
        get { return _password; }
        set
        {
            if (!string.IsNullOrEmpty(value.Trim(' ')) && value.Length > 1 && value.Length < 50)
            {
                _password = value;
            }
            else
            {
                Console.WriteLine("Enter correct Password");
            }
        }
    }



}