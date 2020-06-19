using System.Threading.Tasks;
using Xamarin.Forms;
using Tizen.Wearable.CircularUI.Forms;
using Xamarin.Forms.PlatformConfiguration.TizenSpecific;
using Application = Xamarin.Forms.Application;
using Label = Xamarin.Forms.Label;

namespace BottomButtonTest
{
	public class App : Application
	{
		public App() => _ = GoToContentPage();

		private async Task GoToContentPage()
		{
			var actionButton = new Button { BackgroundColor = Color.Orange };
			//AbsoluteLayout.SetLayoutBounds(actionButton, new Rectangle(0, 150, 150, 100));
			actionButton.On<Xamarin.Forms.PlatformConfiguration.Tizen>().SetStyle(ButtonStyle.Bottom);
			actionButton.Clicked += async (sender, args) =>
			{
				// ignore this bad code
				await Device.InvokeOnMainThreadAsync(async () => { await ButtonWorker(); }).ConfigureAwait(false);
			};

			var profileEditView = new CircleStackLayout
			{
				Padding = new Thickness(0, 25, 0, 70),
				HorizontalOptions = LayoutOptions.Center,
				Children =
				{
					new Label
					{
						FontSize = 8,
						HorizontalTextAlignment = TextAlignment.Center,
						BackgroundColor = Color.Black,
						Text = "Content Page",
					},
					new StackLayout
					{
						VerticalOptions = LayoutOptions.Center,
						Orientation = StackOrientation.Horizontal,
						Children =
						{
							new Label { VerticalOptions = LayoutOptions.Center, FontSize = 12, Text = "🗺:" },
							new PopupEntry { Text = "abc" }
						}
					},
					new StackLayout
					{
						VerticalOptions = LayoutOptions.Center,
						Orientation = StackOrientation.Horizontal,
						Children =
						{
							new Label { VerticalOptions = LayoutOptions.Center, FontSize = 12, Text = "🗺:" },
							new PopupEntry { Text = "abc" }
						}
					},
					new StackLayout
					{
						VerticalOptions = LayoutOptions.Center,
						Orientation = StackOrientation.Horizontal,
						Children =
						{
							new Label { VerticalOptions = LayoutOptions.Center, FontSize = 12, Text = "🗺:" },
							new PopupEntry { Text = "abc" }
						}
					},
					new StackLayout
					{
						VerticalOptions = LayoutOptions.Center,
						Orientation = StackOrientation.Horizontal,
						Children =
						{
							new Label { VerticalOptions = LayoutOptions.Center, FontSize = 12, Text = "🗺:" },
							new PopupEntry { Text = "abc" }
						}
					}
				}
			};

			var profileEditScrollView = new CircleScrollView { Content = profileEditView };
			var stackLayout = new StackLayout { Children = { profileEditScrollView, actionButton } };
			MainPage = new ContentPage { Content = stackLayout };

			async Task ButtonWorker() => await GoToCirclePage().ConfigureAwait(false);

			actionButton.Text = "To CirclePage";
		}

		private async Task GoToCirclePage()
		{
			var circlePage = new CirclePage { ActionButton = new ActionButtonItem() };
			circlePage.ActionButton.Clicked += async (sender, args) =>
			{
				// ignore this bad code
				await Device.InvokeOnMainThreadAsync(async () => { await ButtonWorker(); }).ConfigureAwait(false);
			};

			var profileEditView = new CircleStackLayout
			{
				Padding = new Thickness(0, 25, 0, 70),
				HorizontalOptions = LayoutOptions.Center,
				Children =
				{
					new Label
					{
						FontSize = 8,
						HorizontalTextAlignment = TextAlignment.Center,
						BackgroundColor = Color.Black,
						Text = "CirclePage",
					},
					new StackLayout
					{
						VerticalOptions = LayoutOptions.Center,
						Orientation = StackOrientation.Horizontal,
						Children =
						{
							new Label { VerticalOptions = LayoutOptions.Center, FontSize = 12, Text = "🗺:" },
							new PopupEntry { Text = "abc" }
						}
					},
					new StackLayout
					{
						VerticalOptions = LayoutOptions.Center,
						Orientation = StackOrientation.Horizontal,
						Children =
						{
							new Label { VerticalOptions = LayoutOptions.Center, FontSize = 12, Text = "🗺:" },
							new PopupEntry { Text = "abc" }
						}
					},
					new StackLayout
					{
						VerticalOptions = LayoutOptions.Center,
						Orientation = StackOrientation.Horizontal,
						Children =
						{
							new Label { VerticalOptions = LayoutOptions.Center, FontSize = 12, Text = "🗺:" },
							new PopupEntry { Text = "abc" }
						}
					},
					new StackLayout
					{
						VerticalOptions = LayoutOptions.Center,
						Orientation = StackOrientation.Horizontal,
						Children =
						{
							new Label { VerticalOptions = LayoutOptions.Center, FontSize = 12, Text = "🗺:" },
							new PopupEntry { Text = "abc" }
						}
					}
				}
			};

			var profileEditScrollView = new CircleScrollView { Content = profileEditView };
			circlePage.Content = profileEditScrollView;
			MainPage = circlePage;

			async Task ButtonWorker() => await GoToContentPage().ConfigureAwait(false);

			circlePage.ActionButton.Text = "To ContentPage";

		}
	}
}
