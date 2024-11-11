using OtdelLibrary;

namespace TestProject
{
    [TestClass]
    public class TestingOtdel
    {
        //������������ ������ GetQ
        [TestMethod]
        public void TestGetQ1() //�������� ������ GetQ �� ������� ��������
        {
            Otdel otdel = new Otdel("", 0, 0, 0, "");
            var result = Assert.ThrowsException<Exception>(() => otdel.GetQ());
            Assert.AreEqual("������ ������ ����:\n������� ����� > 0\n0 <= ���������� <= 2\n���������� ����������� > 0", result.Message);
        }

        [TestMethod]
        public void TestGetQ2() //�������� ������ GetQ �� ���������� ����
        {
            Otdel otdel = new Otdel("", 2, 2, 2, "");
            var result = otdel.GetQ();
            Assert.AreEqual(204, result);
        }

        [TestMethod]
        public void TestGetQ3() //�������� ������ GetQ �� ������������ ����
        {
            Otdel otdel = new Otdel("", -4, 2, 2, "");
            var result = Assert.ThrowsException<Exception>(() => otdel.GetQ());
            Assert.AreEqual("������ ������ ����:\n������� ����� > 0\n0 <= ���������� <= 2\n���������� ����������� > 0", result.Message);
        }

        [TestMethod]
        public void TestGetQ4() //�������� ������ GetQ �� ���������� ��������
        {
            Otdel otdel = new Otdel("", 1, 2, 1, "");
            var result = otdel.GetQ();
            Assert.AreEqual(102, result);
        }
        //������������ ������ GetInfo

        [TestMethod] 
        public void TestGetInfo1() //�������� ������ GetInfo �� ����� ������ ���������
        {
            Otdel otdel = new Otdel("�������", 2, 2, 2, "��������");
            otdel.AddOtdel();

            Otdel otdel1 = new Otdel("gddfg", 2, 2, 2, "fffdsfd");
            otdel1.AddOtdel();
            var result = otdel.GetInfo();
            CollectionAssert.AllItemsAreNotNull(result);
        }

        [TestMethod]
        public void TestGetInfo2() //�������� ������ GetInfo �� ����� ������ ���������� ���������
        {
            Otdel otdel = new Otdel("�������", 2, 2, 2, "��������");
            otdel.AddOtdel();

            Otdel otdel1 = new Otdel("gddfg", 2, 2, 2, "fffdsfd");
            otdel1.AddOtdel();
            var result = otdel.GetInfo();
            CollectionAssert.AllItemsAreUnique(result);
        }
        //������������ ������ AddOtdel(string name, double baseOklad, double k, int members, string nameOfCompany)

        [TestMethod]
        public void TestAddOtdel1_1() //�������� �� �������� ��������
        {
            var result = Assert.ThrowsException<Exception>(() => Otdel.AddOtdel("", -4, 2, 2, ""));
            Assert.AreEqual("������ ������ ����:\n������� ����� > 0\n0 <= ���������� <= 2\n���������� ����������� > 0", result.Message);
        }

        [TestMethod]
        public void TestAddOtdel1_2() //�������� �� ������ ��������
        {
            Otdel.AddOtdel("", 2, 2, 2, "");
            Otdel otdel = new Otdel("", 0, 0, 0, "");
            Assert.AreEqual(otdel.GetInfo().Count, 1);
        }

        [TestMethod]
        public void TestAddOtdel1_3() //�������� �� ���������� ������� � ����������� ���������� 1
        {
            Otdel.AddOtdel("", 1, 2, 1, "");
            Otdel otdel = new Otdel("", 0, 0, 0, "");
            Assert.AreEqual(otdel.GetInfo().Count, 1);
        }

        [TestMethod]
        public void TestAddOtdel1_4() //�������� �� ���������� ������� � ����������� ���������� 2
        {
            Otdel.AddOtdel("", 1, 0, 1, "");
            Otdel otdel = new Otdel("", 0, 0, 0, "");
            Assert.AreEqual(otdel.GetInfo().Count, 1);
        }
        //������������ ������ AddOtdel(Otdel otdel)
        [TestMethod]
        public void TestAddOtdel2_1() //�������� �� �������� ��������
        {
            Otdel otdel = new Otdel("", -4, 2, 2, "");
            var result = Assert.ThrowsException<Exception>(() => Otdel.AddOtdel(otdel));
            Assert.AreEqual("������ ������ ����:\n������� ����� > 0\n0 <= ���������� <= 2\n���������� ����������� > 0", result.Message);
        }

        [TestMethod]
        public void TestAddOtdel2_2() //�������� �� ������ ��������
        {
            Otdel otdel = new Otdel("", 2, 2, 2, "");
            Otdel.AddOtdel(otdel);
            Assert.AreEqual(otdel.GetInfo().Count, 1);
        }

