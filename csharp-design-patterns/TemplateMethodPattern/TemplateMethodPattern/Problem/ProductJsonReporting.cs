﻿namespace TemplateMethodPattern.Problem;

public class ProductJsonReporting
{
    public void Send()
    {
        var products = GetProducts();

        var output = Transform(products);

        var recipient = GetRecipient();

        SendEmail(output, recipient);
    }

    private Product[] GetProducts()
        => [.. ProductService.GetProducts().OrderBy(e => e.Name)];

    private string Transform(Product[] products) 
        => "JSON output";

    private string GetRecipient()
        => "default recipient";

    private void SendEmail(string output, string recipient)
        => Console.WriteLine($"Sent {output} to {recipient}");
}