


class SecurityCodeAuth : IAuthorizer
{
    private bool _authenticated = false;

    public bool Validate(string authCode)
    {
        if (!(authCode.Length < 2 && authCode.Contains('A')))
            _authenticated = true;

        return _authenticated;
    }
    public bool IsAuthenticated => _authenticated;

}
