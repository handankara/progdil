namespace RooterTests
{
	[TestClass]
	public class UnitTest1

		[TestMethod]
		public void ReplaceUnderScoreWithSpaceTest(){
		string testparam1 = "foobar";
		string testparam2 = "foo_bar";
		CheesyUnderscore cheesy = new CheesyUnderscore();
		string expected1 = "foobar";
		string expected2 = "foo bar";
		string actual1 = cheesy.ReplaceUnderScoreWithSpace(testparam1);
		string actual2 = cheesy.ReplaceUnderScoreWithSpace(testparam2);
		Assert.AreEqual(expected1, actual1);
		Assert.AreEqual(expected2, actual2);
		Assert.Inconclusive("Verify the correctness of this test method.");
	}
	{

	}