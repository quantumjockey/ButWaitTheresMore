///////////////////////////////////////
#region Namespace Directives

using ButWaitTheresMore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

#endregion
///////////////////////////////////////

namespace ButWaitTheresMore.Test
{
    [TestClass]
    public class ObjectExtensions_spec
    {
        ////////////////////////////////////////
        #region Unit Tests (Methods)

        // HasNullValues

        [TestMethod]
        public void HasNullValues_PropertiesAreNull_True()
        {
            Schtuff ToDo = new Schtuff();
            Assert.IsTrue(ToDo.HasNullValues());
        }

        [TestMethod]
        public void HasNullValues_InstantiablePropertiesAreInstantiated_False()
        {
            Schtuff ToDo = new Schtuff();
            ToDo.InTheAttic = new Things();
            ToDo.InThePantry = new Things();
            Assert.IsFalse(ToDo.HasNullValues());
        }

        // ListNullValues

        [TestMethod]
        public void ListNullValues_PropertiesAreNull_ValueNames()
        {
            Schtuff ToDo = new Schtuff();
            Assert.AreNotEqual(0, ToDo.ListNullValues().Count);
        }

        [TestMethod]
        public void HasNullValues_InstantiablePropertiesAreInstantiated_EmptyList()
        {
            Schtuff ToDo = new Schtuff();
            ToDo.InTheAttic = new Things();
            ToDo.InThePantry = new Things();
            Assert.AreEqual(0, ToDo.ListNullValues().Count);
        }

        #endregion

        ////////////////////////////////////////
        #region Child Classes (Used in Testing)

        class Schtuff
        {
            public Things InTheAttic { get; set; }
            public Things InThePantry { get; set; }
        }

        class Things
        {
            string Instrument { get; set; }
            double Trouble { get; set; }
        }

        #endregion
    }
}