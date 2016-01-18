using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _03.ProblemGenericList.Interfaces;
using _03.ProblemGenericList.Classes;

namespace GenericListTestProject
{
    [TestClass]
    public class StringTest
    {
        private static readonly String VALUE_A = "A";
        private static readonly String VALUE_B = "B";
        private static readonly String VALUE_C = "C";
        private static readonly String VALUE_D = "D";
        private static readonly String VALUE_E = "E";
        private static readonly String VALUE_F = "F";
        private IGenericList<String> _list;

        [TestMethod]
        public void TestInsert()
        {
            this._list = new GenericList<String>();

            Assert.IsTrue(this._list.IsEmpty());
            Assert.AreEqual(0, this._list.Size());

            try
            {
                this._list.Insert(-1, VALUE_A);
            }
            catch (IndexOutOfRangeException)
            {
                //expected
            }
            Assert.IsTrue(this._list.IsEmpty());
            Assert.AreEqual(0, this._list.Size());

            try
            {
                this._list.Insert(1, VALUE_A);
            }
            catch (IndexOutOfRangeException)
            {
                //expected
            }

            Assert.IsTrue(this._list.IsEmpty());
            Assert.AreEqual(0, this._list.Size());
            try
            {
                this._list.Get(-1);
            }
            catch (IndexOutOfRangeException)
            {
                //expected
            }

            Assert.IsTrue(this._list.IsEmpty());
            Assert.AreEqual(0, this._list.Size());
            try
            {
                this._list.Get(0);
            }
            catch (IndexOutOfRangeException)
            {

            }

            Assert.IsTrue(this._list.IsEmpty());
            Assert.AreEqual(0, this._list.Size());
            try
            {
                this._list.Get(1);
            }
            catch (IndexOutOfRangeException)
            {
                //expected
            }

            this._list.Insert(0, VALUE_A);
            Assert.IsFalse(this._list.IsEmpty());
            Assert.AreEqual(1, this._list.Size());
            Assert.AreEqual(this._list.Get(0), VALUE_A);

            this._list.Insert(1, VALUE_B);
            Assert.IsFalse(this._list.IsEmpty());
            Assert.AreEqual(2, this._list.Size());
            Assert.AreEqual(this._list.Get(0), VALUE_A);
            Assert.AreEqual(this._list.Get(1), VALUE_B);

            this._list.Insert(2, VALUE_C);
            Assert.IsFalse(this._list.IsEmpty());
            Assert.AreEqual(3, this._list.Size());
            Assert.AreEqual(this._list.Get(0), VALUE_A);
            Assert.AreEqual(this._list.Get(1), VALUE_B);
            Assert.AreEqual(this._list.Get(2), VALUE_C);

            this._list.Insert(0, VALUE_D);
            Assert.IsFalse(this._list.IsEmpty());
            Assert.AreEqual(4, this._list.Size());
            Assert.AreEqual(this._list.Get(0), VALUE_D);
            Assert.AreEqual(this._list.Get(1), VALUE_A);
            Assert.AreEqual(this._list.Get(2), VALUE_B);
            Assert.AreEqual(this._list.Get(3), VALUE_C);

            this._list.Insert(2, VALUE_E);
            Assert.IsFalse(this._list.IsEmpty());
            Assert.AreEqual(5, this._list.Size());
            Assert.AreEqual(this._list.Get(0), VALUE_D);
            Assert.AreEqual(this._list.Get(1), VALUE_A);
            Assert.AreEqual(this._list.Get(2), VALUE_E);
            Assert.AreEqual(this._list.Get(3), VALUE_B);
            Assert.AreEqual(this._list.Get(4), VALUE_C);

            try
            {
                this._list.Insert(-1, VALUE_A);
            }
            catch (IndexOutOfRangeException)
            {
                //expected
            }
            Assert.IsFalse(this._list.IsEmpty());
            Assert.AreEqual(5, this._list.Size());
            Assert.AreEqual(this._list.Get(0), VALUE_D);
            Assert.AreEqual(this._list.Get(1), VALUE_A);
            Assert.AreEqual(this._list.Get(2), VALUE_E);
            Assert.AreEqual(this._list.Get(3), VALUE_B);
            Assert.AreEqual(this._list.Get(4), VALUE_C);

            try
            {
                this._list.Insert(6, VALUE_A);
            }
            catch (IndexOutOfRangeException)
            {
                //expected
            }
            Assert.IsFalse(this._list.IsEmpty());
            Assert.AreEqual(5, this._list.Size());
            Assert.AreEqual(this._list.Get(0), VALUE_D);
            Assert.AreEqual(this._list.Get(1), VALUE_A);
            Assert.AreEqual(this._list.Get(2), VALUE_E);
            Assert.AreEqual(this._list.Get(3), VALUE_B);
            Assert.AreEqual(this._list.Get(4), VALUE_C);
        }

