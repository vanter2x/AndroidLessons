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
            if (convertView == null)
            {
                //convertView = this.parent.LayoutInflater.Inflate()
            }

            return convertView;
        }
    }
}