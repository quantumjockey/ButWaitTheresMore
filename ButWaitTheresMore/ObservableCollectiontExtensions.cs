///////////////////////////////////////
#region Namespace Directives

using System;
using System.Collections.ObjectModel;

#endregion
///////////////////////////////////////

namespace ButWaitTheresMore
{
    public static class ObservableCollectiontExtensions
    {
        ////////////////////////////////////////
        #region Fields

        private static Action<object> _collectionChangedEvent;

        #endregion

        ////////////////////////////////////////
        #region Events

        /// <summary>
        /// Method for initializing CollectionChanged event handlers in short-hand.
        /// </summary>
        /// <param name="collection">The collection being tracked.</param>
        /// <param name="changedEvent">The action attached to the collection.</param>
        public static void OnUpdate(this ObservableCollection<object> collection, Action<object> changedEvent)
        {
            if (changedEvent != null)
            {
                _collectionChangedEvent = changedEvent;
                collection.CollectionChanged += collection_CollectionChanged;
            }
        }

        #endregion

        ////////////////////////////////////////
        #region Event Handlers

        static void collection_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            _collectionChangedEvent(sender);
        }

        #endregion
    }
}