        [TestMethod]
        public void TestAdd()
        {
            this._list = new GenericList<String>();

            this._list.Add(VALUE_A);
            Assert.IsFalse(this._list.IsEmpty());
            Assert.AreEqual(1, this._list.Size());
            Assert.AreEqual(this._list.Get(0), VALUE_A);

            this._list.Add(VALUE_B);
            Assert.IsFalse(this._list.IsEmpty());
            Assert.AreEqual(2, this._list.Size());
            Assert.AreEqual(this._list.Get(0), VALUE_A);
            Assert.AreEqual(this._list.Get(1), VALUE_B);

            this._list.Add(VALUE_C);
            Assert.IsFalse(this._list.IsEmpty());
            Assert.AreEqual(3, this._list.Size());
            Assert.AreEqual(this._list.Get(0), VALUE_A);
            Assert.AreEqual(this._list.Get(1), VALUE_B);
            Assert.AreEqual(this._list.Get(2), VALUE_C);
        }

        [TestMethod]
        public void TestListGrowsBeyondInitialSize()
        {
            this._list = new GenericList<String>();

            for (int i = 0; i < 20; i++)
            {
                this._list.Add(VALUE_A);
            }

            for (int i = 0; i < 20; i++)
            {
                Assert.IsFalse(this._list.IsEmpty());
                Assert.AreEqual(20, this._list.Size());
                Assert.AreEqual(this._list.Get(i), VALUE_A);
            }
        }

        [TestMethod]
        public void TestDeleteByIndex()
        {
            this._list = new GenericList<String>();

            Assert.IsTrue(this._list.IsEmpty());
            Assert.AreEqual(0, this._list.Size());
            try
            {
                this._list.Delete(-1);
            }
            catch (IndexOutOfRangeException)
            {
                //expected
            }

            Assert.IsTrue(this._list.IsEmpty());
            Assert.AreEqual(0, this._list.Size());
            try
            {
                this._list.Delete(0);
            }
            catch (IndexOutOfRangeException)
            {
                //expected
            }

            Assert.IsTrue(this._list.IsEmpty());
            Assert.AreEqual(0, this._list.Size());
            try
            {
                this._list.Delete(1);
            }
            catch (IndexOutOfRangeException)
            {
                //expected
            }

            this._list.Add(VALUE_A);
            this._list.Add(VALUE_B);
            this._list.Add(VALUE_C);
            this._list.Add(VALUE_D);
            this._list.Add(VALUE_E);
            this._list.Add(VALUE_F);
            Assert.IsFalse(this._list.IsEmpty());
            Assert.AreEqual(6, this._list.Size());
            Assert.AreEqual(this._list.Get(0), VALUE_A);
            Assert.AreEqual(this._list.Get(1), VALUE_B);
            Assert.AreEqual(this._list.Get(2), VALUE_C);
            Assert.AreEqual(this._list.Get(3), VALUE_D);
            Assert.AreEqual(this._list.Get(4), VALUE_E);
            Assert.AreEqual(this._list.Get(5), VALUE_F);

            Assert.AreEqual(this._list.Delete(5), VALUE_F);
            Assert.IsFalse(this._list.IsEmpty());
            Assert.AreEqual(5, this._list.Size());
            Assert.AreEqual(this._list.Get(0), VALUE_A);
            Assert.AreEqual(this._list.Get(1), VALUE_B);
            Assert.AreEqual(this._list.Get(2), VALUE_C);
            Assert.AreEqual(this._list.Get(3), VALUE_D);
            Assert.AreEqual(this._list.Get(4), VALUE_E);

            Assert.AreEqual(VALUE_A, this._list.Delete(0));
            Assert.IsFalse(this._list.IsEmpty());
            Assert.AreEqual(4, this._list.Size());
            Assert.AreEqual(this._list.Get(0), VALUE_B);
            Assert.AreEqual(this._list.Get(1), VALUE_C);
            Assert.AreEqual(this._list.Get(2), VALUE_D);
            Assert.AreEqual(this._list.Get(3), VALUE_E);

            Assert.AreEqual(VALUE_D, this._list.Delete(2));
            Assert.IsFalse(this._list.IsEmpty());
            Assert.AreEqual(3, this._list.Size());
            Assert.AreEqual(this._list.Get(0), VALUE_B);
            Assert.AreEqual(this._list.Get(1), VALUE_C);
            Assert.AreEqual(this._list.Get(2), VALUE_E);

            Assert.AreEqual(VALUE_C, this._list.Delete(1));
            Assert.IsFalse(this._list.IsEmpty());
            Assert.AreEqual(2, this._list.Size());
            Assert.AreEqual(this._list.Get(0), VALUE_B);
            Assert.AreEqual(this._list.Get(1), VALUE_E);

            Assert.AreEqual(VALUE_B, this._list.Delete(0));
            Assert.IsFalse(this._list.IsEmpty());
            Assert.AreEqual(1, this._list.Size());
            Assert.AreEqual(this._list.Get(0), VALUE_E);

            Assert.AreEqual(VALUE_E, this._list.Delete(0));
            Assert.IsTrue(this._list.IsEmpty());
            Assert.AreEqual(0, this._list.Size());
        }

