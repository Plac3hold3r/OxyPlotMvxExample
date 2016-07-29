using Android.OS;
using Android.Runtime;
using Android.Views;
using MvvmCross.Droid.Shared.Attributes;
using XPlatformMenus.Core.ViewModels;

namespace XPlatformMenus.Droid.Fragments
{
    [MvxFragment(typeof(MainViewModel), Resource.Id.content_frame)]
    [Register("xplatformmenus.droid.fragments.SettingsFragment")]
    public class SettingsFragment : BaseFragment<SettingsViewModel>
    {
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.ShowHamburgerMenu = true;

            var view = base.OnCreateView(inflater, container, savedInstanceState);

            return view;
        }

        protected override int FragmentId
        {
            get
            {
                return Resource.Layout.fragment_settings;
            }
        }
    }
}