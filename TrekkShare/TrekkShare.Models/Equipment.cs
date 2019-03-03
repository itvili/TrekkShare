
namespace TrekkShare.Models
{
    using TrekkShare.Models.Enums.RouteEnums;


    public class Equipment
    {
        public int EquipmentId { get; set; }
                
        public string Name { get; set; }

        public EquipmentLevel EquipmentLevel { get; set; }
    }
}
