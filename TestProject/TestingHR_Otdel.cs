using OtdelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    [TestClass]
    public class TestingHR_Otdel
    {
        //Тестирование метода GetQ
        [TestMethod]
        public void TestGetQ1() //Проверка метода GetQ на нулевые значения
        {
            HR_Otdel otdel = new HR_Otdel("", 0, 0, 0, "", 0, "", "", "");
            var result = Assert.ThrowsException<Exception>(() => otdel.GetQ());
            Assert.AreEqual("Данные должны быть:\nБазовый оклад > 0\n0 <= Коэффицент <= 2\nКоличество сотрудников > 0\n0 <= Вредность <= 3", result.Message);
        }

        [TestMethod]
        public void TestGetQ2() //Проверка метода GetQ на правильный ввод
        {
            HR_Otdel otdel = new HR_Otdel("", 2, 2, 2, "", 2, "", "", "");
            var result = otdel.GetQ();
            Assert.AreEqual(306, result);
        }

        [TestMethod]
        public void TestGetQ3() //Проверка метода GetQ на неправильный ввод
        {
            HR_Otdel otdel = new HR_Otdel("", -4, 2, 2, "", 2, "", "", "");
            var result = Assert.ThrowsException<Exception>(() => otdel.GetQ());
            Assert.AreEqual("Данные должны быть:\nБазовый оклад > 0\n0 <= Коэффицент <= 2\nКоличество сотрудников > 0\n0 <= Вредность <= 3", result.Message);
        }

        [TestMethod]
        public void TestGetQ4() //Проверка метода GetQ на граничащие значения
        {
            HR_Otdel otdel = new HR_Otdel("", 1, 2, 1, "", 3, "", "", "");
            var result = otdel.GetQ();
            Assert.AreEqual(136, result);
        }
        //Тестирование метода GetInfo

        [TestMethod]
        public void TestGetInfo1() //Проверка метода GetInfo на вывод пустых элементов
        {
            HR_Otdel otdel = new HR_Otdel("апрарпа", 2, 2, 2, "парпварп", 2, "", "", "");
            otdel.AddOtdel();
            var result = otdel.GetInfo();
            CollectionAssert.AllItemsAreNotNull(result);
        }

        [TestMethod]
        public void TestGetInfo2() //Проверка метода GetInfo на вывод только уникальных элементов
        {
            HR_Otdel otdel = new HR_Otdel("апрарпа", 2, 2, 2, "парпварп", 2, "", "", "");
            otdel.AddOtdel();

            HR_Otdel otdel1 = new HR_Otdel("gddfg", 2, 2, 2, "fffdsfd", 2, "", "", "");
            otdel1.AddOtdel();
            var result = otdel.GetInfo();
            CollectionAssert.AllItemsAreUnique(result);
        }

        //Тестирование метода AddOtdel()
        [TestMethod]
        public void TestAddOtdel3_1() //Проверка на неверные значения
        {
            HR_Otdel otdel = new HR_Otdel("", -4, 2, 2, "", 2, "", "", "");
            var result = Assert.ThrowsException<Exception>(() => otdel.AddOtdel());
            Assert.AreEqual("Данные должны быть:\nБазовый оклад > 0\n0 <= Коэффицент <= 2\nКоличество сотрудников > 0\n0 <= Вредность <= 3", result.Message);
        }

        [TestMethod]
        public void TestAddOtdel3_2() //Проверка на верные значения
        {
            HR_Otdel otdel = new HR_Otdel("", 2, 2, 2, "", 2, "", "", "");
            otdel.AddOtdel();
            Assert.AreEqual(otdel.GetInfo().Count, 1);
        }

        [TestMethod]
        public void TestAddOtdel3_3() //Проверка на добавление объекта с граничищами значениями 1
        {
            HR_Otdel otdel = new HR_Otdel("", 1, 2, 1, "", 3, "", "", "");
            otdel.AddOtdel();
            Assert.AreEqual(otdel.GetInfo().Count, 1);
        }

        [TestMethod]
        public void TestAddOtdel3_4() //Проверка на добавление объекта с граничищами значениями 2
        {
            HR_Otdel otdel = new HR_Otdel("", 1, 0, 1, "", 0, "", "", "");
            otdel.AddOtdel();
            Assert.AreEqual(otdel.GetInfo().Count, 1);
        }

        //Тестирование метода RemoveOtdel()
        [TestMethod]

        public void TestRemoveOtdel3_1() //Проверка на не найденный объект
        {
            HR_Otdel otdel = new HR_Otdel("", 2, 2, 2, "", 2, "", "", "");
            HR_Otdel otdel1 = new HR_Otdel("", 1, 1, 1, "", 1, "", "", "");
            otdel.AddOtdel();
            var result = Assert.ThrowsException<Exception>(() => otdel1.RemoveOtdel());
            Assert.AreEqual("Такой объект не был найден в списке", result.Message);
        }
        [TestMethod]
        public void TestRemoveOtdel3_2() //Проверка на найденный объект
        {
            HR_Otdel otdel = new HR_Otdel("", 2, 2, 2, "", 2, "", "", "");
            otdel.AddOtdel();
            otdel.RemoveOtdel();
            Assert.AreEqual(otdel.GetInfo().Count, 0);
        }
        //Тестирование метода GetPValue
        [TestMethod]
        public void TestGetPValue1() //Проверка на найденные объекты
        {
            HR_Otdel otdel = new HR_Otdel("", 2, 2, 2, "", 2, "", "", "");
            otdel.AddOtdel();
            HR_Otdel otdel1 = new HR_Otdel("", 2, 2, 3, "", 2, "", "", "");
            otdel1.AddOtdel();
            HR_Otdel otdel2 = new HR_Otdel("", 2, 2, 4, "", 1, "", "", "");
            otdel2.AddOtdel();

            var result = HR_Otdel.GetPValue(2);

            Assert.AreEqual(result.Count(), 2);
        }
        [TestMethod]
        public void TestGetPValue2() //Проверка на не найденные объекты
        {
            HR_Otdel otdel = new HR_Otdel("", 2, 2, 2, "", 2, "", "", "");
            otdel.AddOtdel();
            HR_Otdel otdel1 = new HR_Otdel("", 2, 2, 3, "", 2, "", "", "");
            otdel1.AddOtdel();
            HR_Otdel otdel2 = new HR_Otdel("", 2, 2, 4, "", 1, "", "", "");
            otdel2.AddOtdel();

            var result = HR_Otdel.GetPValue(0);

            Assert.AreEqual(result.Count(), 0);
        }
    }
}
