using Microsoft.VisualStudio.TestTools.UnitTesting;
using WarstwaUslug;
using System;

namespace TestWarstwyUslug
{
    [TestClass]
    public class UnitTest1
    {
        [TestInitialize]
        public void TestInitialize()
        {
            RepozytoriumDanych.DataContex = new BazaDanychDataContext();
        }

        [TestMethod()]
        public void GetAllWyporzyczeniaTest()
        {

            //TODO zrobic testy
        }


   
    }
}
