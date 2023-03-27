public  class Customer
{
    private string _userName;
    private   int _userAge;
    private  int _userId;



    public Customer(string userName, int userAge, int userId)
    {
        this._userName = userName;
        this._userAge = userAge;
        this._userId = userId;
    }
    public string userName { get; set; }
    public int userAge { get; set; }
    public int userId { get; set; }

    
}

