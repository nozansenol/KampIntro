using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product   //ÜRÜN SINIFI
    {
        public int Id { get; set; }             //ID si
        public int CategoryId { get; set; }     //Kategori ID si
        public string ProductName { get; set; } //Ürün Adı
        public double UnitPrice { get; set; }   //Ürün Fiyatı
        public int UnitsInStock { get; set; }   //ürünün Stok Adedi
        

    }
}
