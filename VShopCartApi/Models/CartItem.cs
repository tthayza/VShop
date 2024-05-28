using System.Net.Http.Headers;

namespace VShopCartApi.Models;

public class CartItem
{
    public int Id { get; set; }
    public int Quantity { get; set; } = 1;
    public int ProductId { get; set; }
    public int CartHeaderId { get; set; }
    public Product product { get; set; } = new Product();
    public CartHeader CartHeader { get; set; } = new CartHeader();

}
