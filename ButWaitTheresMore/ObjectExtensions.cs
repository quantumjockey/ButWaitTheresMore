///////////////////////////////////////
#region Namespace Directives

using System.Reflection;

#endregion
///////////////////////////////////////

namespace ButWaitTheresMore

{
    public static class ObjectExtensions
    {
        ////////////////////////////////////////
        #region Supporting Methods

        public static bool HasNullValues(this object _dummyObject)
        {
            bool _hasNullValues = false;
            PropertyInfo[] properties = _dummyObject.GetType().GetProperties();

            foreach (PropertyInfo property in properties)
            {
                if (property.GetValue(_dummyObject, null) == null)
                {
                    _hasNullValues = true;
                    break;
                }
            }
            return _hasNullValues;
        }

        #endregion
    }
}
