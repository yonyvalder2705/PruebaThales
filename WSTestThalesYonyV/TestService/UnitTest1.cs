using CModelos;
using CNegocio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TestService
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestLista()
        {
            INEmploy employI = new NEmploy();
            List<EmployModel> lstemploy = employI.ListEmploy();
        }

        [TestMethod]
        public void TestById()
        {
            INEmploy employI = new NEmploy();
            for (int i = 0; i <=24;  i++ )
            {
                EmployModel Employ = employI.EmployById(i);
            }
            
        }


    }
}
