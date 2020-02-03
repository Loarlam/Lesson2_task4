﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Task4
{
    class Invoice
    {
        readonly int account;
        readonly string customer, provider;
        string article;
        int quantity;
        double costWithVAT = 0, costWithoutVAT = 0;

        public Invoice(int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }

        public string Article { set { article = value; } }
        public int Quantity { set { quantity = value; } }

        //account = номер счёта (выводим на экран)
        //customer - выведем на экран
        //provider - выведемн на экран
        //article - нужен switch, но ввыведем на экран
        //quantity - умножаем на цену товара с ндс и без ндс, выводим на экран
        void CreatesACheck(bool confirmation)
        {
            if (!confirmation) Console.WriteLine("{0} отсутствуют на складе", article);
            else
            {
                Console.WriteLine("Счёт №{0}\nЗаказчик {1}\nПоставщик {2}\n\nВ заказе:\n{3} = {4} штук\n", account, customer, provider, article, quantity);
                Console.WriteLine("Итоге:\nЦена без НДС = {0}\nЦена с НДС = {1}", costWithoutVAT, costWithVAT);
            }
        }

        public void ConsidersThePurchasePrice()
        {
            switch (article)
            {
                case "Мониторы":
                    costWithoutVAT = quantity * 2000;
                    costWithVAT = costWithoutVAT + costWithoutVAT * 0.2;
                    CreatesACheck(true);
                    break;
                case "Телефоны":
                    costWithoutVAT = quantity * 1200;
                    costWithVAT = costWithoutVAT + costWithoutVAT * 0.2;
                    CreatesACheck(true);
                    break;
                case "Клавиатуры":
                    costWithoutVAT = quantity * 300;
                    costWithVAT = costWithoutVAT + costWithoutVAT * 0.2;
                    CreatesACheck(true);
                    break;
                default:
                    CreatesACheck(false);
                    break;
            }
        }
    }
}