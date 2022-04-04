using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_5_6
{
    public class Tovarka
    {
        public Tovarka(int parametr,string name, string opisanie, string proizvoditel, string price, string activity,int colichestvo)
        {
            Parametr = parametr;
            Name = name;
            Opisanie = opisanie;
            Proizvoditel = proizvoditel;
            Price = price;
            Activity = activity;
            Colichestvo = colichestvo;
        }

        public int Parametr { get; set; }
        public string Name { get; set; }
        public string Opisanie { get; set; }
        public string Proizvoditel { get; set; }
        public string Price { get; set; } 
        public string Activity { get; set; }
        public int Colichestvo { get; set; }

        public override string ToString()
        {
            return "Параметр товара" + " " + Parametr + " " +  "Наименование товара:" + Name + " " + "Описание:" + Opisanie + " " + "Производитель:" + Proizvoditel + " " + "Цена:" + Price + " " + "Актуальный?" + Activity + " " + "Количество"  + " " + Colichestvo;
        }
        public override bool Equals(object Tovar) /*Осуществление на то что значения не повторялись и пуст ли список?*/
        {
            if (Tovar == null) return false;
            Tovarka objAsPart = Tovar as Tovarka;
            if (objAsPart == null) return false;
            else return Equals(objAsPart);
        }
        public override int GetHashCode()
        {
            return Parametr;
        }
        public bool Equals(Tovarka other)
        {
            if (other == null) return false;
            return (this.Parametr.Equals(other.Parametr));
        }
    }
}
