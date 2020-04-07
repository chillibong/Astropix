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
using AstroPix.Shared.Models;

namespace AstroPix
{
    class ImageResultsAdapter : RecyclerView.Adapter
    {

        Context context;
        public ImageResults _images;

        public override int ItemCount
        {
            get { return _images.objects.Count(); }
        }

        public ImageResultsAdapter(Context context, ImageResults images)
        {
            this.context = context;
            _images = images; 
        }



        public override long GetItemId(int position)
        {
            return position;
        }


        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            ImageResultsViewHolder vh = holder as ImageResultsViewHolder;
            vh.DateText.Text = _images.objects[position].date;

            return;
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            View itemView = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.ImageResultView, parent, false);
            ImageResultsViewHolder vh = new ImageResultsViewHolder(itemView);
            return vh;
        }
    }
}