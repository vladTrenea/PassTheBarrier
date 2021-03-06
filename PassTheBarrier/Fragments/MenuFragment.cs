using System;
using System.Linq;
using System.Threading.Tasks;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Views;
using MvvmCross.Binding.Droid.BindingContext;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Support.V4;
using MvvmCross.Droid.Views.Attributes;
using PassTheBarier.Core.Messenger;
using PassTheBarier.Core.ViewModels;
using PassTheBarrier.Activities;

namespace PassTheBarrier.Fragments
{
    [MvxFragmentPresentation(typeof(MainViewModel), Resource.Id.navigation_frame)]
    [Register("passTheBarrier.droid.fragments.MenuFragment")]
    public class MenuFragment : MvxFragment<MenuViewModel>, NavigationView.IOnNavigationItemSelectedListener
    {
        private NavigationView _navigationView;
        private IMenuItem _previousMenuItem;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var ignore = base.OnCreateView(inflater, container, savedInstanceState);

            var view = this.BindingInflate(Resource.Layout.MenuView, null);

            _navigationView = view.FindViewById<NavigationView>(Resource.Id.navigation_view);
            _navigationView.SetNavigationItemSelectedListener(this);

			var homeMenuItem = _navigationView.Menu.FindItem(Resource.Id.nav_home);
	        homeMenuItem.SetCheckable(true);
	        homeMenuItem.SetChecked(true);

	        _previousMenuItem = homeMenuItem;

	        ViewModel.SetSubscription(OnNavigationChange);
            return view;
        }

		public bool OnNavigationItemSelected(IMenuItem menuItem)
        {
			MarkSelectedMenuItem(menuItem);
            Navigate(menuItem.ItemId);

            return true;
        }

	    public void MarkSelectedMenuItem(IMenuItem menuItem)
	    {
		    if (_previousMenuItem != null)
		    {
			    _previousMenuItem.SetChecked(false);
		    }

		    menuItem.SetCheckable(true);
		    menuItem.SetChecked(true);

		    _previousMenuItem = menuItem;
		}

	    private void OnNavigationChange(NavigationMessage message)
	    {
		    var currentFragment = (MvxFragment)this.FragmentManager.Fragments.LastOrDefault();
		    Navigate(currentFragment.ViewModel);
	    }

        private async Task Navigate(int itemId)
        {
            ((MainActivity)Activity).DrawerLayout.CloseDrawers();
            await Task.Delay(TimeSpan.FromMilliseconds(250));

            switch (itemId)
            {
                case Resource.Id.nav_home:
                    ViewModel.ShowHomeCommand.Execute(null);
                    break;
                case Resource.Id.nav_barrier:
                    ViewModel.ShowBarrierCommand.Execute(null);
                    break;
                case Resource.Id.nav_addressBook:
                    ViewModel.ShowAddressBookCommand.Execute(null);
                    break;
	            case Resource.Id.nav_settings:
		            ViewModel.ShowSettingsCommand.Execute(null);
		            break;
				case Resource.Id.nav_about:
                    ViewModel.ShowAboutCommand.Execute(null);
                    break;
            }
        }

	    private void Navigate(IMvxViewModel viewModel)
	    {
		    var type = viewModel.GetType();

		    if (type == typeof(HomeViewModel))
		    {
			    var homeMenuItem = _navigationView.Menu.FindItem(Resource.Id.nav_home);
			    homeMenuItem.SetCheckable(true);
			    homeMenuItem.SetChecked(true);
			}
		    else if (type == typeof(AddressBookViewModel))
		    {
			    var addressBookItem = _navigationView.Menu.FindItem(Resource.Id.nav_addressBook);
			    addressBookItem.SetCheckable(true);
			    addressBookItem.SetChecked(true);
			}
	    }
    }
}