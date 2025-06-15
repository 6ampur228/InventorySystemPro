using UnityEngine;
using UnityEngine.UIElements;
using Cysharp.Threading.Tasks;

namespace Systems.Inventory
{
    public abstract class StorageView : MonoBehaviour
    {
        [SerializeField] protected UIDocument _document;
        [SerializeField] protected StyleSheet _styleSheet;

        protected SlotView[] _slotViews;
        protected VisualElement _root;
        protected VisualElement _container;

        public abstract UniTask InitializeViewAsync(Slot[] slots);
    }
}