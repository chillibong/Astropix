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
using FFImageLoading;

namespace AstroPix
{
    class ImageResultsAdapter : RecyclerView.Adapter
    {

        Context context;
        public ImageResults _images;
        public List<string> _imageUrls;

        public override int ItemCount
        {
            get { return _images.objects.Count(); }
        }

        public ImageResultsAdapter(Context context, ImageResults images, List<string> imageUrls)
        {
            this.context = context;
            _images = images;
            _imageUrls = imageUrls;
        }



        public override long GetItemId(int position)
        {
            return position;
        }


        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            ImageResultsViewHolder vh = holder as ImageResultsViewHolder;
            vh.DateText.Text = _images.objects[position].date;

            var url = $"https://www.astrobin.com/{_imageUrls[position]}/0/rawthumb/regular/";

            ImageService.Instance.LoadUrl(url).Retry(3, 200).LoadingPlaceholder("placeholder.png", FFImageLoading.Work.ImageSource.CompiledResource).Into(vh.Image);

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