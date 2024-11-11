using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtdelLibrary
{
    public class HR_Otdel : Otdel
    {
        static private Dictionary<int, HR_Otdel> dict = new Dictionary<int, HR_Otdel>(); //словарь HR-отделов

        private double p; //доп. поле вредности
        private int index; //для словаря
        static private int count = 0;
        public string Speciality { get; set; } //свойства
        public string GenDirector { get; set; }
        public string TechDirector { get; set; }
        public HR_Otdel(string name, double baseOklad, double k, int members, string nameOfCompany, double p, string speciality, string genDirector, string techDirector) : base(name, baseOklad, k, members, nameOfCompany) //конструктор
        {
                count++; //для уникальности ключей в словаре
                index = count;
                this.p = p; //присвоение вредности и свойств

                Speciality = speciality;
                GenDirector = genDirector;
                TechDirector = techDirector;
            
        }
        override public double GetQ() //Переписанный метод получения качества
        {
            if (baseOklad > 0 && k >= 0 && k <= 2 && members > 0 && p >= 0 && p <= 3) //проверка на адекватность значений
            {
                return base.GetQ() + base.GetQ() / p;
            }
            else
                throw new Exception("Данные должны быть:\nБазовый оклад > 0\n0 <= Коэффицент <= 2\nКоличество сотрудников > 0\n0 <= Вредность <= 3");
        }
        public override List<string[]> GetInfo() //Переписанный метод получения информации об объектах
        {
            List<string[]> list1 = new List<string[]>();

            foreach (var item in dict)
            {
                string[] array = [item.Value.name, item.Value.baseOklad.ToString(), item.Value.k.ToString(),
                    item.Value.members.ToString(), item.Value.nameOfCompany, item.Value.p.ToString(), item.Value.Speciality,
                    item.Value.GenDirector, item.Value.TechDirector];
                list1.Add(array);
            }

            return list1;
        }
        public override void AddOtdel() //Переписанный метод добавления
        {
            if (baseOklad > 0 && k >= 0 && k <= 2 && members > 0 && p >= 0 && p <= 3)
            {
                var selectedOtdels = from t in dict
                                     where t.Value.name == name && t.Value.baseOklad == baseOklad && t.Value.k == k && t.Value.members == members && t.Value.nameOfCompany == nameOfCompany && t.Value.p == p
                                     select t;
                if (selectedOtdels.Count() == 0)
                    dict.Add(index, this);
                else
                    throw new Exception("Точно такой же отдел уже есть в таблице");
            }
            else
                throw new Exception("Данные должны быть:\nБазовый оклад > 0\n0 <= Коэффицент <= 2\nКоличество сотрудников > 0\n0 <= Вредность <= 3");
        }
        public override void RemoveOtdel() //Переписанный метод удаления
        {
            var selectedOtdels = from t in dict
                                 where t.Value.name == name && t.Value.baseOklad == baseOklad && t.Value.k == k && t.Value.members == members && t.Value.nameOfCompany == nameOfCompany && t.Value.p == p
                                 select t;
            if (selectedOtdels.Count() > 0)
            {
                dict.Remove(selectedOtdels.First().Key);
            }
            else
                throw new Exception("Такой объект не был найден в списке");
        }
        static public IEnumerable<string> GetPValue(double value) //Метод нахождения HR-отделов с определённой вредностью P
        {
            var selectedOtdels = from t in dict //ищем в словаре отделы с определённой вредностью с помощью linq и добавляем в список сообщение
                                 where t.Value.p == value
                                 select $"Отдел: {t.Value.name} Компания: {t.Value.nameOfCompany}";

            return selectedOtdels; //возвращаем список
        }
    }
}