        [TestMethod]
        public void TestDeleteByValue()
        {
            this._list = new GenericList<String>();

            Assert.IsFalse(this._list.Delete(VALUE_A));
            Assert.IsTrue(this._list.IsEmpty());
            Assert.AreEqual(0, this._list.Size());

            this._list.Add(VALUE_A);
            this._list.Add(VALUE_B);
            this._list.Add(VALUE_A);
            this._list.Add(VALUE_C);

            Assert.IsFalse(this._list.Delete(VALUE_F));
            Assert.IsFalse(this._list.IsEmpty());
            Assert.AreEqual(4, this._list.Size());
            Assert.AreEqual(VALUE_A, this._list.Get(0));
            Assert.AreEqual(VALUE_B, this._list.Get(1));
            Assert.AreEqual(VALUE_A, this._list.Get(2));
            Assert.AreEqual(VALUE_C, this._list.Get(3));

            Assert.IsTrue(this._list.Delete(VALUE_A));
            Assert.IsFalse(this._list.IsEmpty());
            Assert.AreEqual(3, this._list.Size());
            Assert.AreEqual(VALUE_B, this._list.Get(0));
            Assert.AreEqual(VALUE_A, this._list.Get(1));
            Assert.AreEqual(VALUE_C, this._list.Get(2));

            Assert.IsTrue(this._list.Delete(VALUE_C));
            Assert.IsFalse(this._list.IsEmpty());
            Assert.AreEqual(2, this._list.Size());
            Assert.AreEqual(VALUE_B, this._list.Get(0));
            Assert.AreEqual(VALUE_A, this._list.Get(1));

            Assert.IsTrue(this._list.Delete(VALUE_B));
            Assert.IsFalse(this._list.IsEmpty());
            Assert.AreEqual(1, this._list.Size());
            Assert.AreEqual(VALUE_A, this._list.Get(0));

            Assert.IsTrue(this._list.Delete(VALUE_A));
            Assert.IsTrue(this._list.IsEmpty());
            Assert.AreEqual(0, this._list.Size());

            Assert.IsFalse(this._list.Delete(VALUE_A));
            Assert.IsTrue(this._list.IsEmpty());
            Assert.AreEqual(0, this._list.Size());
        }

