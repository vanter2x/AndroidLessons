using System;
using Android.Views;
using Android.Widget;
using App4.Models;
using Java.Lang;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using Android.App;

namespace App4.Adapters
{
    public class ContactListAdapter : BaseAdapter<Contact>
    {
        private List<Contact> contacts;
        private Activity parent;

        public ContactListAdapter(List<Contact> contacts, Activity parent)
        {
            this.contacts = contacts;
            this.parent = parent;
        }

        public override Contact this[int position] => contacts[position];

        public override int Count => contacts.Count;

        public override long GetItemId(int position) => position;

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            ContactViewHolder viewHolder = null;

            if (convertView == null)
            {
                convertView = this.parent.LayoutInflater.Inflate(Resource.Layout.view_contact, null);

                viewHolder = new ContactViewHolder();
                viewHolder.NameTextView = convertView.FindViewById<TextView>(Resource.Id.nameTextView);
                viewHolder.PhoneNumberTextView = convertView.FindViewById<TextView>(Resource.Id.phoneNumberTextView);
                viewHolder.EmailImageView = convertView.FindViewById<ImageView>(Resource.Id.emailImageView);
                viewHolder.PhoneImageView = convertView.FindViewById<ImageView>(Resource.Id.phoneImageView);

                convertView.Tag = viewHolder;
            }

            if (viewHolder == null)
                viewHolder = convertView.Tag as ContactViewHolder;

            var contact = contacts[position];

            viewHolder.NameTextView.Text = contact.Name;
            viewHolder.PhoneNumberTextView.Text = contact.PhoneNumber;

            return convertView;
        }
    }
}