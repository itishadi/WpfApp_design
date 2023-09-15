namespace ServiceApplication.MVVM.Models;

public class DeviceItem
{
    public DeviceItem() { }
    
    public string? DeviceId { get; set; }
    public string? DeviceType { get; set; }
    public string? Placement { get; set; }
    public bool IsActive { get; set; } = false;
    public string? Icon => SetIcon();
    

    private string SetIcon()
    {
        var icon = "\uf2db";
        switch (DeviceType?.ToLower())
        {
            case "light":
                icon = "\uf0eb";
                break;

            case "lamp":
                icon = "\ue004";
                break;

            default:
                icon = "\uf2db";
                break;

        }

        //return (DeviceType?.ToLower()) switch
        //{
        //    "light" => "\uf0eb",
        //    "lamp" => "\ue004",
        //    "fan" => "\uf2db"
        //};
        return icon;
    }
}
