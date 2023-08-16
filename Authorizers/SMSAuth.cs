


class SMSAuth : IAuthorizer
{
    private bool _authenticated = false;

    public bool Validate(string SMSCode)
    {
        Console.WriteLine($"Authenticating code {SMSCode}...");

        if (SMSCode.StartsWith("SMS"))
            _authenticated = true;

        return _authenticated;
    }

    public bool IsAuthenticated => _authenticated;
}
