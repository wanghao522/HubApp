using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace Hub
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class Zoom : Page
    {
        public Zoom()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// 在此页将要在 Frame 中显示时进行调用。
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
  

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            CollectionViewSource listViewSource = new CollectionViewSource();
            listViewSource.IsSourceGrouped = true;
            listViewSource.Source = GetContactGroups();
            listViewSource.ItemsPath = new PropertyPath("Contacts");
            listViewDetail.ItemsSource = listViewSource.View;
            listViewSummary.ItemsSource = listViewSource.View.CollectionGroups;
        }

        private List<ContactGroup> GetContactGroups()
        {
            List<ContactGroup> groups = new List<ContactGroup>();
            ContactGroup groupA = new ContactGroup() { Title = "A", Contacts = new List<Contact>() { new Contact("Alan"), new Contact("Allen"), new Contact("Azar") } };
            ContactGroup groupB = new ContactGroup() { Title = "B", Contacts = new List<Contact>() { new Contact("Ben"), new Contact("Benzema") } };
            ContactGroup groupC = new ContactGroup() { Title = "C", Contacts = new List<Contact>() { new Contact("Cat"), new Contact("Canby"), new Contact("Candy") } };
            ContactGroup groupJ = new ContactGroup() { Title = "J", Contacts = new List<Contact>() { new Contact("James"), new Contact("Jim"), new Contact("Jimmy") } };
            ContactGroup groupK = new ContactGroup() { Title = "K", Contacts = new List<Contact>() { new Contact("Kevin"), new Contact("King") } };
            ContactGroup groupO = new ContactGroup() { Title = "O", Contacts = new List<Contact>() { new Contact("Oscar"), new Contact("Owen") } };
            ContactGroup groupP = new ContactGroup() { Title = "P", Contacts = new List<Contact>() { new Contact("Pendy") } };
            ContactGroup groupY = new ContactGroup() { Title = "Y", Contacts = new List<Contact>() { new Contact("Yark"), new Contact("York") } };
            ContactGroup groupZ = new ContactGroup() { Title = "Z", Contacts = new List<Contact>() { new Contact("Zend"), new Contact("Zin") } };
            groups.Add(groupA);
            groups.Add(groupB);
            groups.Add(groupC);
            groups.Add(groupJ);
            groups.Add(groupK);
            groups.Add(groupO);
            groups.Add(groupP);
            groups.Add(groupY);
            groups.Add(groupZ);
            return groups;
        }

        private void Border_Tapped(object sender, TappedRoutedEventArgs e)
        {
           // semanticZoom.IsZoomedInViewActive = false;
        }
        public class Contact
        {
            public string ContactName { get; set; }

            public Contact(string name)
            {
                ContactName = name;
            }
        }

        public class ContactGroup
        {
            public string Title { get; set; }
            public List<Contact> Contacts { get; set; }
        }
    }
}
