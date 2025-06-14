using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UIElements;

namespace Systems.Inventory
{
    public abstract class StorageView : MonoBehaviour
    {
        [SerializeField] protected UIDocument _document;
        [SerializeField] protected StyleSheet _styleSheet;

        protected SlotView[] _slotViews;
        protected VisualElement _root;
        protected VisualElement _container;

        public abstract IEnumerator InitializeView(Slot[] slots);
    }
}