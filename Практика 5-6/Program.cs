using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Практика_5_6
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int cc = 0;
            Console.WriteLine("Список товара,который есть в наличии");
            List<Tovarka> TovarList = new List<Tovarka>();
            TovarList.Add(new Tovarka(1, "Танк", "Русский Т-90", "Казанский завод!", "65млн.Руб.", "Да,покупайте сколько хотите!",50));
            TovarList.Add(new Tovarka(2, "Дуло", "Объект МЧ-9", "Казанский завод!", "5млн.Руб.", "Да,есть!",5));
            TovarList.Add(new Tovarka(3, "Гусеница", "В разборке на Т-90", ",Беларусский завод завод!", "25млн.Руб.", "Да,БОЛЕЕ 10 штук!",70));
            TovarList.Add(new Tovarka(4, "Кумуль", "Пробивная разрывная реакция", "Московский завод завод!", "100тыс.Руб.", "Да,бесконечность!",650));
            TovarList.Add(new Tovarka(5, "Башня", "УПРС-202-РК", "Казанский завод!", "15млн.Руб.", "Да,покупайте сколько хотите!",10));
            foreach (var Komplectyushie in TovarList)
            {
                Console.WriteLine(Komplectyushie);
            }
                Console.WriteLine("Выберите команду:");
                Console.WriteLine("1- Найти товар по названию и описанию");
                Console.WriteLine("2- Сортировка товара по возрастанию цены и фильтрация производителя");
                Console.WriteLine("3- Сортировка товара по убыванию цены и фильтрация производителя");
                //int cam = Convert.ToInt32(Console.ReadLine());
                if ((!int.TryParse(Console.ReadLine(), out var cam)) || cam < 1 || cam > 3)
                {
                    Console.WriteLine("Ошибка, недопустимы диапазон!");
                }
                else
                {
                    if (cam == 1)
                    {
                        int b = 0;
                        Console.WriteLine("Введите название или описание товара:");
                        string s = Console.ReadLine();
                        var sorted1 = from p in TovarList
                                      orderby p.Name, p.Opisanie
                                      select p;

                        foreach (var p in sorted1)
                        {

                            if (s == p.Name || s == p.Opisanie)
                            {
                                cc = p.Colichestvo;
                                Console.WriteLine($"Параметр: {p.Parametr}, Наименование: {p.Name}, Описание: {p.Opisanie}, Производитель: {p.Proizvoditel}, Цена: {p.Price}руб., Активный:{p.Activity}, Количество:{p.Colichestvo}");
                                b++;
                            }
                        }
                        if (b == 0)
                        {
                            Console.WriteLine("Такого товара нет!");
                        }
                    }

                    if (cam == 2)
                    {

                        var sorted2 = from p in TovarList
                                      orderby p.Price, p.Proizvoditel
                                      select p;
                        foreach (var p in sorted2)
                            Console.WriteLine(p);
                    }

                    if (cam == 3)
                    {

                        var sorted2 = from p in TovarList
                                      orderby p.Price descending, p.Proizvoditel
                                      select p;
                        foreach (var p in sorted2)
                            Console.WriteLine(p);
                    }

                    Console.WriteLine("Введите название товара для покупки:");
                    string ss = Console.ReadLine();
                    var sorted3 = from r in TovarList
                                  orderby r.Name
                                  select r;

                    foreach (var r in sorted3)
                    {
                        if (ss == r.Name)
                        {
                        cc = r.Colichestvo;
                            Console.WriteLine($"Параметр: {r.Parametr}, Наименование: {r.Name}, Описание: {r.Opisanie}, Производитель: {r.Proizvoditel}, Цена: {r.Price}руб., Активный:{r.Activity}, Количество:{r.Colichestvo}");
                        }
                    }

                    Console.WriteLine("Введите количество товара:");
                    if ((!int.TryParse(Console.ReadLine(), out var call)) || call < 1 || call > cc)
                    {
                        Console.WriteLine("Ошибка!");
                    }
                    else
                    {
                        Console.WriteLine("Выберите вид оплаты:");
                        Console.WriteLine("1- Банковскаякарта");
                        Console.WriteLine("2- Google pay");
                        Console.WriteLine("3- Apple pay");
                        Console.WriteLine("4- Наличные");
                        if ((!int.TryParse(Console.ReadLine(), out var plata)) || plata < 1 || plata > 4)
                        {
                            Console.WriteLine("Ошибка!");
                        }
                        else
                        {
                            Console.WriteLine("Введите ваше ФИО и номер телефона");
                            string fioPh = Console.ReadLine();
                            Console.WriteLine("Выберите вид доставки:");
                            Console.WriteLine("1- Самовывоз");
                            Console.WriteLine("2- Доставка");
                            Console.WriteLine("3- Срочная доставка");
                            if ((!int.TryParse(Console.ReadLine(), out var dostavka)) || dostavka < 1 || dostavka > 3)
                            {
                                Console.WriteLine("Ошибка!");
                            }
                            else
                            {
                                if (dostavka == 2 || dostavka == 3)
                                {
                                    Console.WriteLine("Введите адрес(улица, дом квартира):");
                                    string adres = Console.ReadLine();
                                    Console.WriteLine("Заказ оформлен!");
                                }
                                else
                                {
                                    Console.WriteLine("Ошибка");
                                }
                            }
                        }
                    }
                }
            
        }
    }

}
