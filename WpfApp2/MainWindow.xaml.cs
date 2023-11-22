using System;
using System.Collections.Generic;

// Объявление сущностей для заказа еды
public class FoodItem
{
    public int FoodItemId { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Category { get; set; }
}

public class Order
{
    public int OrderId { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal TotalAmount { get; set; }
    public List<FoodItem> FoodItems { get; set; }
}

// Обработчик запроса на заказ еды
public class FoodOrderHandler
{
    // Метод для создания нового заказа
    public Order CreateOrder()
    {
        // Создаем список позиций еды
        List<FoodItem> foodItems = new List<FoodItem>()
        {
            new FoodItem() { FoodItemId = 1, Name = "Пицца", Price = 10.99m, Category = "Итальянская" },
            new FoodItem() { FoodItemId = 2, Name = "Суши", Price = 15.99m, Category = "Японская" },
            new FoodItem() { FoodItemId = 3, Name = "Бургер", Price = 8.99m, Category = "Американская" }
        };

        // Создаем объект заказа
        Order order = new Order() { OrderId = 1, OrderDate = DateTime.Now, TotalAmount = 35.97m, FoodItems = foodItems };

        return order;
    }
}
