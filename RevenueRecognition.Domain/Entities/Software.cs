using RevenueRecognition.Domain.ValueObjects.SoftwareValueObjects;

namespace RevenueRecognition.Domain.Entities;

public class Software
{
    public SoftwareId SoftwareId { get; set; }
    public SoftwareName Name { get; set; }
    public SoftwareDescription Description { get; set; }
    public SoftwareVersion Version { get; set; }
    public SoftwareCategory Category { get; set; }
}