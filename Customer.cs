public class Customer
{
    public Customer(string userName, int userAge, int userId)
    {
        UserName = userName;
        UserAge = userAge;
        UserId = userId;
    }

    public string UserName { get; set; }
    public int UserAge { get; set; }
    public int UserId { get; set; }


}

