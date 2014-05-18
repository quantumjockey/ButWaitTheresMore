///////////////////////////////////////
#region Namespace Directives

using System.Collections.Generic;
using System.Reflection;

#endregion
///////////////////////////////////////

namespace ButWaitTheresMore
{
    public static class ObjectExtensions
    {
        ////////////////////////////////////////
        #region Null Values

        /// <summary>
        /// Tests a custom object for null property values.
        /// </summary>
        /// <param name="_dummyObject">The object to be tested.</param>
        /// <returns>Whether or not the object contains properties with null values.</returns>
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

        /// <summary>
        /// Searches a custom object for null property values.
        /// </summary>
        /// <param name="_dummyObject">The object to be searched.</param>
        /// <returns>A list of properties with null values.</returns>
        public static List<string> ListNullValues(this object _dummyObject)
        {
            List<string> _nullValues = new List<string>();
            PropertyInfo[] properties = _dummyObject.GetType().GetProperties();

            foreach (PropertyInfo property in properties)
            {
                if (property.GetValue(_dummyObject, null) == null)
                {
                    _nullValues.Add(property.Name);
                }
            }
            return _nullValues;
        }

        #endregion
    }
}
