﻿using Android.OS;
using Android.Runtime;
using Android.Views;
using MvvmCross.Droid.Views.Attributes;
using PassTheBarier.Core.ViewModels;

namespace PassTheBarrier.Fragments
{
	[MvxFragmentPresentation(typeof(MainViewModel), Resource.Id.content_frame, true)]
	[Register("passTheBarrier.droid.fragments.SettingsFragment")]
	public class SettingsFragment : BaseFragment<SettingsViewModel>
	{
		protected override int FragmentId => Resource.Layout.SettingsView;

		public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			var view = base.OnCreateView(inflater, container, savedInstanceState);

			ParentActivity.SupportActionBar.Title = GetString(Resource.String.settings);

			return view;
		}
	}
}