        [TestMethod]
        public void TestSet()
        {
            this._list = new GenericList<String>();

            try
            {
                this._list.Set(-1, VALUE_A);
            }
            catch (IndexOutOfRangeException)
            {
                //expected
            }
            Assert.IsTrue(this._list.IsEmpty());
            Assert.AreEqual(0, this._list.Size());

            try
            {
                this._list.Set(0, VALUE_A);
            }
            catch (IndexOutOfRangeException)
            {
                //expected
            }
            Assert.IsTrue(this._list.IsEmpty());
            Assert.AreEqual(0, this._list.Size());

            try
            {
                this._list.Set(1, VALUE_A);
            }
            catch (IndexOutOfRangeException)
            {
                //expected
            }
            Assert.IsTrue(this._list.IsEmpty());
            Assert.AreEqual(0, this._list.Size());

            this._list.Add(VALUE_A);
            try
            {
                this._list.Set(-1, VALUE_A);
            }
            catch (IndexOutOfRangeException)
            {
                //expected
            }
            Assert.IsFalse(this._list.IsEmpty());
            Assert.AreEqual(1, this._list.Size());
            Assert.AreEqual(VALUE_A, this._list.Get(0));

            try
            {
                this._list.Set(1, VALUE_A);
            }
            catch (IndexOutOfRangeException)
            {
                //expected
            }
            Assert.IsFalse(this._list.IsEmpty());
            Assert.AreEqual(1, this._list.Size());
            Assert.AreEqual(VALUE_A, this._list.Get(0));

            this._list.Add(VALUE_A);
            this._list.Add(VALUE_B);
            this._list.Add(VALUE_C);
            this._list.Add(VALUE_B);

            Assert.AreEqual(VALUE_A, this._list.Set(0, VALUE_F));
            Assert.IsFalse(this._list.IsEmpty());
            Assert.AreEqual(5, this._list.Size());
            Assert.AreEqual(VALUE_F, this._list.Get(0));
            Assert.AreEqual(VALUE_A, this._list.Get(1));
            Assert.AreEqual(VALUE_B, this._list.Get(2));
            Assert.AreEqual(VALUE_C, this._list.Get(3));
            Assert.AreEqual(VALUE_B, this._list.Get(4));

            Assert.AreEqual(VALUE_B, this._list.Set(2, VALUE_F));
            Assert.IsFalse(this._list.IsEmpty());
            Assert.AreEqual(5, this._list.Size());
            Assert.AreEqual(VALUE_F, this._list.Get(0));
            Assert.AreEqual(VALUE_A, this._list.Get(1));
            Assert.AreEqual(VALUE_F, this._list.Get(2));
            Assert.AreEqual(VALUE_C, this._list.Get(3));
            Assert.AreEqual(VALUE_B, this._list.Get(4));

            Assert.AreEqual(VALUE_B, this._list.Set(4, VALUE_F));
            Assert.IsFalse(this._list.IsEmpty());
            Assert.AreEqual(5, this._list.Size());
            Assert.AreEqual(VALUE_F, this._list.Get(0));
            Assert.AreEqual(VALUE_A, this._list.Get(1));
            Assert.AreEqual(VALUE_F, this._list.Get(2));
            Assert.AreEqual(VALUE_C, this._list.Get(3));
            Assert.AreEqual(VALUE_F, this._list.Get(4));

            Assert.AreEqual(VALUE_A, this._list.Set(1, VALUE_F));
            Assert.IsFalse(this._list.IsEmpty());
            Assert.AreEqual(5, this._list.Size());
            Assert.AreEqual(VALUE_F, this._list.Get(0));
            Assert.AreEqual(VALUE_F, this._list.Get(1));
            Assert.AreEqual(VALUE_F, this._list.Get(2));
            Assert.AreEqual(VALUE_C, this._list.Get(3));
            Assert.AreEqual(VALUE_F, this._list.Get(4));

            Assert.AreEqual(VALUE_C, this._list.Set(3, VALUE_F));
            Assert.IsFalse(this._list.IsEmpty());
            Assert.AreEqual(5, this._list.Size());
            Assert.AreEqual(VALUE_F, this._list.Get(0));
            Assert.AreEqual(VALUE_F, this._list.Get(1));
            Assert.AreEqual(VALUE_F, this._list.Get(2));
            Assert.AreEqual(VALUE_F, this._list.Get(3));
            Assert.AreEqual(VALUE_F, this._list.Get(4));
        }

        [TestMethod]
        public void TestIndexOfAndCOntains()
        {
            this._list = new GenericList<String>();

            Assert.IsFalse(this._list.Contains(VALUE_A));
            Assert.AreEqual(-1, this._list.IndexOf(VALUE_A));

            this._list.Add(VALUE_A);
            Assert.IsTrue(this._list.Contains(VALUE_A));
            Assert.AreEqual(0, this._list.IndexOf(VALUE_A));
            Assert.IsFalse(this._list.Contains(VALUE_B));
            Assert.AreEqual(-1, this._list.IndexOf(VALUE_B));
            Assert.IsFalse(this._list.Contains(VALUE_C));
            Assert.AreEqual(-1, this._list.IndexOf(VALUE_C));

            this._list.Add(VALUE_B);
            Assert.IsTrue(this._list.Contains(VALUE_A));
            Assert.AreEqual(0, this._list.IndexOf(VALUE_A));
            Assert.IsTrue(this._list.Contains(VALUE_B));
            Assert.AreEqual(1, this._list.IndexOf(VALUE_B));
            Assert.IsFalse(this._list.Contains(VALUE_C));
            Assert.AreEqual(-1, this._list.IndexOf(VALUE_C));

            this._list.Insert(0, VALUE_C);
            Assert.IsTrue(this._list.Contains(VALUE_C));
            Assert.AreEqual(0, this._list.IndexOf(VALUE_C));
            Assert.IsTrue(this._list.Contains(VALUE_A));
            Assert.AreEqual(1, this._list.IndexOf(VALUE_A));
            Assert.IsTrue(this._list.Contains(VALUE_B));
            Assert.AreEqual(2, this._list.IndexOf(VALUE_B));

            this._list.Clear();
            Assert.IsTrue(this._list.IsEmpty());
            Assert.AreEqual(0, this._list.Size());
            Assert.IsFalse(this._list.Contains(VALUE_A));
            Assert.AreEqual(-1, this._list.IndexOf(VALUE_A));
            Assert.IsFalse(this._list.Contains(VALUE_B));
            Assert.AreEqual(-1, this._list.IndexOf(VALUE_B));
            Assert.IsFalse(this._list.Contains(VALUE_C));
            Assert.AreEqual(-1, this._list.IndexOf(VALUE_C));
        }
    }
}
