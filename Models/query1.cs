namespace Infro.Models;

public class Query1
{
    public int Userid { get; set; }
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public string Email { get; set; }
    public string Phonenumber { get; set; }
    public string Address { get; set; }
    public DateTime Dateofbirth { get; set; }
    public int  Orderid { get; set; }
    public DateTime OrderDate { get; set; }
    public int Totalamount { get; set; }
    public string Status { get; set; }
};

public class Query2
{
    public int  Productid { get; set; }
    public string Productname { get; set; }
    public string Description { get; set; }
    public int Price { get; set; }
    public int  StockQuantity { get; set; }
    public string Category { get; set; }
    public DateTime CreatedAt { get; set; }
    public int ReviewId { get; set; }
    public int Rating { get; set; }
    public string Comment { get; set; }
};

public class Query3
{
    public int CountOfTickets { get; set; }
}


public class Query4
{
    public int UserId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Phonenumber { get; set; }
    public string Address { get; set; }
    public DateTime Dateofbirth { get; set; }
};

public class Query5
{
    public int OrderItemId { get; set; }
    public int Suma { get; set; }
    public string ProductName { get; set; }
};


public class Query6
{
    public int Rating { get; set; }
    public string Comment { get; set; }
    public DateTime CreatedAt { get; set; }
    public string ProductName { get; set; }
};

public class Query8
{
    public string AveragePrice { get; set; }
    public string Category { get; set; }
};

public class Query9
{
    public int UserId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    
};

public class Query10
{
    public int UserId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
};


public class Query11
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public int Cnt { get; set; }
}
