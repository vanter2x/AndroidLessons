using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using App4.Adapters;
using System.Collections.Generic;
using App4.Models;

namespace App4
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private List<Contact> contacts;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            Button button = FindViewById<Button>(Resource.Id.addButton);
            //button.Click += delegate { };

            Initialize();

            var contactListView = FindViewById<ListView>(Resource.Id.contactListView);

            contactListView.Adapter = new ContactListAdapter(contacts, this);
        }

        private void Initialize()
        {
            contacts = new List<Contact>();

            for (int i = 1; i <= 20; i++)
            {
                contacts.Add(new Contact("My Contact" + i, "contact_email@gmail.com", "555 555 555"));
            }
        }
    }
}