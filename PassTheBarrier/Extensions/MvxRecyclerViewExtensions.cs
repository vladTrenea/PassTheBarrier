using System;
using System.Windows.Input;
using Android.Support.V7.Widget;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Support.V7.RecyclerView;
using PassTheBarrier.Controls;

namespace PassTheBarrier.Extensions
{
    public static class MvxRecyclerViewExtensions
    {
        public static void AddOnScrollFetchItemsListener(this MvxRecyclerView recyclerView, LinearLayoutManager linearLayoutManager, Func<MvxNotifyTask> fetchItemsTaskCompletionFunc, Func<ICommand> fetchItemsCommandFunc)
        {
            var onScrollListener = new RecyclerViewOnScrollListener(linearLayoutManager);
            onScrollListener.LoadMoreEvent += (object sender, EventArgs e) =>
            {
                var fetchItemsTaskCompletion = fetchItemsTaskCompletionFunc.Invoke();
                if (fetchItemsTaskCompletion == null || !fetchItemsTaskCompletion.IsNotCompleted)
                    fetchItemsCommandFunc.Invoke().Execute(null);
            };
            recyclerView.AddOnScrollListener(onScrollListener);
        }
    }
}