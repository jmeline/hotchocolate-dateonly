using System;

namespace Products
{
    public record Product(int Upc, string Name, int Price, int Weight, DateOnly DateOnly, DateTime DateTime);
}