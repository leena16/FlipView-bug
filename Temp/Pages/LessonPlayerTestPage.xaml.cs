using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Temp.Helper;
using Temp.Models;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Temp.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class LessonPlayerTestPage : Page
    {
        private Item clickedSectionItem;
        private Item loadedItem;
        private ObservableCollection<Object> SectionsItems = new ObservableCollection<Object>();
        private ObservableCollection<Section> SectionsItemsList = new ObservableCollection<Section>();
        private int _hackyfix = 0;
        private int currentIndex = 1;

        public LessonPlayerTestPage()
        {
            this.InitializeComponent();
            SectionsItemsList.Add(new Section() { id = 1234, title = "Section 1" });
            SectionsItemsList[0].items.Add(new Item() { id = 1334, title = "Section 1 Item 1", item_type = "text", item_text = "<style> * { font-family: \"Times New Roman\", Times, serif !important; line-height: 150% !important; font-size: 18px !important; } p { font-size: 18px !important; } </style><div><div><ol></ol><ul><li>Learn about various types of farming and developments in agriculture in two different regions.</li></ul><ol></ol></div><div><br/></div></div>" });
            SectionsItemsList[0].items.Add(new Item() { id = 1434, title = "Section 1 Item 2", item_type = "text", item_text = "<style> * { font-family: \"Times New Roman\", Times, serif !important; line-height: 150% !important; font-size: 18px !important; } p { font-size: 18px !important; } </style><div><div><ul><li>introduction to types of farming</li><li>major food, fiber, and beverage &#10;crops</li><li>agricultural development with two case studies - one from India &#10;and the other from a more industrialised or economically developed &#10;country such as the US, Australia, or the Netherlands</li></ul></div><div><br/></div></div>" });
            SectionsItemsList.Add(new Section() { id = 1444, title = "Section 2" });
            SectionsItemsList[1].items.Add(new Item() { id = 1534, title = "Section 2 Item 1", item_type = "text", item_text = "<style> * { font-family: \"Times New Roman\", Times, serif !important; line-height: 150% !important; font-size: 18px !important; } p { font-size: 18px !important; } </style><div><ul><li>Agriculture is a primary industry that employs about 50% of the &#10;world's population, and it includes growing crops, fruits, vegetables, &#10;flowers, and rearing livestock.</li><li>Favourable climate and topography of soil are important for agriculture.</li><li>We can broadly classify all farming into subsistence farming and commercial farming.</li></ul><p><br/></p></div>" });
            SectionsItemsList.Add(new Section() { id = 1634, title = "Section 3" });
            SectionsItemsList[2].items.Add(new Item() { id = 1536, title = "Section 3 Item 1", item_type = "text", item_text = "<style> * { font-family: \"Times New Roman\", Times, serif !important; line-height: 150% !important; font-size: 18px !important; } p { font-size: 18px !important; } </style><div><div class=\"sub-item-base-container ng-scope\">&#10;  <div class=\"row show-rich-text-container\">&#10;  <div class=\"col-lg-12\">&#10;    <div class=\"rich-text ng-binding\"><h4>Learnapt Lesson</h4><h5>Writer</h5><div>Krishna Mirani</div></div>&#10;  </div>&#10;</div>&#10;&#10;</div></div>" });
            sectionsListView.ItemsSource = SectionsItemsList;

            SectionsItems.Add(new Section() { id = 1234, title = "Section 1" });
            SectionsItems.Add(new Item() { id = 1334, title = "Section 1 Item 1", item_type = "text", item_text = "<style> * { font-family: \"Times New Roman\", Times, serif !important; line-height: 150% !important; font-size: 18px !important; } p { font-size: 18px !important; } </style><div><div><ol></ol><ul><li>Learn about various types of farming and developments in agriculture in two different regions.</li></ul><ol></ol></div><div><br/></div></div>" });
            SectionsItems.Add(new Item() { id = 1434, title = "Section 1 Item 2", item_type = "text", item_text = "<style> * { font-family: \"Times New Roman\", Times, serif !important; line-height: 150% !important; font-size: 18px !important; } p { font-size: 18px !important; } </style><div><div><ul><li>introduction to types of farming</li><li>major food, fiber, and beverage &#10;crops</li><li>agricultural development with two case studies - one from India &#10;and the other from a more industrialised or economically developed &#10;country such as the US, Australia, or the Netherlands</li></ul></div><div><br/></div></div>" });
            SectionsItems.Add(new Section() { id = 1444, title = "Section 2" });
            SectionsItems.Add(new Item() { id = 1534, title = "Section 2 Item 1", item_type = "text", item_text = "<style> * { font-family: \"Times New Roman\", Times, serif !important; line-height: 150% !important; font-size: 18px !important; } p { font-size: 18px !important; } </style><div><ul><li>Agriculture is a primary industry that employs about 50% of the &#10;world's population, and it includes growing crops, fruits, vegetables, &#10;flowers, and rearing livestock.</li><li>Favourable climate and topography of soil are important for agriculture.</li><li>We can broadly classify all farming into subsistence farming and commercial farming.</li></ul><p><br/></p></div>" });
            SectionsItems.Add(new Section() { id = 1634, title = "Section 3" });
            SectionsItems.Add(new Item() { id = 1536, title = "Section 3 Item 1", item_type = "text", item_text = "<style> * { font-family: \"Times New Roman\", Times, serif !important; line-height: 150% !important; font-size: 18px !important; } p { font-size: 18px !important; } </style><div><div class=\"sub-item-base-container ng-scope\">&#10;  <div class=\"row show-rich-text-container\">&#10;  <div class=\"col-lg-12\">&#10;    <div class=\"rich-text ng-binding\"><h4>Learnapt Lesson</h4><h5>Writer</h5><div>Krishna Mirani</div></div>&#10;  </div>&#10;</div>&#10;&#10;</div></div>" });
            FlipViewOfSectionsItems.ItemsSource = SectionsItems;
            //clickedSectionItem = (Item)SectionsItems[2];
            //navigateToClickedFlipViewItem(clickedSectionItem);
        }

        private void navigateToClickedFlipViewItem(Item clickedSectionItem)
        {
            for (int i = 0; i < SectionsItems.Count; i++)
            {
                if(clickedSectionItem.GetType().Name == "Item" && SectionsItems[i].GetType().Name == "Item")
                {
                    if ( ((Item)SectionsItems[i]).id == clickedSectionItem.id)
                    {
                        _hackyfix = 0;
                        currentIndex = i;
                        FlipViewOfSectionsItems.SelectedItem = null;
                        FlipViewOfSectionsItems.SelectedItem = SectionsItems[i];
                        return;
                    }
                }
                else if (clickedSectionItem.GetType().FullName == "Section" && SectionsItems[i].GetType().FullName == "Section")
                {

                }
            }
        }

        private async void FlipViewOfSectionsItems_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (((FlipView)sender).SelectedItem == null)
                return;

            // http://stackoverflow.com/a/26611106/5303344
            //HACKYFIX: Daniel note:  Very hacky workaround for an api issue
            //Microsoft's api for getting item controls for the flipview item fail on the very first media selection change for some reason.  Basically we ignore the
            //first media selection changed event but spawn a thread to redo the ignored selection changed, hopefully allowing time for whatever is going on
            //with the api to get things sorted out so we can call the "ContainerFromItem" function and actually get the control we need
            if (_hackyfix == 0 || _hackyfix == 1)
            {
                _hackyfix++;

                await Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
                 {
                     FlipViewOfSectionsItems_SelectionChanged(sender, e);
                 });
                return;
            }

            if (((FlipView)sender).SelectedItem.GetType().Name == "Item")
            {
                loadedItem = (Item)((FlipView)sender).SelectedItem;
                FlipView flipView = (FlipView)sender;
                FlipViewItem flipViewItemContainer = (FlipViewItem)flipView.ContainerFromItem(loadedItem);

                if (flipViewItemContainer == null)
                    return;

                if (loadedItem.item_type == "text")
                {
                    WebView webview = VisualTreeHelpers.FindChild<WebView>(flipViewItemContainer, "ItemWebView");
                    webview.NavigateToString(loadedItem.item_text);
                }
            }
        }

        private void FlipViewOfSectionsItems_Loaded(object sender, RoutedEventArgs e)
        {
            /*
            Stopwatch sw = Stopwatch.StartNew();
            var delay = Task.Delay(5000).ContinueWith(_ =>
            {
                sw.Stop();
                return sw.ElapsedMilliseconds;
            });
            */

            clickedSectionItem = (Item)SectionsItems[currentIndex];
            navigateToClickedFlipViewItem(clickedSectionItem);
            //clickedSectionItem = (Item)SectionsItems[2];
            //navigateToClickedFlipViewItem(clickedSectionItem);
        }

        private void itemsListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            clickedSectionItem = ((Item)e.ClickedItem);
            navigateToClickedFlipViewItem(clickedSectionItem);
        }
    }
}
