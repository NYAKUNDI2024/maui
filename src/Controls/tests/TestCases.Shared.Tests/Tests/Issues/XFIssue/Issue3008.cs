using NUnit.Framework;
using UITest.Appium;
using UITest.Core;

namespace Microsoft.Maui.TestCases.Tests.Issues;

public class Issue3008 : _IssuesUITest
{
	public Issue3008(TestDevice testDevice) : base(testDevice)
	{
	}

	public override string Issue => "Setting ListView.ItemSource to null doesn't cause it clear out its contents";

	[Test]
	[Category(UITestCategories.ListView)]
	public void EnsureListViewEmptiesOut()
	{
		App.Tap("ClickUntilSuccess");
		App.WaitForElement("NotGroupedItemLabel");
		App.WaitForElement("GroupedItemLabel");

		App.Tap("ClickUntilSuccess");
		App.WaitForElement("NotGroupedItemLabel");
		App.WaitForElement("GroupedItemLabel");

		App.Tap("ClickUntilSuccess");
		App.WaitForNoElement("NotGroupedItemLabel");
		App.WaitForNoElement("GroupedItemLabel");

		App.Tap("ClickUntilSuccess");
		App.WaitForElement("NotGroupedItemLabel");
		App.WaitForElement("GroupedItemLabel");

		App.Tap("ClickUntilSuccess");
		App.WaitForNoElement("NotGroupedItemLabel");
		App.WaitForNoElement("GroupedItemLabel");

		App.Tap("ClickUntilSuccess");
		App.WaitForElement("NotGroupedItemLabel");
		App.WaitForElement("GroupedItemLabel");

		App.Tap("ClickUntilSuccess");
		App.WaitForNoElement("NotGroupedItemLabel");
		App.WaitForNoElement("GroupedItemLabel");
	}
}