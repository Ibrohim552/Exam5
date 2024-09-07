namespace Infro.Models;

public class SqlCommand
{
    public const string Query = @"select u.UserId ,u.firstname,u.lastname,u.email,u.phonenumber,u.address,u.dateofbirth,
o.orderid,o.orderdate,o.TotalAmount, o.Status from users u
join orders o On u.userid = o.userid";
    
    public const string Query2 = @"select p.productid,p.productname ,p.description,p.price,p.StockQuantity, p.Category,
p.CreatedAt , r.ReviewId, r.Rating, r.Comment from products p 
join Reviews r on p.productid =r.productid
order by r.CreatedAt";
    
    
    public const string Query3=@"select count(TicketId) as CountOfTickets from SupportTickets
group by   IssueType ";



    public const string Query4 = @"select u.UserId ,u.firstname,u.lastname,u.email,u.phonenumber,u.address,u.dateofbirth
from users u join orders o on u.userid = o.userid
join orderitems ot on o.userid = ot.orderid
where ot.orderitemid>5";


    public const string Query5 = @"select o.OrderItemId ,sum(o.price) as suma,p.productname
from orderitems o join products p
on o.productid = p.productid
group by o.orderitemid,p.productname
";



    public const string Query6 = @"select r.rating, r.Comment ,r.CreatedAt ,p.productname
from Reviews r join products p 
on r.productid = p.productid";


    public const string Query7 = @"select o.orderid o.orderdate,o.totalamount, o.orderdate
from orders o ";


    public const string Query8 = @"select avg(o.price) as averageprice, p.category
from orderitems o join products p 
on o.productid = p.productid
group by p.category";

    public const string Query9 = @"select u.userid, u.firstname, u.lastname,u.email
from users u join Reviews r on u.userid = r.userid
where r.Rating >4
";


    public const string Query10 = @"select u.userid, u.firstname, u.lastname , u.email
from users u join SupportTickets s on 
u.userid = s.userid 
where s.status = 'Closed'";

    public const string Query11 = @"select p.productid, p.productname , count(r.ReviewId) as Cnt
from products p join Reviews r
on p.productid = r.productid
group by p.productid , p.productname
order by cnt desc
limit 5 
";
    
}