        [TestMethod]
        public void TestAddOtdel2_3() //�������� �� ���������� ������� � ����������� ���������� 1
        {
            Otdel otdel = new Otdel("", 1, 2, 1, "");
            Otdel.AddOtdel(otdel);
            Assert.AreEqual(otdel.GetInfo().Count, 1);
        }

        [TestMethod]
        public void TestAddOtdel2_4() //�������� �� ���������� ������� � ����������� ���������� 2
        {
            Otdel otdel = new Otdel("", 1, 0, 1, "");
            Otdel.AddOtdel(otdel);
            Assert.AreEqual(otdel.GetInfo().Count, 1);
        }
        //������������ ������ AddOtdel()
        [TestMethod]
        public void TestAddOtdel3_1() //�������� �� �������� ��������
        {
            Otdel otdel = new Otdel("", -4, 2, 2, "");
            var result = Assert.ThrowsException<Exception>(() => otdel.AddOtdel());
            Assert.AreEqual("������ ������ ����:\n������� ����� > 0\n0 <= ���������� <= 2\n���������� ����������� > 0", result.Message);
        }

        [TestMethod]
        public void TestAddOtdel3_2() //�������� �� ������ ��������
        {
            Otdel otdel = new Otdel("", 2, 2, 2, "");
            otdel.AddOtdel();
            Assert.AreEqual(otdel.GetInfo().Count, 1);
        }

        [TestMethod]
        public void TestAddOtdel3_3() //�������� �� ���������� ������� � ����������� ���������� 1
        {
            Otdel otdel = new Otdel("", 1, 2, 1, "");
            otdel.AddOtdel();
            Assert.AreEqual(otdel.GetInfo().Count, 1);
        }

        [TestMethod]
        public void TestAddOtdel3_4() //�������� �� ���������� ������� � ����������� ���������� 2
        {
            Otdel otdel = new Otdel("", 1, 0, 1, "");
            otdel.AddOtdel();
            Assert.AreEqual(otdel.GetInfo().Count, 1);
        }
        //������������ ������ RemoveOtdel(string name, double baseOklad, double k, int members, string nameOfCompany)
        [TestMethod]
        public void TestRemoveOtdel1_1() //�������� �� �� ��������� ������
        {
            Otdel otdel = new Otdel("", 2, 2, 2, "");
            otdel.AddOtdel();
            var result = Assert.ThrowsException<Exception>(() => Otdel.RemoveOtdel("", 1, 1, 1, ""));
            Assert.AreEqual("����� ������ �� ��� ������ � ������", result.Message);
        }
        [TestMethod]
        public void TestRemoveOtdel1_2() //�������� �� ��������� ������
        {
            Otdel otdel = new Otdel("", 2, 2, 2, "");
            otdel.AddOtdel();
            Otdel.RemoveOtdel("", 2, 2, 2, "");
            Assert.AreEqual(otdel.GetInfo().Count, 0);
        }
        //������������ ������ RemoveOtdel(Otdel otdel)
        [TestMethod]
        public void TestRemoveOtdel2_1() //�������� �� �� ��������� ������
        {
            Otdel otdel = new Otdel("", 2, 2, 2, "");
            Otdel otdel1 = new Otdel("", 1, 1, 1, "");
            otdel.AddOtdel();
            var result = Assert.ThrowsException<Exception>(() => Otdel.RemoveOtdel(otdel1));
            Assert.AreEqual("����� ������ �� ��� ������ � ������", result.Message);
        }

        [TestMethod]
        public void TestRemoveOtdel2_2() //�������� �� ��������� ������
        {
            Otdel otdel = new Otdel("", 2, 2, 2, "");
            otdel.AddOtdel();
            Otdel.RemoveOtdel(otdel);
            Assert.AreEqual(otdel.GetInfo().Count, 0);
        }
        //������������ ������ RemoveOtdel()
        [TestMethod]

        public void TestRemoveOtdel3_1() //�������� �� �� ��������� ������
        {
            Otdel otdel = new Otdel("", 2, 2, 2, "");
            Otdel otdel1 = new Otdel("", 1, 1, 1, "");
            otdel.AddOtdel();
            var result = Assert.ThrowsException<Exception>(() => otdel1.RemoveOtdel());
            Assert.AreEqual("����� ������ �� ��� ������ � ������", result.Message);
        }
        [TestMethod]
        public void TestRemoveOtdel3_2() //�������� �� ��������� ������
        {
            Otdel otdel = new Otdel("", 2, 2, 2, "");
            otdel.AddOtdel();
            otdel.RemoveOtdel();
            Assert.AreEqual(otdel.GetInfo().Count, 0);
        }
    }
}