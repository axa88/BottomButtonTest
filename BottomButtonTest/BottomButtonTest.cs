using Xamarin.Forms;

namespace BottomButtonTest
{
	internal class Program : Xamarin.Forms.Platform.Tizen.FormsApplication
	{
		private static void Main(string[] args)
		{
			var app = new Program();
			Forms.Init(app);
			Tizen.Wearable.CircularUI.Forms.FormsCircularUI.Init();
			app.Run(args);
		}

		protected override void OnCreate()
		{
			base.OnCreate();
			LoadApplication(new App());
		}
	}
}
