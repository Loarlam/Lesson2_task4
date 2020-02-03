/*
Используя Visual Studio, создайте проект по шаблону Console Application.  
Требуется:  
Создать класс Invoice. 
В теле класса создать три поля int account, string customer, string provider которые должны быть проинициализированы один раз (при создании экземпляра данного класса) без возможности их дальнейшего изменения. 
В теле класса создать два закрытых поля string article, int quantity 
Создать метод расчета стоимости заказа с НДС и без НДС. 
Написать программу, которая выводит на экран сумму оплаты заказанного товара с НДС или без НДС. 
*/
using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            //В 21 строке Article можно присвоить: "Монитора", "Телефоны", "Клавиатуры"
            Invoice invoice = new Invoice(951, "Школа №13", "Comp-city")
            {
                Article = "Мониторы",
                Quantity = 28
            };

            invoice.ConsidersThePurchasePrice();

            Console.ReadKey();
        }
    }
}
