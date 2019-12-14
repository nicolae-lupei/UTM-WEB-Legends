using System;

namespace UTM.DLL.Models.HostelModels
{
    public class RoomInventory : BaseModel
    {
        public virtual InventoryItem InventoryItem { get; set; }
        public virtual Guid InventoryItemId { get; set; }

        public virtual string Value { get; set; }
    }
}