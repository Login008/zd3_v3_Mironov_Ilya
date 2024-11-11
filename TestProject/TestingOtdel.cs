using OtdelLibrary;

namespace TestProject
{
    [TestClass]
    public class TestingOtdel
    {
        //Тестирование метода GetQ
        [TestMethod]
        public void TestGetQ1() //Проверка метода GetQ на нулевые значения
        {
            Otdel otdel = new Otdel("", 0, 0, 0, "");
            var result = Assert.ThrowsException<Exception>(() => otdel.GetQ());
            Assert.AreEqual("Данные должны быть:\nБазовый оклад > 0\n0 <= Коэффицент <= 2\nКоличество сотрудников > 0", result.Message);
        }

        [TestMethod]
        public void TestGetQ2() //Проверка метода GetQ на правильный ввод
        {
            Otdel otdel = new Otdel("", 2, 2, 2, "");
            var result = otdel.GetQ();
            Assert.AreEqual(204, result);
        }

        [TestMethod]
        public void TestGetQ3() //Проверка метода GetQ на неправильный ввод
        {
            Otdel otdel = new Otdel("", -4, 2, 2, "");
            var result = Assert.ThrowsException<Exception>(() => otdel.GetQ());
            Assert.AreEqual("Данные должны быть:\nБазовый оклад > 0\n0 <= Коэффицент <= 2\nКоличество сотрудников > 0", result.Message);
        }

        [TestMethod]
        public void TestGetQ4() //Проверка метода GetQ на граничащие значения
        {
            Otdel otdel = new Otdel("", 1, 2, 1, "");
            var result = otdel.GetQ();
            Assert.AreEqual(102, result);
        }
        //Тестирование метода GetInfo

        [TestMethod] 
        public void TestGetInfo1() //Проверка метода GetInfo на вывод пустых элементов
        {
            Otdel otdel = new Otdel("апрарпа", 2, 2, 2, "парпварп");
            otdel.AddOtdel();

            Otdel otdel1 = new Otdel("gddfg", 2, 2, 2, "fffdsfd");
            otdel1.AddOtdel();
            var result = otdel.GetInfo();
            CollectionAssert.AllItemsAreNotNull(result);
        }

        [TestMethod]
        public void TestGetInfo2() //Проверка метода GetInfo на вывод только уникальных элементов
        {
            Otdel otdel = new Otdel("апрарпа", 2, 2, 2, "парпварп");
            otdel.AddOtdel();

            Otdel otdel1 = new Otdel("gddfg", 2, 2, 2, "fffdsfd");
            otdel1.AddOtdel();
            var result = otdel.GetInfo();
            CollectionAssert.AllItemsAreUnique(result);
        }
        //Тестирование метода AddOtdel(string name, double baseOklad, double k, int members, string nameOfCompany)

        [TestMethod]
        public void TestAddOtdel1_1() //Проверка на неверные значения
        {
            var result = Assert.ThrowsException<Exception>(() => Otdel.AddOtdel("", -4, 2, 2, ""));
            Assert.AreEqual("Данные должны быть:\nБазовый оклад > 0\n0 <= Коэффицент <= 2\nКоличество сотрудников > 0", result.Message);
        }

        [TestMethod]
        public void TestAddOtdel1_2() //Проверка на верные значения
        {
            Otdel.AddOtdel("", 2, 2, 2, "");
            Otdel otdel = new Otdel("", 0, 0, 0, "");
            Assert.AreEqual(otdel.GetInfo().Count, 1);
        }

        [TestMethod]
        public void TestAddOtdel1_3() //Проверка на добавление объекта с граничищами значениями 1
        {
            Otdel.AddOtdel("", 1, 2, 1, "");
            Otdel otdel = new Otdel("", 0, 0, 0, "");
            Assert.AreEqual(otdel.GetInfo().Count, 1);
        }

        [TestMethod]
        public void TestAddOtdel1_4() //Проверка на добавление объекта с граничищами значениями 2
        {
            Otdel.AddOtdel("", 1, 0, 1, "");
            Otdel otdel = new Otdel("", 0, 0, 0, "");
            Assert.AreEqual(otdel.GetInfo().Count, 1);
        }
        //Тестирование метода AddOtdel(Otdel otdel)
        [TestMethod]
        public void TestAddOtdel2_1() //Проверка на неверные значения
        {
            Otdel otdel = new Otdel("", -4, 2, 2, "");
            var result = Assert.ThrowsException<Exception>(() => Otdel.AddOtdel(otdel));
            Assert.AreEqual("Данные должны быть:\nБазовый оклад > 0\n0 <= Коэффицент <= 2\nКоличество сотрудников > 0", result.Message);
        }

