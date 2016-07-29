using Android.OS;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Views;
using MvvmCross.Droid.Shared.Attributes;
using MvvmCross.Droid.Support.V7.RecyclerView;
using OxyPlot.Xamarin.Android;
using XPlatformMenus.Core.ViewModels;

namespace XPlatformMenus.Droid.Fragments
{
    [MvxFragment(typeof(MainViewModel), Resource.Id.content_frame)]
    [Register("xplatformmenus.droid.fragments.HelpFeedbackFragment")]
    public class HelpFeedbackFragment : BaseFragment<HelpAndFeedbackViewModel>
    {
        protected override int FragmentId => Resource.Layout.fragment_helpfeedback;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            ShowHamburgerMenu = true;

            var view = base.OnCreateView(inflater, container, savedInstanceState);

            var cardRecyclerView = view.FindViewById<MvxRecyclerView>(Resource.Id.myRecyclerView);
            if (cardRecyclerView != null)
            {
                cardRecyclerView.HasFixedSize = false;
                var layoutManager = new LinearLayoutManager(Activity);
                cardRecyclerView.SetLayoutManager(layoutManager);
            }

            return view;
        }

    }
}