using AutoHitCounter.Enums;

namespace AutoHitCounter.ViewModels;

public class SplitViewModel
{
    public string Name { get; set; }
    public int NumOfHits { get; set; }
    public int PersonalBest { get; set; }
    public bool IsCurrent { get; set; }
    public SplitType Type { get; set; } = SplitType.Child;
    public string GroupId { get; set; }
    public bool IsExpanded { get; set; }
    public string Notes { get; set; }
    public bool IsParent => Type == SplitType.Parent;
}
