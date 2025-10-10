using CommunityToolkit.Mvvm.DependencyInjection;
using Jony.Demo.SideMenu.ViewModels;

namespace Jony.Demo.SideMenu.ViewModels;

public class ViewModelLocator
{
    public NavigationViewModel Navigation => Ioc.Default.GetRequiredService<NavigationViewModel>();
    public MainViewModel Main => Ioc.Default.GetRequiredService<MainViewModel>();
}