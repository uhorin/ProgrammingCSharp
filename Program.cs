//Ваша програма повинна містити наступні елементи:
//Створення інтерфейсу IOrder, який містить методи для додавання товарів, видалення товарів та отримання загальної вартості замовлення.
//Створення класу Order, який реалізує інтерфейс IOrder та містить методи для роботи з замовленнями.
//Побудова ієрархії класів для товарів: базовий клас Product, який містить загальні властивості, та похідні класи, наприклад, FoodProduct, ElectronicProduct тощо.
//Використання конструкторів для ініціалізації об'єктів класів та деструкторів для звільнення ресурсів.
//Визначення події для сповіщення про зміну статусу замовлення та організація взаємодії об'єктів через цю подію.
//Реалізація узагальненого класу для зберігання списку товарів у замовленні.
//Створення класів винятків для обробки помилок під час роботи з замовленнями.

using System;
public interface IOrder
{
    public void AddGoods(object item);
    public void RemoveGoods(object item);
    public double TotalPrice();
}
class Order : IOrder
{
    public List<Product> orders = new List<Product>();
    public void AddGoods(Product product)
    {
        orders.Add(product);
    }
    public void RemoveGoods(Product product)
    {
        orders.Remove(product);
    }
    public double TotalPrice()
    {
        double sum = 0;
        foreach(var good in orders)
        {
            sum+= good.Price;
        }
        return sum;
    }
}
class Product
{
    public string Title { get; set; }
    public double Price { get; set; }
    public Product(string title = "", double price = 0.0)
    {
        Title=title;
        Price=price;
    }
    public override string ToString()
    {
        return $"Title: {Title}\nPrice: {Price}";
    }
}
class FoodProduct : Product
{
    public string Type { get; set; }
    public FoodProduct(string title, double price, string type=""):base(title, price)
    {
        Type=type;
    }
    public override string ToString()
    {
        return "Food Product\n" + base.ToString() + $"\nType: {Type}";
    }
}
class ElectronicProduct: Product
{
    public string Type { get; set; }
    public ElectronicProduct(string title, double price, string type=""):base(title, price)
    {
        Type=type;
    }
    public override string ToString()
    {
        return "Electronic Product\n" + base.ToString() + $"\nType: {Type}";
    }

}
class GenericClass<T>
{
   public List<T> goods = new List<T>;
}

class Program
{
    static void Main(string[] args)
    {
        FoodProduct prod1 = new FoodProduct("aaaa", 120.6, "ababa");
        ElectronicProduct prod2 = new ElectronicProduct("bbbb", 300.0, "apapa");

        
    }
}

