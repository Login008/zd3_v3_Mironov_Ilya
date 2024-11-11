using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtdelLibrary
{
    public class Otdel
    {
        static private List<Otdel> list = new List<Otdel>(); //список отделов
        public Otdel(string name, double baseOklad, double k, int members, string nameOfCompany) //конструктор
        {
            this.name = name; //присвоение
            this.baseOklad = baseOklad;
            this.k = k;
            this.members = members;
            this.nameOfCompany = nameOfCompany;
        }
        protected string name; //поля отдела
        protected double baseOklad;
        protected double k;
        protected int members;
        protected string nameOfCompany;

        virtual public double GetQ() //Вывод качества отдела
        {
            if (baseOklad > 0 && k >= 0 && k <= 2 && members > 0) //проверка на адекватность значений
            {
                return baseOklad * (100 + k);
            }
            else
            {
                throw new Exception("Данные должны быть:\nБазовый оклад > 0\n0 <= Коэффицент <= 2\nКоличество сотрудников > 0");
            }
        }
        virtual public List<string[]> GetInfo() //Вывод информации в виде списка массивов
        {
            List<string[]> list1 = new List<string[]>();

            foreach (var item in list) //перебор отделов в списке и добавление их массива в новый список
            {
                string[] array = [item.name, item.baseOklad.ToString(), item.k.ToString(), item.members.ToString(), item.nameOfCompany];
                list1.Add(array);
            }

            return list1;
        }
        static public void AddOtdel(string name, double baseOklad, double k, int members, string nameOfCompany) //Добавление отдела в список
        {
            Otdel otdel = new Otdel(name, baseOklad, k, members, nameOfCompany); //Создаём объект и вызываем другую перегрузку
            otdel.AddOtdel();
        }
        static public void AddOtdel(Otdel otdel) //Перегрузка добавления отдела в список
        {
            if (otdel.baseOklad > 0 && otdel.k >= 0 && otdel.k <= 2 && otdel.members > 0) //проверка на адекватность значений
            {
                var selectedOtdels = from t in list
                                     where t.name == otdel.name && t.baseOklad == otdel.baseOklad && t.k == otdel.k && t.members == otdel.members && t.nameOfCompany == otdel.nameOfCompany
                                     select t; //с помощью linq-запроса проверяем, есть ли в списке отдел с такими же данными
                if (selectedOtdels.Count() == 0) //сама проверка
                    list.Add(otdel); //добавляем в список
                else
                    throw new Exception("Точно такой же отдел уже есть в списке");
            }
            else
                throw new Exception("Данные должны быть:\nБазовый оклад > 0\n0 <= Коэффицент <= 2\nКоличество сотрудников > 0");
        }
        virtual public void AddOtdel() //Ещё одна перегрузка
        {
            if (baseOklad > 0 && k >= 0 && k <= 2 && members > 0) //Всё то же самое, только добавляем в список отдел, с помощью которого вызвали перегрузку метода
            {
                var selectedOtdels = from t in list
                                     where t.name == name && t.baseOklad == baseOklad && t.k == k && t.members == members && t.nameOfCompany == nameOfCompany
                                     select t;
                if (selectedOtdels.Count() == 0)
                    list.Add(this);
                else
                    throw new Exception("Точно такой же отдел уже есть в списке");
            }
            else
                throw new Exception("Данные должны быть:\nБазовый оклад > 0\n0 <= Коэффицент <= 2\nКоличество сотрудников > 0");
        }
        static public void RemoveOtdel(string name, double baseOklad, double k, int members, string nameOfCompany) //Удаление отдела из списка
        {
            Otdel otdel = new Otdel(name, baseOklad, k, members, nameOfCompany); //Создаём перегрузку и вызываем другую перегрузку
            RemoveOtdel(otdel);
        }
        static public void RemoveOtdel(Otdel otdel) //Перегрузка удаления отдела
        {
            var selectedOtdels = from t in list
                                 where t.name == otdel.name && t.baseOklad == otdel.baseOklad && t.k == otdel.k && t.members == otdel.members && t.nameOfCompany == otdel.nameOfCompany
                                 select t; //Ищем наш отдел в списке
            if (selectedOtdels.Count() > 0) //Если нашли, удаляем из списка найденный объект
            {
                list.Remove(selectedOtdels.First());
            }
            else
                throw new Exception("Такой объект не был найден в списке");
        }
        virtual public void RemoveOtdel() //Ещё одна перегрузка удаления
        {
            var selectedOtdels = from t in list
                                 where t.name == name && t.baseOklad == baseOklad && t.k == k && t.members == members && t.nameOfCompany == nameOfCompany
                                 select t; //Всё то же самое, но с объектом
            if (selectedOtdels.Count() > 0)
            {
                list.Remove(selectedOtdels.First());
            }
            else
                throw new Exception("Такой объект не был найден в списке");
        }
    }
}
