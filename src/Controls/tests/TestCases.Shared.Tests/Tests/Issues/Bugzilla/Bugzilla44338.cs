using NUnit.Framework;
using UITest.Appium;
using UITest.Core;

namespace Microsoft.Maui.TestCases.Tests.Issues
{
	[Category(UITestCategories.Cells)]
	public class Bugzilla44338 : _IssuesUITest
	{
		public Bugzilla44338(TestDevice testDevice) : base(testDevice)
		{
		}

		public override string Issue => "Tapping off of a cell with an open context action causes a crash in iOS 10";

		[Test]
		public void Bugzilla44338Test_SwipeAndTap()
		{
			App.SwipeRightToLeft("A");
			App.Tap("C");
		}

		[Test]
		public void Bugzilla44338Test_TouchAndHoldAndTap()
		{
			App.TouchAndHold("A");
			App.Tap("C");
		}
	}
}