        [TestMethod]
        public void TestAddOtdel2_2() //Проверка на верные значения
        {
            Otdel otdel = new Otdel("", 2, 2, 2, "");
            Otdel.AddOtdel(otdel);
            Assert.AreEqual(otdel.GetInfo().Count, 1);
        }

        [TestMethod]
        public void TestAddOtdel2_3() //Проверка на добавление объекта с граничищами значениями 1
        {
            Otdel otdel = new Otdel("", 1, 2, 1, "");
            Otdel.AddOtdel(otdel);
            Assert.AreEqual(otdel.GetInfo().Count, 1);
        }

        [TestMethod]
        public void TestAddOtdel2_4() //Проверка на добавление объекта с граничищами значениями 2
        {
            Otdel otdel = new Otdel("", 1, 0, 1, "");
            Otdel.AddOtdel(otdel);
            Assert.AreEqual(otdel.GetInfo().Count, 1);
        }
        //Тестирование метода AddOtdel()
        [TestMethod]
        public void TestAddOtdel3_1() //Проверка на неверные значения
        {
            Otdel otdel = new Otdel("", -4, 2, 2, "");
            var result = Assert.ThrowsException<Exception>(() => otdel.AddOtdel());
            Assert.AreEqual("Данные должны быть:\nБазовый оклад > 0\n0 <= Коэффицент <= 2\nКоличество сотрудников > 0", result.Message);
        }

        [TestMethod]
        public void TestAddOtdel3_2() //Проверка на верные значения
        {
            Otdel otdel = new Otdel("", 2, 2, 2, "");
            otdel.AddOtdel();
            Assert.AreEqual(otdel.GetInfo().Count, 1);
        }

        [TestMethod]
        public void TestAddOtdel3_3() //Проверка на добавление объекта с граничищами значениями 1
        {
            Otdel otdel = new Otdel("", 1, 2, 1, "");
            otdel.AddOtdel();
            Assert.AreEqual(otdel.GetInfo().Count, 1);
        }

        [TestMethod]
        public void TestAddOtdel3_4() //Проверка на добавление объекта с граничищами значениями 2
        {
            Otdel otdel = new Otdel("", 1, 0, 1, "");
            otdel.AddOtdel();
            Assert.AreEqual(otdel.GetInfo().Count, 1);
        }
        //Тестирование метода RemoveOtdel(string name, double baseOklad, double k, int members, string nameOfCompany)
        [TestMethod]
        public void TestRemoveOtdel1_1() //Проверка на не найденный объект
        {
            Otdel otdel = new Otdel("", 2, 2, 2, "");
            otdel.AddOtdel();
            var result = Assert.ThrowsException<Exception>(() => Otdel.RemoveOtdel("", 1, 1, 1, ""));
            Assert.AreEqual("Такой объект не был найден в списке", result.Message);
        }
        [TestMethod]
        public void TestRemoveOtdel1_2() //Проверка на найденный объект
        {
            Otdel otdel = new Otdel("", 2, 2, 2, "");
            otdel.AddOtdel();
            Otdel.RemoveOtdel("", 2, 2, 2, "");
            Assert.AreEqual(otdel.GetInfo().Count, 0);
        }
        //Тестирование метода RemoveOtdel(Otdel otdel)
        [TestMethod]
        public void TestRemoveOtdel2_1() //Проверка на не найденный объект
        {
            Otdel otdel = new Otdel("", 2, 2, 2, "");
            Otdel otdel1 = new Otdel("", 1, 1, 1, "");
            otdel.AddOtdel();
            var result = Assert.ThrowsException<Exception>(() => Otdel.RemoveOtdel(otdel1));
            Assert.AreEqual("Такой объект не был найден в списке", result.Message);
        }

        [TestMethod]
        public void TestRemoveOtdel2_2() //Проверка на найденный объект
        {
            Otdel otdel = new Otdel("", 2, 2, 2, "");
            otdel.AddOtdel();
            Otdel.RemoveOtdel(otdel);
            Assert.AreEqual(otdel.GetInfo().Count, 0);
        }
        //Тестирование метода RemoveOtdel()
        [TestMethod]

        public void TestRemoveOtdel3_1() //Проверка на не найденный объект
        {
            Otdel otdel = new Otdel("", 2, 2, 2, "");
            Otdel otdel1 = new Otdel("", 1, 1, 1, "");
            otdel.AddOtdel();
            var result = Assert.ThrowsException<Exception>(() => otdel1.RemoveOtdel());
            Assert.AreEqual("Такой объект не был найден в списке", result.Message);
        }
        [TestMethod]
        public void TestRemoveOtdel3_2() //Проверка на найденный объект
        {
            Otdel otdel = new Otdel("", 2, 2, 2, "");
            otdel.AddOtdel();
            otdel.RemoveOtdel();
            Assert.AreEqual(otdel.GetInfo().Count, 0);
        }
    }
}