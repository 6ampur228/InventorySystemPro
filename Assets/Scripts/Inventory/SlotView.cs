using UnityEngine;
using UnityEngine.UIElements;

namespace Systems.Inventory
{
    public class SlotView : VisualElement
    {
        private Image _icon;
        private Label _stackLabel;
        private Sprite _baseSprite;

        public SlotView()
        {
            _icon = this.CreateChild<Image>("slotIcon");
            _stackLabel = this.CreateChild("slotFrame").CreateChild<Label>("stackCount");
        }

        public void Set(Slot slot)
        {
            Item item = slot.GetItem();
            int qty = slot.QtyItem;

            _baseSprite = item.Sprite;

            _icon.image = _baseSprite != null ? _baseSprite.texture : null;

            _stackLabel.text = qty > 1 ? qty.ToString() : string.Empty;
            _stackLabel.visible = qty > 1;
        }

        public void Select() => _icon.tintColor = new Color(0.8f, 0.8f, 0.8f, 1f);

        public void Unselect() => _icon.tintColor = new Color(1f, 01f, 1f, 1f);

        public void Remove()
        {
            _icon.image = null;
            _stackLabel.visible = false;
        }
    }
}