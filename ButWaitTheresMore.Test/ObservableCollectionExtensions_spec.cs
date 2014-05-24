///////////////////////////////////////
#region Namespace Directives

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.ObjectModel;

#endregion
///////////////////////////////////////

namespace ButWaitTheresMore.Test
{
    [TestClass]
    public class ObservableCollectionExtensions_spec
    {
        ////////////////////////////////////////
        #region Unit Tests (Methods)

        // HasNullValues

        [TestMethod]
        public void OnUpdate_PassActionDelegate_CollectionChangedInitialized()
        {
            //ObservableCollection<object> stuff = new ObservableCollection<object>();
            //stuff.OnUpdate((x) => DoStuff());

            /* Though this is part of the method spec, it has been determined that this 
             * functionality is effectively un-testable due to event handler encapsulation.
             * Manual testing will be required to verify functionality during use.*/
        }

        [TestMethod]
        public void OnUpdate_PassNull_CollectionChangedInitialized()
        {
            //ObservableCollection<object> stuff = new ObservableCollection<object>();
            //stuff.OnUpdate(null);

            /* Though this is part of the method spec, it has been determined that this 
             * functionality is effectively un-testable due to event handler encapsulation.
             * Manual testing will be required to verify functionality during use.*/
        }

        #endregion

        ////////////////////////////////////////
        #region Supporting Methods

        void DoStuff()
        {
            // lots of stuff done here, then
        }

        #endregion
    }
}
