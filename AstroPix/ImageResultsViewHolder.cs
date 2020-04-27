using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;

namespace AstroPix
{
    public class ImageResultsViewHolder : RecyclerView.ViewHolder
    {
        public TextView DateText { get; private set; }
        public ImageView Image { get; private set; }

        public ImageResultsViewHolder(View itemView) : base(itemView)
        {
            DateText = itemView.FindViewById<TextView>(Resource.Id.textView);
            Image = itemView.FindViewById<ImageView>(Resource.Id.imageView);
        }
    }
}